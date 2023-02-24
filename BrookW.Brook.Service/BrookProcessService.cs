using BrookW.Brook.Model;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace BrookW.Brook.Service
{
    public class BrookProcessService : IDisposable
    {
        private readonly Process brookProcess;
        private bool disposed = false;

        public string ListenAddress { get; }
        public int ListenHttpPort { get; }
        public int ListenSocks5Port { get; }

        public BrookProcessService(Server server)
        {
            var listenAddress = "127.0.0.1";
            ListenAddress = listenAddress;

            //获取两个未被占用的端口
            var listenPorts = GetRandomPorts(2);
            ListenHttpPort = listenPorts[0];
            ListenSocks5Port = listenPorts[1];
            var exe = "brook_windows_386.exe";
            // 判断 exe 文件是否存在
            if (!File.Exists(exe))
            {
                throw new FileNotFoundException($"{exe} 文件不存在");
            }
            // 启动 Brook 客户端
            brookProcess = new Process();
            brookProcess.StartInfo.FileName = exe;
            var arg = string.Format(server.ClientCmdString, listenAddress, ListenHttpPort, ListenSocks5Port);
            brookProcess.StartInfo.Arguments = arg;
            brookProcess.StartInfo.RedirectStandardError = true;
            brookProcess.StartInfo.RedirectStandardOutput = true;
            brookProcess.StartInfo.UseShellExecute = false;
            brookProcess.StartInfo.CreateNoWindow = true;
            brookProcess.OutputDataReceived += new DataReceivedEventHandler((sender, e) =>
            {
                if (!String.IsNullOrEmpty(e.Data))
                {
                    Console.WriteLine(e.Data);
                }
            });
            brookProcess.ErrorDataReceived += new DataReceivedEventHandler((sender, e) =>
            {
                if (!String.IsNullOrEmpty(e.Data))
                {
                    Console.WriteLine(e.Data);
                }
            });
            try
            {
                brookProcess.Start();
                brookProcess.BeginOutputReadLine();
                brookProcess.BeginErrorReadLine();
            }
            catch
            {
                brookProcess.Dispose();
                throw;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    brookProcess.Dispose();
                }
                disposed = true;
            }
        }

        public void Stop()
        {

            if (!disposed && !brookProcess.HasExited)
            {
                brookProcess.Kill();
            }
        }

        /// <summary>
        /// 随机返回指定未被占用的端口
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        private List<int> GetRandomPorts(int count)
        {
            var ipProperties = IPGlobalProperties.GetIPGlobalProperties();
            var endPoints = ipProperties.GetActiveTcpListeners();
            var random = new Random();

            var availablePorts = Enumerable.Range(10800, 1000)
                .Except(endPoints.Select(p => p.Port))
                .OrderBy(p => random.Next())
                .Take(count);

            return availablePorts.ToList();
        }




    }

}