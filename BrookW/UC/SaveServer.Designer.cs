namespace BrookW.UC
{
    partial class SaveServer
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
            this.TLP_Home = new System.Windows.Forms.TableLayoutPanel();
            this.cbBrookServerType = new System.Windows.Forms.ComboBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGoBack = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.TLP_Home.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLP_Home
            // 
            this.TLP_Home.ColumnCount = 5;
            this.TLP_Home.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TLP_Home.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_Home.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.TLP_Home.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_Home.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TLP_Home.Controls.Add(this.cbBrookServerType, 2, 1);
            this.TLP_Home.Controls.Add(this.txtServer, 2, 2);
            this.TLP_Home.Controls.Add(this.txtPwd, 2, 3);
            this.TLP_Home.Controls.Add(this.btnAdd, 2, 4);
            this.TLP_Home.Controls.Add(this.toolStrip1, 0, 0);
            this.TLP_Home.Controls.Add(this.label1, 2, 0);
            this.TLP_Home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Home.Location = new System.Drawing.Point(0, 0);
            this.TLP_Home.Name = "TLP_Home";
            this.TLP_Home.RowCount = 6;
            this.TLP_Home.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TLP_Home.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TLP_Home.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TLP_Home.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TLP_Home.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TLP_Home.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Home.Size = new System.Drawing.Size(380, 475);
            this.TLP_Home.TabIndex = 0;
            // 
            // cbBrookServerType
            // 
            this.cbBrookServerType.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbBrookServerType.FormattingEnabled = true;
            this.cbBrookServerType.Items.AddRange(new object[] {
            "brook server",
            "brook wsserver",
            "brook wssserver",
            "brook link"});
            this.cbBrookServerType.Location = new System.Drawing.Point(88, 112);
            this.cbBrookServerType.Name = "cbBrookServerType";
            this.cbBrookServerType.Size = new System.Drawing.Size(234, 25);
            this.cbBrookServerType.TabIndex = 6;
            // 
            // txtServer
            // 
            this.txtServer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtServer.Location = new System.Drawing.Point(88, 164);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(234, 23);
            this.txtServer.TabIndex = 7;
            // 
            // txtPwd
            // 
            this.txtPwd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtPwd.Location = new System.Drawing.Point(88, 214);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(234, 23);
            this.txtPwd.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAdd.Location = new System.Drawing.Point(88, 264);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(234, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.TLP_Home.SetColumnSpan(this.toolStrip1, 2);
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.btnGoBack});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(85, 40);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // btnGoBack
            // 
            this.btnGoBack.AutoSize = false;
            this.btnGoBack.AutoToolTip = false;
            this.btnGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGoBack.Image = global::BrookW.Properties.Resources.backto;
            this.btnGoBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoBack.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btnGoBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(65, 35);
            this.btnGoBack.Text = "返回";
            this.btnGoBack.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(88, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "添加服务器";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaveServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TLP_Home);
            this.Name = "SaveServer";
            this.Size = new System.Drawing.Size(380, 475);
            this.TLP_Home.ResumeLayout(false);
            this.TLP_Home.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel TLP_Home;
        private Label label1;
        private ComboBox cbBrookServerType;
        private TextBox txtServer;
        private TextBox txtPwd;
        public Button btnAdd;
        private ToolStrip toolStrip1;
        public ToolStripButton btnGoBack;
        private ToolStripSeparator toolStripSeparator1;
    }
}
