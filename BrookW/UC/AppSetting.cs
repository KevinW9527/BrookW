using BrookW.Extend;
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
    public partial class AppSetting : UserControl
    {
        //配置信息
        private TencentCloudSetting appSetting;

        /// <summary>
        /// 
        /// </summary>
        public AppSetting()
        {
            InitializeComponent();
            //加载数据
            LoadAppSetting();
            lblMsg.Text = "";
        }

        public void LoadAppSetting()
        {
            appSetting = JsonHelper.ToObject<TencentCloudSetting>(Properties.Settings.Default.TencentCloudSetting) ?? new TencentCloudSetting();
            txtSecretId.Text = appSetting.SecretId?.Trim();
            txtSecretKey.Text = appSetting.SecretKey?.Trim();
            txtPath.Text = appSetting.Path?.Trim();
            txtLaunchTemplateId.Text = appSetting.LaunchTemplateId?.Trim();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var s = new TencentCloudSetting()
            {
                SecretId = txtSecretId.Text.Trim(),
                SecretKey = txtSecretKey.Text.Trim(),
                Path = txtPath.Text.Trim(),
                LaunchTemplateId = txtLaunchTemplateId.Text.Trim(),
            };

            if (s.Path.IndexOf("full.txt") < 0)
            {
                lblMsg.Text = Msg.PYTHONCRXFULLPATH;
                return;
            }

            Properties.Settings.Default.TencentCloudSetting = s.ToJson();
            Properties.Settings.Default.Save();

            lblMsg.Text = Msg.SAVESCUESS;
            timerHideMsg.Enabled = true;
        }

        private void timerHideMsg_Tick(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            timerHideMsg.Enabled = false;
        }
    }
}
