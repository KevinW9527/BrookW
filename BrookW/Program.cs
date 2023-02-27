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
                Msg.ShowWarning("Ӧ�ó������һ��ʵ����������");
                return;
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            mutex.ReleaseMutex();
        }

        private static string GetAppName()
        {
            // ��ȡ��ǰ���򼯵���Ϣ
            var assembly = Assembly.GetEntryAssembly();
            // ��ȡ���򼯵�����
            var assemblyName = assembly?.GetName()?.Name;
            var appName = $"{assemblyName}";
            return appName;
        }

    }


}