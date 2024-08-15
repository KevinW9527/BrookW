using System.Windows.Forms;

namespace BrookW.UC
{
    partial class ServerList
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tlpServerList = new TableLayoutPanel();
            toolStrip1 = new ToolStrip();
            btnGoBackHome = new ToolStripButton();
            toolStripLabel1 = new ToolStripLabel();
            btnAddServer = new ToolStripButton();
            dgvServerList = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItemEdit = new ToolStripMenuItem();
            toolStripMenuItemDelete = new ToolStripMenuItem();
            Id = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            Url = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            ClientCmdString = new DataGridViewTextBoxColumn();
            Tags = new DataGridViewTextBoxColumn();
            tlpServerList.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServerList).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tlpServerList
            // 
            tlpServerList.BackColor = Color.Transparent;
            tlpServerList.ColumnCount = 5;
            tlpServerList.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpServerList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpServerList.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 240F));
            tlpServerList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpServerList.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpServerList.Controls.Add(toolStrip1, 0, 0);
            tlpServerList.Controls.Add(dgvServerList, 0, 1);
            tlpServerList.Dock = DockStyle.Fill;
            tlpServerList.Location = new Point(0, 0);
            tlpServerList.Name = "tlpServerList";
            tlpServerList.RowCount = 7;
            tlpServerList.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tlpServerList.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tlpServerList.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tlpServerList.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tlpServerList.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tlpServerList.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpServerList.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpServerList.Size = new Size(380, 475);
            tlpServerList.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.BackColor = Color.Transparent;
            tlpServerList.SetColumnSpan(toolStrip1, 5);
            toolStrip1.Dock = DockStyle.Fill;
            toolStrip1.GripMargin = new Padding(0);
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnGoBackHome, toolStripLabel1, btnAddServer });
            toolStrip1.Location = new Point(3, 0);
            toolStrip1.Margin = new Padding(3, 0, 0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.Size = new Size(377, 36);
            toolStrip1.TabIndex = 10;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnGoBackHome
            // 
            btnGoBackHome.AutoSize = false;
            btnGoBackHome.AutoToolTip = false;
            btnGoBackHome.BackgroundImageLayout = ImageLayout.Zoom;
            btnGoBackHome.Font = new Font("Microsoft YaHei UI", 10F);
            btnGoBackHome.Image = Properties.Resources.backto;
            btnGoBackHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnGoBackHome.ImageTransparentColor = Color.Transparent;
            btnGoBackHome.Margin = new Padding(0);
            btnGoBackHome.Name = "btnGoBackHome";
            btnGoBackHome.Size = new Size(68, 34);
            btnGoBackHome.Text = "返回";
            btnGoBackHome.TextAlign = ContentAlignment.MiddleLeft;
            btnGoBackHome.TextDirection = ToolStripTextDirection.Horizontal;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.AutoSize = false;
            toolStripLabel1.Font = new Font("Microsoft YaHei UI", 10F);
            toolStripLabel1.ImageAlign = ContentAlignment.MiddleLeft;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(220, 33);
            toolStripLabel1.Text = "服务器列表";
            // 
            // btnAddServer
            // 
            btnAddServer.Alignment = ToolStripItemAlignment.Right;
            btnAddServer.AutoSize = false;
            btnAddServer.BackgroundImageLayout = ImageLayout.None;
            btnAddServer.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAddServer.Font = new Font("Microsoft YaHei UI", 10F);
            btnAddServer.Image = Properties.Resources.plus;
            btnAddServer.ImageTransparentColor = Color.White;
            btnAddServer.Margin = new Padding(0, 0, 3, 0);
            btnAddServer.Name = "btnAddServer";
            btnAddServer.Size = new Size(34, 34);
            btnAddServer.Text = "添加服务器";
            btnAddServer.ToolTipText = "添加服务器";
            // 
            // dgvServerList
            // 
            dgvServerList.AllowUserToAddRows = false;
            dgvServerList.AllowUserToDeleteRows = false;
            dgvServerList.AllowUserToResizeColumns = false;
            dgvServerList.AllowUserToResizeRows = false;
            dgvServerList.BackgroundColor = Color.White;
            dgvServerList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvServerList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Transparent;
            dataGridViewCellStyle1.Font = new Font("宋体", 10F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvServerList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvServerList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServerList.Columns.AddRange(new DataGridViewColumn[] { Id, Type, Url, Password, ClientCmdString, Tags });
            tlpServerList.SetColumnSpan(dgvServerList, 5);
            dgvServerList.ContextMenuStrip = contextMenuStrip1;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("宋体", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvServerList.DefaultCellStyle = dataGridViewCellStyle5;
            dgvServerList.Dock = DockStyle.Fill;
            dgvServerList.EditMode = DataGridViewEditMode.EditOnKeystroke;
            dgvServerList.GridColor = Color.FromArgb(224, 224, 224);
            dgvServerList.Location = new Point(3, 39);
            dgvServerList.MultiSelect = false;
            dgvServerList.Name = "dgvServerList";
            dgvServerList.ReadOnly = true;
            dgvServerList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvServerList.RowHeadersVisible = false;
            dgvServerList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dgvServerList.RowsDefaultCellStyle = dataGridViewCellStyle6;
            tlpServerList.SetRowSpan(dgvServerList, 6);
            dgvServerList.RowTemplate.Height = 23;
            dgvServerList.RowTemplate.Resizable = DataGridViewTriState.True;
            dgvServerList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServerList.Size = new Size(374, 433);
            dgvServerList.TabIndex = 30;
            dgvServerList.CellMouseDoubleClick += dgvServerList_CellMouseDoubleClick;
            dgvServerList.CellMouseDown += dgvServerList_CellMouseDown;
            dgvServerList.RowPostPaint += dgvServerList_RowPostPaint;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItemEdit, toolStripMenuItemDelete });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(101, 48);
            // 
            // toolStripMenuItemEdit
            // 
            toolStripMenuItemEdit.Name = "toolStripMenuItemEdit";
            toolStripMenuItemEdit.Size = new Size(100, 22);
            toolStripMenuItemEdit.Text = "编辑";
            toolStripMenuItemEdit.Click += toolStripMenuItemEdit_Click;
            // 
            // toolStripMenuItemDelete
            // 
            toolStripMenuItemDelete.Name = "toolStripMenuItemDelete";
            toolStripMenuItemDelete.Size = new Size(100, 22);
            toolStripMenuItemDelete.Text = "删除";
            toolStripMenuItemDelete.Click += toolStripMenuItemDelete_Click;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Id.DefaultCellStyle = dataGridViewCellStyle2;
            Id.FillWeight = 50F;
            Id.HeaderText = "No";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Type
            // 
            Type.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Type.DataPropertyName = "Type";
            Type.FillWeight = 80F;
            Type.HeaderText = "类型";
            Type.Name = "Type";
            Type.ReadOnly = true;
            Type.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Url
            // 
            Url.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Url.DataPropertyName = "Url";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Url.DefaultCellStyle = dataGridViewCellStyle3;
            Url.FillWeight = 150F;
            Url.HeaderText = "地址";
            Url.Name = "Url";
            Url.ReadOnly = true;
            Url.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Password
            // 
            Password.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Password.DataPropertyName = "Password";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Password.DefaultCellStyle = dataGridViewCellStyle4;
            Password.FillWeight = 80F;
            Password.HeaderText = "密码";
            Password.Name = "Password";
            Password.ReadOnly = true;
            Password.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ClientCmdString
            // 
            ClientCmdString.DataPropertyName = "ClientCmdString";
            ClientCmdString.HeaderText = "ClientCmdString";
            ClientCmdString.Name = "ClientCmdString";
            ClientCmdString.ReadOnly = true;
            ClientCmdString.SortMode = DataGridViewColumnSortMode.NotSortable;
            ClientCmdString.Visible = false;
            // 
            // Tags
            // 
            Tags.DataPropertyName = "Tag";
            Tags.HeaderText = "Tag";
            Tags.Name = "Tags";
            Tags.ReadOnly = true;
            Tags.SortMode = DataGridViewColumnSortMode.NotSortable;
            Tags.Visible = false;
            // 
            // ServerList
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tlpServerList);
            Name = "ServerList";
            Size = new Size(380, 475);
            tlpServerList.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServerList).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpServerList;
        private ToolStrip toolStrip1;
        public ToolStripButton btnGoBackHome;
        private ToolStripLabel toolStripLabel1;
        private DataGridView dgvServerList;
        public ToolStripButton btnAddServer;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItemEdit;
        private ToolStripMenuItem toolStripMenuItemDelete;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Url;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn ClientCmdString;
        private DataGridViewTextBoxColumn Tags;
    }
}
