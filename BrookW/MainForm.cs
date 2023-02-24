using BrookW.Brook.Service;
using BrookW.Brook.Model;
using BrookW.Brook.Helper;
using BrookW.Extend;

namespace BrookW
{
    public partial class MainForm : Form
    {
        private BrookProcessService? brookClient;

        /// <summary>
        /// 
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            // 从配置文件读取配置
            serverAddressTextBox.Text = Properties.Settings.Default.ServerAddress;
            passwordTextBox.Text = Properties.Settings.Default.Password;
            comboBox1.Text = Properties.Settings.Default.ServerType;

            statusLabel.Text = "";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.favicon16;
            notifyIcon.Visible = true;
            notifyIcon.Icon = Icon;
            //this.WindowState = FormWindowState.Minimized;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // 隐藏窗口，将窗口最小化到右下角的通知区域
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
            }
            else
            {
                // 进程意外退出
                Exit();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = Msg.ShowConfirm("确认要退出该程序吗?");
            if (dialog == DialogResult.OK)
            {
                Exit();
            }
        }

        /// <summary>
        /// 退出应用程序
        /// </summary>
        private void Exit()
        {
            brookClient?.Stop();
            notifyIcon.Dispose();
            Application.Exit();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 显示设置窗口
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }

        private void saveConfig()
        {
            // 保存配置到配置文件
            Properties.Settings.Default.ServerAddress = serverAddressTextBox.Text.Trim();
            Properties.Settings.Default.Password = passwordTextBox.Text.Trim();
            Properties.Settings.Default.ServerType = comboBox1.Text.Trim();
            Properties.Settings.Default.Save();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            saveConfig();

            // 启动 Brook 客户端
            string serverAddress = serverAddressTextBox.Text;
            if (string.IsNullOrEmpty(serverAddress))
            {
                Msg.ShowError("服务器地址不能为空");
                return;
            }
            string password = passwordTextBox.Text;
            if (string.IsNullOrEmpty(password))
            {
                Msg.ShowError("密码不能为空");
                return;
            }
            var type = (Brook.Model.Enum.BrookClientTypeEnum)comboBox1.SelectedIndex;
            var server = new Server()
            {
                Type = type,
                Password = password,
                Url = serverAddress,
            };
            try
            {
                brookClient = new BrookProcessService(server);
                statusLabel.Text = "Brook client started.";
                //http
                SetProxyHelper.EnableProxy($"{brookClient.ListenAddress}:{brookClient.ListenHttpPort}");
                //
                //SetProxyHelper.EnableProxy($"socks5={brookClient.ListenAddress}:{brookClient.ListenSocks5Port}");

                startButton.Enabled = false;
                stopButton.Enabled = true;
            }
            catch (Exception ex)
            {
                Msg.ShowError(ex.Message);
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            // 停止 Brook 客户端
            brookClient?.Stop();
            statusLabel.Text = "Brook client stopped.";
            startButton.Enabled = true;
            stopButton.Enabled = false;
            SetProxyHelper.DisableProxy();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            // 将窗口最小化到右下角的通知区域
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // 还原窗口
            if (e.Button == MouseButtons.Left)
            {
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
            }
        }

    }
}