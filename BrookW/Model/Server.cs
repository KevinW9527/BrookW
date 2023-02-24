using BrookW.Model.Enum;

namespace BrookW.Model
{
    public class Server
    {
        public BrookClientTypeEnum Type { get; set; }

        /// <summary>
        /// 访问服务器完整 url，包括协议和path部分，如: ws://190.190.190.1:9999/web
        /// </summary>
        public string Url { get; set; } = null!;
        /// <summary>
        /// 访问服务器的密码
        /// </summary>
        public string Password { get; set; } = null!;

        /// <summary>
        /// 客户命令
        /// </summary>
        public string ClientCmdString
        {
            get
            {
                //switch (Type)
                //{
                //    case BrookClientTypeEnum.CLIENT:
                //        return " client --http :{0} --socks5 :{1} -s {2} -p {3}";
                //    case BrookClientTypeEnum.WSCLIENT:
                //        return " wsclient --http :{0} --socks5 :{1} -s {2} -p {3}";
                //    case BrookClientTypeEnum.WSSCLIENT:
                //        return " wssclient --http :{0} --socks5 :{1} -s {2} -p {3}";
                //}

                return string.Concat(Type.ToString().ToLower(), " --http {0}:{1} --socks5 {0}:{2}", $" -s {Url} -p {Password}");
            }
        }
    }
}