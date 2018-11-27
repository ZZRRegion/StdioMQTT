namespace StdioMQTT
{
    partial class FrmMain
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblServer = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.grpSubscribe = new System.Windows.Forms.GroupBox();
            this.lstSubscribeTopic = new System.Windows.Forms.ListBox();
            this.btnAddSubscribe = new System.Windows.Forms.Button();
            this.txtSubscribe = new System.Windows.Forms.TextBox();
            this.lblSubscribeTopic = new System.Windows.Forms.Label();
            this.grpPublish = new System.Windows.Forms.GroupBox();
            this.btnSendPublish = new System.Windows.Forms.Button();
            this.rtbSendPublish = new System.Windows.Forms.RichTextBox();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblPublishTopic = new System.Windows.Forms.Label();
            this.txtPublishTopic = new System.Windows.Forms.TextBox();
            this.grpRecive = new System.Windows.Forms.GroupBox();
            this.rtbRecive = new System.Windows.Forms.RichTextBox();
            this.lblClientId = new System.Windows.Forms.Label();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.pnlBot = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.grpSubscribe.SuspendLayout();
            this.grpPublish.SuspendLayout();
            this.grpRecive.SuspendLayout();
            this.pnlBot.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(359, 16);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "连接";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(10, 20);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(89, 12);
            this.lblServer.TabIndex = 1;
            this.lblServer.Text = "代理服务地址：";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(110, 16);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(239, 21);
            this.txtServer.TabIndex = 2;
            this.txtServer.Text = "120.78.76.55";
            // 
            // grpSubscribe
            // 
            this.grpSubscribe.Controls.Add(this.lstSubscribeTopic);
            this.grpSubscribe.Controls.Add(this.btnAddSubscribe);
            this.grpSubscribe.Controls.Add(this.txtSubscribe);
            this.grpSubscribe.Controls.Add(this.lblSubscribeTopic);
            this.grpSubscribe.Location = new System.Drawing.Point(10, 80);
            this.grpSubscribe.Name = "grpSubscribe";
            this.grpSubscribe.Size = new System.Drawing.Size(273, 358);
            this.grpSubscribe.TabIndex = 3;
            this.grpSubscribe.TabStop = false;
            this.grpSubscribe.Text = "订阅";
            // 
            // lstSubscribeTopic
            // 
            this.lstSubscribeTopic.FormattingEnabled = true;
            this.lstSubscribeTopic.ItemHeight = 12;
            this.lstSubscribeTopic.Location = new System.Drawing.Point(15, 111);
            this.lstSubscribeTopic.Name = "lstSubscribeTopic";
            this.lstSubscribeTopic.Size = new System.Drawing.Size(240, 232);
            this.lstSubscribeTopic.TabIndex = 3;
            this.lstSubscribeTopic.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstSubscribeTopic_MouseDoubleClick);
            // 
            // btnAddSubscribe
            // 
            this.btnAddSubscribe.Location = new System.Drawing.Point(10, 78);
            this.btnAddSubscribe.Name = "btnAddSubscribe";
            this.btnAddSubscribe.Size = new System.Drawing.Size(75, 23);
            this.btnAddSubscribe.TabIndex = 2;
            this.btnAddSubscribe.Text = "订阅";
            this.btnAddSubscribe.UseVisualStyleBackColor = true;
            this.btnAddSubscribe.Click += new System.EventHandler(this.btnAddSubscribe_Click);
            // 
            // txtSubscribe
            // 
            this.txtSubscribe.Location = new System.Drawing.Point(10, 51);
            this.txtSubscribe.Name = "txtSubscribe";
            this.txtSubscribe.Size = new System.Drawing.Size(245, 21);
            this.txtSubscribe.TabIndex = 1;
            // 
            // lblSubscribeTopic
            // 
            this.lblSubscribeTopic.AutoSize = true;
            this.lblSubscribeTopic.Location = new System.Drawing.Point(10, 30);
            this.lblSubscribeTopic.Name = "lblSubscribeTopic";
            this.lblSubscribeTopic.Size = new System.Drawing.Size(65, 12);
            this.lblSubscribeTopic.TabIndex = 0;
            this.lblSubscribeTopic.Text = "订阅主题：";
            // 
            // grpPublish
            // 
            this.grpPublish.Controls.Add(this.btnSendPublish);
            this.grpPublish.Controls.Add(this.rtbSendPublish);
            this.grpPublish.Controls.Add(this.lblContent);
            this.grpPublish.Controls.Add(this.lblPublishTopic);
            this.grpPublish.Controls.Add(this.txtPublishTopic);
            this.grpPublish.Location = new System.Drawing.Point(292, 80);
            this.grpPublish.Name = "grpPublish";
            this.grpPublish.Size = new System.Drawing.Size(273, 358);
            this.grpPublish.TabIndex = 4;
            this.grpPublish.TabStop = false;
            this.grpPublish.Text = "发布";
            // 
            // btnSendPublish
            // 
            this.btnSendPublish.Location = new System.Drawing.Point(10, 320);
            this.btnSendPublish.Name = "btnSendPublish";
            this.btnSendPublish.Size = new System.Drawing.Size(75, 23);
            this.btnSendPublish.TabIndex = 4;
            this.btnSendPublish.Text = "发布";
            this.btnSendPublish.UseVisualStyleBackColor = true;
            this.btnSendPublish.Click += new System.EventHandler(this.btnSendPublish_Click);
            // 
            // rtbSendPublish
            // 
            this.rtbSendPublish.Location = new System.Drawing.Point(10, 111);
            this.rtbSendPublish.Name = "rtbSendPublish";
            this.rtbSendPublish.Size = new System.Drawing.Size(245, 203);
            this.rtbSendPublish.TabIndex = 3;
            this.rtbSendPublish.Text = "";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(10, 83);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(53, 12);
            this.lblContent.TabIndex = 2;
            this.lblContent.Text = "发布内容";
            // 
            // lblPublishTopic
            // 
            this.lblPublishTopic.AutoSize = true;
            this.lblPublishTopic.Location = new System.Drawing.Point(10, 30);
            this.lblPublishTopic.Name = "lblPublishTopic";
            this.lblPublishTopic.Size = new System.Drawing.Size(65, 12);
            this.lblPublishTopic.TabIndex = 1;
            this.lblPublishTopic.Text = "发布主题：";
            // 
            // txtPublishTopic
            // 
            this.txtPublishTopic.Location = new System.Drawing.Point(10, 51);
            this.txtPublishTopic.Name = "txtPublishTopic";
            this.txtPublishTopic.Size = new System.Drawing.Size(245, 21);
            this.txtPublishTopic.TabIndex = 0;
            // 
            // grpRecive
            // 
            this.grpRecive.Controls.Add(this.rtbRecive);
            this.grpRecive.Controls.Add(this.pnlBot);
            this.grpRecive.Location = new System.Drawing.Point(574, 80);
            this.grpRecive.Name = "grpRecive";
            this.grpRecive.Size = new System.Drawing.Size(273, 358);
            this.grpRecive.TabIndex = 5;
            this.grpRecive.TabStop = false;
            this.grpRecive.Text = "内容接收";
            // 
            // rtbRecive
            // 
            this.rtbRecive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbRecive.Location = new System.Drawing.Point(3, 17);
            this.rtbRecive.Name = "rtbRecive";
            this.rtbRecive.Size = new System.Drawing.Size(267, 292);
            this.rtbRecive.TabIndex = 0;
            this.rtbRecive.Text = "";
            // 
            // lblClientId
            // 
            this.lblClientId.AutoSize = true;
            this.lblClientId.Location = new System.Drawing.Point(34, 49);
            this.lblClientId.Name = "lblClientId";
            this.lblClientId.Size = new System.Drawing.Size(65, 12);
            this.lblClientId.TabIndex = 6;
            this.lblClientId.Text = "客户端ID：";
            // 
            // txtClientId
            // 
            this.txtClientId.Location = new System.Drawing.Point(110, 45);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(239, 21);
            this.txtClientId.TabIndex = 7;
            // 
            // pnlBot
            // 
            this.pnlBot.Controls.Add(this.btnClear);
            this.pnlBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBot.Location = new System.Drawing.Point(3, 309);
            this.pnlBot.Name = "pnlBot";
            this.pnlBot.Size = new System.Drawing.Size(267, 46);
            this.pnlBot.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(8, 7);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(855, 74);
            this.pnlTop.TabIndex = 8;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(855, 450);
            this.Controls.Add(this.txtClientId);
            this.Controls.Add(this.lblClientId);
            this.Controls.Add(this.grpRecive);
            this.Controls.Add(this.grpPublish);
            this.Controls.Add(this.grpSubscribe);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.pnlTop);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MQTT客户端";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.grpSubscribe.ResumeLayout(false);
            this.grpSubscribe.PerformLayout();
            this.grpPublish.ResumeLayout(false);
            this.grpPublish.PerformLayout();
            this.grpRecive.ResumeLayout(false);
            this.pnlBot.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.GroupBox grpSubscribe;
        private System.Windows.Forms.ListBox lstSubscribeTopic;
        private System.Windows.Forms.Button btnAddSubscribe;
        private System.Windows.Forms.TextBox txtSubscribe;
        private System.Windows.Forms.Label lblSubscribeTopic;
        private System.Windows.Forms.GroupBox grpPublish;
        private System.Windows.Forms.Button btnSendPublish;
        private System.Windows.Forms.RichTextBox rtbSendPublish;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Label lblPublishTopic;
        private System.Windows.Forms.TextBox txtPublishTopic;
        private System.Windows.Forms.GroupBox grpRecive;
        private System.Windows.Forms.RichTextBox rtbRecive;
        private System.Windows.Forms.Label lblClientId;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.Panel pnlBot;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlTop;
    }
}

