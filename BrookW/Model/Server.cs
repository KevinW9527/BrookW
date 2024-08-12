using BrookW.Model.Enum;
using System.Text.Json.Serialization;

namespace BrookW.Model
{
    public class Server
    {
        public BrookClientTypeEnum Type { get; set; }

        /// <summary>
        /// 访问服务器完整 url，包括协议和path部分，如: ws://190.190.190.1:9999/web
        /// </summary>
        public string? Url { get; set; }
        /// <summary>
        /// 访问服务器的密码
        /// </summary>
        public string? Password { get; set; }

        /// <summary>
        /// 标签，方便批量查找
        /// </summary>
        public string? Tag { get; set; }

        /// <summary>
        /// 客户命令
        /// </summary>
        [JsonIgnore]
        public string ClientCmdString
        {
            get
            {
                switch (Type)
                {
                    case BrookClientTypeEnum.BROOKLINK:
                        return string.Concat("connect --http {0}:{1} --socks5 {0}:{2} -l ", Url);
                    default:
                        return string.Concat(Type.ToString().ToLower(), " --http {0}:{1} --socks5 {0}:{2}", $" -s {Url} -p {Password}");
                }


            }

        }

       

    }
}