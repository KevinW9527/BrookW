using BrookW.Helper;
using BrookW.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrookW.UC
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 检查更新事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            UpdateCore();
        }

        /// <summary>
        /// 更新core
        /// </summary>
        private async void UpdateCore()
        {
            // 下载器
            var downloader = new FileDownloader();
            downloader.DownloadProgressChanged += (sender, e) =>
            {
                statusLabel.Text = ($"下载进度：{e.Percentage}%");
            };
            var success = await downloader.DownloadFileAsync(Gobal.BrookCoreUrl);
            if (success)
            {
                statusLabel.Text = "";
                Console.WriteLine("下载完成");
            }
            else
            {
                statusLabel.Text = "下载失败";
                Console.WriteLine("下载失败");
            }
        }
    }
}
