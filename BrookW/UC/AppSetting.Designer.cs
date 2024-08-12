namespace BrookW.UC
{
    partial class AppSetting
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
            this.components = new System.ComponentModel.Container();
            this.tlpServerSave = new System.Windows.Forms.TableLayoutPanel();
            this.txtSecretKey = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGoBackServerList = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.lblMsg = new System.Windows.Forms.Label();
            this.txtSecretId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timerHideMsg = new System.Windows.Forms.Timer(this.components);
            this.txtLaunchTemplateId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.tlpServerSave.Controls.Add(this.txtSecretKey, 2, 2);
            this.tlpServerSave.Controls.Add(this.txtPath, 2, 3);
            this.tlpServerSave.Controls.Add(this.toolStrip1, 0, 0);
            this.tlpServerSave.Controls.Add(this.txtSecretId, 2, 1);
            this.tlpServerSave.Controls.Add(this.label1, 0, 1);
            this.tlpServerSave.Controls.Add(this.label2, 0, 2);
            this.tlpServerSave.Controls.Add(this.label3, 0, 3);
            this.tlpServerSave.Controls.Add(this.lblMsg, 2, 6);
            this.tlpServerSave.Controls.Add(this.btnAdd, 2, 5);
            this.tlpServerSave.Controls.Add(this.txtLaunchTemplateId, 2, 4);
            this.tlpServerSave.Controls.Add(this.label4, 0, 4);
            this.tlpServerSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpServerSave.Location = new System.Drawing.Point(0, 0);
            this.tlpServerSave.Name = "tlpServerSave";
            this.tlpServerSave.RowCount = 7;
            this.tlpServerSave.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpServerSave.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpServerSave.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpServerSave.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpServerSave.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpServerSave.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpServerSave.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpServerSave.Size = new System.Drawing.Size(380, 475);
            this.tlpServerSave.TabIndex = 1;
            // 
            // txtSecretKey
            // 
            this.txtSecretKey.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtSecretKey.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSecretKey.Location = new System.Drawing.Point(73, 169);
            this.txtSecretKey.Name = "txtSecretKey";
            this.txtSecretKey.Size = new System.Drawing.Size(234, 24);
            this.txtSecretKey.TabIndex = 2;
            // 
            // txtPath
            // 
            this.txtPath.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtPath.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPath.Location = new System.Drawing.Point(73, 249);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(234, 24);
            this.txtPath.TabIndex = 3;
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
            this.btnAdd.Location = new System.Drawing.Point(73, 371);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(234, 32);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "保存";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.toolStripLabel1.Text = "配置设置";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMsg.ForeColor = System.Drawing.Color.Blue;
            this.lblMsg.Location = new System.Drawing.Point(73, 406);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(234, 69);
            this.lblMsg.TabIndex = 10;
            this.lblMsg.Text = "保存成功";
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSecretId
            // 
            this.txtSecretId.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtSecretId.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSecretId.Location = new System.Drawing.Point(73, 89);
            this.txtSecretId.Name = "txtSecretId";
            this.txtSecretId.Size = new System.Drawing.Size(234, 24);
            this.txtSecretId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tlpServerSave.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(3, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "SecId:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tlpServerSave.SetColumnSpan(this.label2, 2);
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(3, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "SecKey:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tlpServerSave.SetColumnSpan(this.label3, 2);
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Location = new System.Drawing.Point(3, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Path:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // timerHideMsg
            // 
            this.timerHideMsg.Interval = 1500;
            this.timerHideMsg.Tick += new System.EventHandler(this.timerHideMsg_Tick);
            // 
            // txtLaunchTemplateId
            // 
            this.txtLaunchTemplateId.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtLaunchTemplateId.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLaunchTemplateId.Location = new System.Drawing.Point(73, 319);
            this.txtLaunchTemplateId.Name = "txtLaunchTemplateId";
            this.txtLaunchTemplateId.Size = new System.Drawing.Size(234, 24);
            this.txtLaunchTemplateId.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.tlpServerSave.SetColumnSpan(this.label4, 2);
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Location = new System.Drawing.Point(3, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "模板ID:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // AppSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpServerSave);
            this.Name = "AppSetting";
            this.Size = new System.Drawing.Size(380, 475);
            this.tlpServerSave.ResumeLayout(false);
            this.tlpServerSave.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlpServerSave;
        private TextBox txtSecretKey;
        private TextBox txtPath;
        public Button btnAdd;
        private ToolStrip toolStrip1;
        public ToolStripButton btnGoBackServerList;
        public ToolStripLabel toolStripLabel1;
        private Label lblMsg;
        private System.Windows.Forms.Timer timerHideMsg;
        private TextBox txtSecretId;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtLaunchTemplateId;
        private Label label4;
    }
}
