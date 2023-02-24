using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrookW.Brook.Model.Enum
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
