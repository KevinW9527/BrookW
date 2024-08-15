namespace BrookW.Helper
{
    using BrookW.Service;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Security.AccessControl;
    using System.Threading.Tasks;

    class FileDownloader
    {
        private Dictionary<string, long> remoteFileSizeCache = new Dictionary<string, long>();
        private Dictionary<string, byte[]> remoteFileByteCache = new Dictionary<string, byte[]>();

        public event EventHandler<DownloadProgressEventArgs>? DownloadProgressChanged;

        public async Task<bool> DownloadFileAsync(string url, BrookProcessService? brookClient, string localFilePath = "")
        {
            if (string.IsNullOrEmpty(url))
                return false;

            if (string.IsNullOrEmpty(localFilePath))
                localFilePath = Path.GetFileName(url);
            OnDownloadProgressChanged(new DownloadProgressEventArgs("开始升级Core…"));
            long remoteFileSize = await GetRemoteFileSizeAsync(url);
            if (remoteFileSize == -1)
            {
                OnDownloadProgressChanged(new DownloadProgressEventArgs("获取不到远程文件.\n请启动代理再试试."));
                return false;
            }
            if (File.Exists(localFilePath) && new FileInfo(localFilePath).Length == remoteFileSize)
            {
                OnDownloadProgressChanged(new DownloadProgressEventArgs("已是最新版本."));
                return true;
            }
            string tempFilePath = $"{localFilePath}_temp";

            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    HttpResponseMessage response = await httpClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    long fileSize = response.Content.Headers.ContentLength ?? -1;

                    using (FileStream fileStream = new FileStream(tempFilePath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None, bufferSize: 4096, useAsync: true))
                    {
                        long localTempFileSize = fileStream.Length;
                        if (localTempFileSize < fileSize)
                        {
                            using (Stream contentStream = await response.Content.ReadAsStreamAsync())
                            {
                                byte[] buffer = new byte[4096];
                                long totalBytesRead = localTempFileSize;
                                int bytesRead;

                                while ((bytesRead = await contentStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                                {
                                    await fileStream.WriteAsync(buffer, 0, bytesRead);
                                    totalBytesRead += bytesRead;
                                    if (fileSize > 0)
                                    {
                                        double percentage = (double)totalBytesRead / fileSize * 100;
                                        var text = $"下载进度：{(int)percentage}%";
                                        OnDownloadProgressChanged(new DownloadProgressEventArgs(text));
                                    }
                                }
                            }
                        }
                    }
                    OnDownloadProgressChanged(new DownloadProgressEventArgs("开始校验文件一致性…"));
                    if (await IsFileIntegrityValid(tempFilePath, url))
                    {
                        OnDownloadProgressChanged(new DownloadProgressEventArgs("文件一致,开始升级…"));
                        if (brookClient != null)
                            brookClient.Stop();

                        if (File.Exists(localFilePath)) {

                            FileSecurity fileSecurity = new FileSecurity(localFilePath, AccessControlSections.Access);

                            AuthorizationRuleCollection accessRules = fileSecurity.GetAccessRules(true, true, typeof(System.Security.Principal.SecurityIdentifier));
                            bool hasDeletePermission = false;

                            foreach (FileSystemAccessRule rule in accessRules)
                            {
                                if ((FileSystemRights.Delete & rule.FileSystemRights) == FileSystemRights.Delete &&
                                    rule.AccessControlType == AccessControlType.Allow)
                                {
                                    hasDeletePermission = true;
                                    break;
                                }
                            }

                            if (!hasDeletePermission)
                            {
                                OnDownloadProgressChanged(new DownloadProgressEventArgs($"当前用户没有足够的权限来删除{localFilePath}文件."));
                                return false;
                            }
                            File.Delete(localFilePath);
                        }
                       

                        File.Move(tempFilePath, localFilePath);
                        OnDownloadProgressChanged(new DownloadProgressEventArgs("更新完毕."));
                        return true;
                    }
                    else
                    {
                        OnDownloadProgressChanged(new DownloadProgressEventArgs("文件不一致，请再次升级."));
                        File.Delete(tempFilePath);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                OnDownloadProgressChanged(new DownloadProgressEventArgs($"下载文件失败：{ex.Message}"));
                return false;
            }
        }

        protected virtual void OnDownloadProgressChanged(DownloadProgressEventArgs e)
        {
            DownloadProgressChanged?.Invoke(this, e);
        }

        private async Task<long> GetRemoteFileSizeAsync(string url)
        {
            if (remoteFileSizeCache.TryGetValue(url, out long fileSize))
                return fileSize;

            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    httpClient.Timeout = TimeSpan.FromSeconds(30);

                    var rq = new HttpRequestMessage(HttpMethod.Head, url);

                    HttpResponseMessage response = await httpClient.SendAsync(rq);
                    response.EnsureSuccessStatusCode();
                    fileSize = response.Content.Headers.ContentLength ?? -1;
                    remoteFileSizeCache[url] = fileSize;
                    return fileSize;
                }

            }
            catch (Exception ex)
            {
                OnDownloadProgressChanged(new DownloadProgressEventArgs(ex.Message));
                return -1;
            }
        }

        private async Task<bool> IsFileIntegrityValid(string filePath, string url)
        {
            try
            {
                long fileSize = new FileInfo(filePath).Length;
                long remoteFileSize = await GetRemoteFileSizeAsync(url);
                if (fileSize != remoteFileSize)
                    return false;

                string localFileMD5 = MD5Helper.CalculateMD5(filePath);
                string remoteFileMD5 = await GetRemoteFileMD5(url);

                return string.Equals(localFileMD5, remoteFileMD5, StringComparison.OrdinalIgnoreCase);
            }
            catch
            {
                return false;
            }
        }

        private async Task<string> GetRemoteFileMD5(string url)
        {
            var data = await GetRemoteFileBytes(url);
            return MD5Helper.CalculateMD5(data);
        }

        private async Task<byte[]> GetRemoteFileBytes(string url)
        {
            if (remoteFileByteCache.TryGetValue(url, out byte[]? data))
                return data;

            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage response = await httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();
                data = await response.Content.ReadAsByteArrayAsync();
                remoteFileByteCache[url] = data;
                return data;
            }
        }
    }

    class DownloadProgressEventArgs : EventArgs
    {
        public object Percentage { get; }

        public DownloadProgressEventArgs(object percentage)
        {
            Percentage = percentage;
        }
    }

}
