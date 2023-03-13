using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrookW.Model
{
    /// <summary>
    /// 全局变量
    /// </summary>
    public class Gobal
    {
        /// <summary>
        /// 本机回送地址
        /// </summary>
        public const string LoopbackAddress = "127.0.0.1";

        /// <summary>
        /// brook 命令行程序
        /// </summary>
        public const string BrookCoreFile = "brook_windows_386.exe";

        /// <summary>
        /// brook最新核心版本url
        /// </summary>
        public const string BrookCoreUrl = $"https://github.com/txthinking/brook/releases/latest/download/{BrookCoreFile}";



        public const string ServerTip = "Server,like 1.2.3.4:9999";
        public const string WSServerTip = "Server,like ws://1.2.3.4:80/web";
        public const string WSSServerTip = "Server,like wss://domain.com:443/web";
        public const string BrookLinkTip = "brook://";
        public const string PasswordTip = "Password";
       

    }
}
