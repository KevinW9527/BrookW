namespace BrookW.UC
{
    partial class ServerSave
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
            this.tlpServerSave = new System.Windows.Forms.TableLayoutPanel();
            this.cbBrookServerType = new System.Windows.Forms.ComboBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGoBackServerList = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tlpServerSave.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpServerSave
            // 
            this.tlpServerSave.ColumnCount = 5;
            this.tlpServerSave.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpServerSave.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpServerSave.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tlpServerSave.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpServerSave.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpServerSave.Controls.Add(this.cbBrookServerType, 2, 1);
            this.tlpServerSave.Controls.Add(this.txtServer, 2, 2);
            this.tlpServerSave.Controls.Add(this.txtPwd, 2, 3);
            this.tlpServerSave.Controls.Add(this.btnAdd, 2, 4);
            this.tlpServerSave.Controls.Add(this.toolStrip1, 0, 0);
            this.tlpServerSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpServerSave.Location = new System.Drawing.Point(0, 0);
            this.tlpServerSave.Name = "tlpServerSave";
            this.tlpServerSave.RowCount = 8;
            this.tlpServerSave.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpServerSave.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpServerSave.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpServerSave.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpServerSave.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpServerSave.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpServerSave.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpServerSave.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpServerSave.Size = new System.Drawing.Size(380, 475);
            this.tlpServerSave.TabIndex = 0;
            // 
            // cbBrookServerType
            // 
            this.cbBrookServerType.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbBrookServerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBrookServerType.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbBrookServerType.FormattingEnabled = true;
            this.cbBrookServerType.Items.AddRange(new object[] {
            "brook server",
            "brook wsserver",
            "brook wssserver",
            "brook link"});
            this.cbBrookServerType.Location = new System.Drawing.Point(73, 85);
            this.cbBrookServerType.Name = "cbBrookServerType";
            this.cbBrookServerType.Size = new System.Drawing.Size(234, 27);
            this.cbBrookServerType.TabIndex = 6;
            // 
            // txtServer
            // 
            this.txtServer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtServer.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtServer.Location = new System.Drawing.Point(73, 169);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(234, 24);
            this.txtServer.TabIndex = 7;
            // 
            // txtPwd
            // 
            this.txtPwd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtPwd.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPwd.Location = new System.Drawing.Point(73, 249);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(234, 24);
            this.txtPwd.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(73, 311);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(234, 32);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.tlpServerSave.SetColumnSpan(this.toolStrip1, 5);
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGoBackServerList,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(377, 36);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnGoBackServerList
            // 
            this.btnGoBackServerList.AutoSize = false;
            this.btnGoBackServerList.AutoToolTip = false;
            this.btnGoBackServerList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGoBackServerList.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGoBackServerList.Image = global::BrookW.Properties.Resources.backto;
            this.btnGoBackServerList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoBackServerList.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btnGoBackServerList.Margin = new System.Windows.Forms.Padding(0);
            this.btnGoBackServerList.Name = "btnGoBackServerList";
            this.btnGoBackServerList.Size = new System.Drawing.Size(68, 34);
            this.btnGoBackServerList.Text = "返回";
            this.btnGoBackServerList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoBackServerList.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(220, 33);
            this.toolStripLabel1.Text = "添加服务器";
            // 
            // ServerSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpServerSave);
            this.Name = "ServerSave";
            this.Size = new System.Drawing.Size(380, 475);
            this.tlpServerSave.ResumeLayout(false);
            this.tlpServerSave.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlpServerSave;
        private ComboBox cbBrookServerType;
        private TextBox txtServer;
        private TextBox txtPwd;
        public Button btnAdd;
        private ToolStrip toolStrip1;
        public ToolStripButton btnGoBackServerList;
        private ToolStripLabel toolStripLabel1;
    }
}
