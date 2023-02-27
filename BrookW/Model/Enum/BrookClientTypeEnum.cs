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
        CLIENT = 0,

        /// <summary>
        /// wsclient
        /// </summary>
        [Description("brook wsserver")]
        WSCLIENT = 1,

        /// <summary>
        /// wssclient
        /// </summary>
        [Description("brook wssserver")]
        WSSCLIENT = 2,
        /// <summary>
        /// brook link
        /// </summary>
        [Description("brook connect")]
        CONNECT = 3,

    }
}
