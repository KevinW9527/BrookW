using BrookW.Extend;
using BrookW.Helper;
using BrookW.Model;
using BrookW.Model.Enum;
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
    public partial class ServerSave : UserControl
    {

        private string serverTip = Gobal.ServerTip;
        private string passwordTip = Gobal.PasswordTip;
        private Server? editServer;

        /// <summary>
        /// 
        /// </summary>
        public ServerSave()
        {
            InitializeComponent();

            txtServer.Enter += txtServer_Enter;
            txtServer.Leave += txtServer_Leave;

            cbBrookServerType.SelectedIndexChanged += CbBrookServerType_SelectedIndexChanged;
            cbBrookServerType.SelectedIndex = 0;
            txtPwd.Enter += TxtPwd_Enter;
            txtPwd.Leave += TxtPwd_Leave;
            lblMsg.Text = "";
        }

        private void TxtPwd_Leave(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPwd.Text))
            {
                txtPwd.Text = passwordTip;
                txtPwd.ForeColor = Color.Gray;
            }
        }

        private void TxtPwd_Enter(object? sender, EventArgs e)
        {
            if (txtPwd.Text == passwordTip)
            {
                txtPwd.Text = "";
                txtPwd.ForeColor = Color.Black;
            }
        }

        private void CbBrookServerType_SelectedIndexChanged(object? sender, EventArgs e)
        {
            var index = cbBrookServerType.SelectedIndex;
            txtPwd.Visible = true;
            switch (index)
            {
                case 1:
                    serverTip = Gobal.WSServerTip;
                    break;
                case 2:
                    serverTip = Gobal.WSSServerTip;
                    break;
                case 3:
                    serverTip = Gobal.BrookLinkTip;
                    txtPwd.Visible = false;
                    txtPwd.Text = "";
                    break;
                default:
                    serverTip = Gobal.ServerTip;
                    break;
            }
            txtServer.Text = serverTip;
            txtServer.ForeColor = Color.Gray;
            txtPwd.Text = passwordTip;
            txtPwd.ForeColor = Color.Gray;
        }

        private void txtServer_Enter(object? sender, EventArgs e)
        {
            if (txtServer.Text == serverTip)
            {
                txtServer.Text = "";
                txtServer.ForeColor = Color.Black;
            }
        }

        private void txtServer_Leave(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtServer.Text))
            {
                txtServer.Text = serverTip;
                txtServer.ForeColor = Color.Gray;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtServer.Text) || txtServer.Text == serverTip)
            {
                Msg.ShowError(Msg.SERVEREMPTY);
                return;
            }
            if ((string.IsNullOrEmpty(txtPwd.Text) || txtPwd.Text == passwordTip) && txtPwd.Visible)
            {
                Msg.ShowError(Msg.PASSWORDEMPTY);
                return;
            }
            var currServers = JsonHelper.ToObject<List<Server>>(Properties.Settings.Default.Servers);
            if (currServers == null)
            {
                currServers = new List<Server>();
            }
            var server = new Server()
            {
                Type = (BrookClientTypeEnum)cbBrookServerType.SelectedIndex,
                Password = txtPwd.Text.Trim(),
                Url = txtServer.Text.Trim(),
                Tag = txtTag.Text.Trim(),
            };
            //移除brook link 的密码对象
            if (server.Type == BrookClientTypeEnum.BROOKLINK)
            {
                server.Password = "";
            }
            if (editServer != null)
            {
                var editObj = currServers.FirstOrDefault(f => f.ClientCmdString == editServer.ClientCmdString);
                if (editObj != null)
                    currServers.Remove(editObj);
            }
            if (!currServers.Contains(server))
                currServers.Add(server);

            var json = currServers.GroupBy(x => x.ClientCmdString).Select(g => g.First()).ToList().ToJson();
            Properties.Settings.Default.Servers = json;
            Properties.Settings.Default.Save();


            lblMsg.Text = Msg.SAVESCUESS;
            timerHideMsg.Enabled = true;
            CbBrookServerType_SelectedIndexChanged(sender, e);
        }

        private void timerHideMsg_Tick(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            timerHideMsg.Enabled = false;
        }

        public void InitSaveServer(Model.Server? server = null)
        {
            editServer = server;
            if (server == null)
            {
                toolStripLabel1.Text = Msg.SERVERADDTITLE;
                btnAdd.Text = Msg.SERVERADDBTNTEXT;
                CbBrookServerType_SelectedIndexChanged(null, EventArgs.Empty);

            }
            else
            {
                toolStripLabel1.Text = Msg.SERVEREDITTITLE;
                btnAdd.Text = Msg.SERVEREDITBTNTEXT;
                cbBrookServerType.SelectedIndex = (int)server.Type;
                txtServer.Text = server.Url;
                txtServer.ForeColor = Color.Black;
                txtPwd.Text = server.Password;
                txtPwd.ForeColor = Color.Black;
            }
        }

    }
}
