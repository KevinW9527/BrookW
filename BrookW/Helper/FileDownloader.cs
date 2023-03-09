namespace BrookW.Helper
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading.Tasks;

    class FileDownloader
    {
        /// <summary>
        /// 下载进度事件
        /// </summary>
        public event EventHandler<DownloadProgressEventArgs>? DownloadProgressChanged;

        /// <summary>
        /// 异步下载文件
        /// </summary>
        /// <param name="url"></param>
        /// <param name="localFilePath"></param>
        /// <returns></returns>
        public async Task<bool> DownloadFileAsync(string url, string localFilePath = "")
        {
            if (string.IsNullOrEmpty(url))
            {
                return false;
            }
            if (string.IsNullOrEmpty(localFilePath))
            {
                localFilePath = Path.GetFileName(url);
            }
            // 检查本地文件是否存在
            if (File.Exists(localFilePath))
            {
                // 获取远程文件的大小
                long remoteFileSize = await GetRemoteFileSizeAsync(url);
                if (remoteFileSize <= 0) return false;

                // 获取本地文件的大小
                long localFileSize = new FileInfo(localFilePath).Length;

                // 如果本地文件已经是最新版本，则直接返回
                if (remoteFileSize == localFileSize)
                {
                    return true;
                }
            }

            // 临时文件名
            string tempFileName = $"{Path.GetFileName(localFilePath)}_temp";

            // 临时文件路径
            string tempFilePath = Path.Combine(Path.GetDirectoryName(localFilePath), tempFileName);

            try
            {
                // 创建HttpClient对象
                HttpClient httpClient = new HttpClient();

                // 获取文件长度
                HttpResponseMessage response = await httpClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead);
                response.EnsureSuccessStatusCode();
                long fileSize = response.Content.Headers.ContentLength ?? -1;

                // 打开网络流
                using (Stream contentStream = await response.Content.ReadAsStreamAsync())
                {
                    // 打开本地流
                    using (FileStream fileStream = new FileStream(tempFilePath, FileMode.Create, FileAccess.Write, FileShare.None, bufferSize: 4096, useAsync: true))
                    {
                        // 定义缓冲区和变量
                        byte[] buffer = new byte[4096];
                        long totalBytesRead = 0;
                        int bytesRead = 0;

                        // 下载文件并更新进度条
                        while ((bytesRead = await contentStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                        {
                            await fileStream.WriteAsync(buffer, 0, bytesRead);

                            totalBytesRead += bytesRead;
                            if (fileSize > 0)
                            {
                                double percentage = (double)totalBytesRead / fileSize * 100;
                                OnDownloadProgressChanged(new DownloadProgressEventArgs((int)percentage));
                            }
                        }
                    }
                }

                // 如果本地已经存在该文件，则删除原有文件
                if (File.Exists(localFilePath))
                {
                    File.Delete(localFilePath);
                }

                // 将临时文件移动到本地文件路径
                File.Move(tempFilePath, localFilePath);

                // 删除临时文件
                File.Delete(tempFilePath);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"下载文件失败：{ex.Message}");
                return false;
            }
        }

        protected virtual void OnDownloadProgressChanged(DownloadProgressEventArgs e)
        {
            DownloadProgressChanged?.Invoke(this, e);
        }

        private static async Task<long> GetRemoteFileSizeAsync(string url)
        {
            try
            {
                // 创建HttpClient对象
                HttpClient httpClient = new HttpClient();

                // 获取远程文件的大小
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Head, url);
                HttpResponseMessage response = await httpClient.SendAsync(request);
                response.EnsureSuccessStatusCode();
                return response.Content.Headers.ContentLength ?? -1;
            }
            catch
            {
                return -1;
            }
        }
    }
    class DownloadProgressEventArgs : EventArgs
    {
        public int Percentage { get; }

        public DownloadProgressEventArgs(int percentage)
        {
            Percentage = percentage;
        }
    }
}
