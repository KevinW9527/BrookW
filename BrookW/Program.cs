using BrookW.Extend;
using System.Reflection;

namespace BrookW
{
    internal static class Program
    {
        private static Mutex? mutex = null;

        [STAThread]
        static void Main()
        {
            var appName = GetAppName();
            bool createdNew;
            mutex = new Mutex(true, appName, out createdNew);
            if (!createdNew)
            {
                Msg.ShowWarning("应用程序的另一个实例已在运行");
                return;
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            mutex.ReleaseMutex();
        }

        private static string GetAppName()
        {
            // 获取当前程序集的信息
            var assembly = Assembly.GetEntryAssembly();
            // 获取程序集的名称
            var assemblyName = assembly?.GetName()?.Name;
            var appName = $"{assemblyName}";
            return appName;
        }

    }


}