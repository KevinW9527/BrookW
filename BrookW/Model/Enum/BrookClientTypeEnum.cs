using System.ComponentModel;

namespace BrookW.Model.Enum
{
    /// <summary>
    /// 客户端类型
    /// </summary>
    public enum BrookClientTypeEnum
    {
        /// <summary>
        /// client
        /// </summary>
        [Description("brook server")]
        CLIENT,

        /// <summary>
        /// wsclient
        /// </summary>
        [Description("brook wsserver")]
        WSCLIENT,

        /// <summary>
        /// wssclient
        /// </summary>
        [Description("brook wssserver")]
        WSSCLIENT,
    }
}
