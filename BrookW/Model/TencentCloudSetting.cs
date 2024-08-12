using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrookW.Model
{
    public class TencentCloudSetting
    {

        /// <summary>
        /// cloud.tencent SecretId
        /// </summary>
        public string? SecretId { get; set; }
        /// <summary>
        /// cloud.tencent SecretKey
        /// </summary>
        public string? SecretKey { get; set; }

        /// <summary>
        /// 配置python输出文件的路径
        /// </summary>
        public string? Path { get; set; }

        /// <summary>
        /// 启动模板id
        /// </summary>
        public string? LaunchTemplateId { get; set; }
    }
}
