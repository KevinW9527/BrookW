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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpServerList = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGoBackHome = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnAddServer = new System.Windows.Forms.ToolStripButton();
            this.DGV_RecordDetail = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpServerList.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_RecordDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpServerList
            // 
            this.tlpServerList.BackColor = System.Drawing.Color.Transparent;
            this.tlpServerList.ColumnCount = 5;
            this.tlpServerList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpServerList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpServerList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tlpServerList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpServerList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpServerList.Controls.Add(this.toolStrip1, 0, 0);
            this.tlpServerList.Controls.Add(this.DGV_RecordDetail, 0, 1);
            this.tlpServerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpServerList.Location = new System.Drawing.Point(0, 0);
            this.tlpServerList.Name = "tlpServerList";
            this.tlpServerList.RowCount = 8;
            this.tlpServerList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpServerList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpServerList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpServerList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpServerList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpServerList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpServerList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpServerList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpServerList.Size = new System.Drawing.Size(380, 475);
            this.tlpServerList.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.tlpServerList.SetColumnSpan(this.toolStrip1, 5);
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGoBackHome,
            this.toolStripLabel1,
            this.btnAddServer});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(377, 36);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnGoBackHome
            // 
            this.btnGoBackHome.AutoSize = false;
            this.btnGoBackHome.AutoToolTip = false;
            this.btnGoBackHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGoBackHome.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGoBackHome.Image = global::BrookW.Properties.Resources.backto;
            this.btnGoBackHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoBackHome.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btnGoBackHome.Margin = new System.Windows.Forms.Padding(0);
            this.btnGoBackHome.Name = "btnGoBackHome";
            this.btnGoBackHome.Size = new System.Drawing.Size(68, 34);
            this.btnGoBackHome.Text = "返回";
            this.btnGoBackHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoBackHome.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(220, 33);
            this.toolStripLabel1.Text = "服务器列表";
            // 
            // btnAddServer
            // 
            this.btnAddServer.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnAddServer.AutoSize = false;
            this.btnAddServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddServer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddServer.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddServer.Image = global::BrookW.Properties.Resources.plus;
            this.btnAddServer.ImageTransparentColor = System.Drawing.Color.White;
            this.btnAddServer.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnAddServer.Name = "btnAddServer";
            this.btnAddServer.Size = new System.Drawing.Size(34, 34);
            this.btnAddServer.Text = "添加服务器";
            this.btnAddServer.ToolTipText = "添加服务器";
            // 
            // DGV_RecordDetail
            // 
            this.DGV_RecordDetail.AllowUserToAddRows = false;
            this.DGV_RecordDetail.AllowUserToDeleteRows = false;
            this.DGV_RecordDetail.AllowUserToResizeColumns = false;
            this.DGV_RecordDetail.AllowUserToResizeRows = false;
            this.DGV_RecordDetail.BackgroundColor = System.Drawing.Color.White;
            this.DGV_RecordDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_RecordDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_RecordDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_RecordDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Type,
            this.Url,
            this.Password});
            this.tlpServerList.SetColumnSpan(this.DGV_RecordDetail, 5);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_RecordDetail.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_RecordDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_RecordDetail.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.DGV_RecordDetail.EnableHeadersVisualStyles = false;
            this.DGV_RecordDetail.Location = new System.Drawing.Point(3, 39);
            this.DGV_RecordDetail.MultiSelect = false;
            this.DGV_RecordDetail.Name = "DGV_RecordDetail";
            this.DGV_RecordDetail.RowHeadersVisible = false;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.DGV_RecordDetail.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tlpServerList.SetRowSpan(this.DGV_RecordDetail, 4);
            this.DGV_RecordDetail.RowTemplate.Height = 23;
            this.DGV_RecordDetail.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_RecordDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_RecordDetail.Size = new System.Drawing.Size(374, 304);
            this.DGV_RecordDetail.TabIndex = 30;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.HeaderText = "序号";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Type.HeaderText = "类型";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Url
            // 
            this.Url.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Url.FillWeight = 150F;
            this.Url.HeaderText = "地址";
            this.Url.Name = "Url";
            this.Url.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Password.HeaderText = "密码";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // ServerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpServerList);
            this.Name = "ServerList";
            this.Size = new System.Drawing.Size(380, 475);
            this.tlpServerList.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_RecordDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlpServerList;
        private ToolStrip toolStrip1;
        public ToolStripButton btnGoBackHome;
        private ToolStripLabel toolStripLabel1;
        private DataGridView DGV_RecordDetail;
        public ToolStripButton btnAddServer;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Url;
        private DataGridViewTextBoxColumn Password;
    }
}
