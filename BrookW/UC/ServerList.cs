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
using static System.Net.Mime.MediaTypeNames;

namespace BrookW.UC
{
    public partial class ServerList : UserControl
    {
        private List<Server> servers;

        /// <summary>
        /// 
        /// </summary>
        public ServerList()
        {
            InitializeComponent();
            LoadServers();
        }
        /// <summary>
        /// LoadServers
        /// </summary>
        public void LoadServers()
        {
            servers = JsonHelper.ToObject<List<Server>>(Properties.Settings.Default.Servers) ?? new List<Server>();
            var bs = new BindingSource();
            bs.DataSource = servers;
            dgvServerList.DataSource = bs;

        }

        /// <summary>
        /// 增加序号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvServerList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var v = dgvServerList.Rows[e.RowIndex].Cells[0].Value;
                if (v == null)
                    dgvServerList.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
                //var b = new SolidBrush(dgvServerList.RowHeadersDefaultCellStyle.ForeColor);
                //e.Graphics.DrawString((e.RowIndex + 1).ToString(System.Globalization.CultureInfo.CurrentUICulture), this.dgvServerList.DefaultCellStyle.Font, b, e.RowBounds.Location.X + 20, e.RowBounds.Location.Y + 4);
            }

        }
        /// <summary>
        /// 右键选中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvServerList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)//右键点击时
            {
                if (e.RowIndex >= 0)//行内有数据时
                {
                    dgvServerList.ClearSelection();
                    dgvServerList.Rows[e.RowIndex].Selected = true;
                    dgvServerList.SelectedCells[e.ColumnIndex].Selected = true;
                }
            }

        }

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemEdit_Click(object sender, EventArgs e)
        {
            var selectedItem = dgvServerList.CurrentRow.DataBoundItem as Server;
            if (selectedItem != null)
            {
                if (Parent.Parent is MainForm)
                {
                    var parent = Parent.Parent as MainForm;
                    if (parent != null)
                        parent.EditServer(selectedItem);

                }
            }
            else
                Msg.ShowInfo(Msg.UNSELECTED);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemDelete_Click(object sender, EventArgs e)
        {
            var selectedItem = dgvServerList.CurrentRow.DataBoundItem as Server;
            if (selectedItem != null)
            {
                servers.Remove(selectedItem);
                Properties.Settings.Default.Servers = servers.ToJson();
                Properties.Settings.Default.Save();
                LoadServers();
            }
            else
            {
                Msg.ShowError(Msg.UNSELECTED);
            }
        }

        /// <summary>
        /// 跳转编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvServerList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            toolStripMenuItemEdit_Click(sender, e);
        }
    }
}
