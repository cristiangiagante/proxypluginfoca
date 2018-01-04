namespace FocaPluginExample
{
    partial class FrmPluginExample
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.btnSendFoca = new System.Windows.Forms.Button();
            this.lblDomain = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.proxyEnabled = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.proxyEnabled);
            this.panel.Controls.Add(this.txtPort);
            this.panel.Controls.Add(this.lblPort);
            this.panel.Controls.Add(this.btnSendFoca);
            this.panel.Controls.Add(this.lblDomain);
            this.panel.Controls.Add(this.lblWelcome);
            this.panel.Controls.Add(this.txtIp);
            this.panel.Location = new System.Drawing.Point(8, 8);
            this.panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(463, 237);
            this.panel.TabIndex = 0;
            // 
            // btnSendFoca
            // 
            this.btnSendFoca.Location = new System.Drawing.Point(68, 152);
            this.btnSendFoca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSendFoca.Name = "btnSendFoca";
            this.btnSendFoca.Size = new System.Drawing.Size(81, 21);
            this.btnSendFoca.TabIndex = 3;
            this.btnSendFoca.Text = "Apply";
            this.btnSendFoca.UseVisualStyleBackColor = true;
            this.btnSendFoca.Click += new System.EventHandler(this.btnSendFoca_Click);
            // 
            // lblDomain
            // 
            this.lblDomain.AutoSize = true;
            this.lblDomain.Location = new System.Drawing.Point(65, 86);
            this.lblDomain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDomain.Name = "lblDomain";
            this.lblDomain.Size = new System.Drawing.Size(19, 13);
            this.lblDomain.TabIndex = 2;
            this.lblDomain.Text = "Ip:";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(65, 45);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(176, 13);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Proxy Configuration Plugin for FOCA";
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(112, 84);
            this.txtIp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(306, 20);
            this.txtIp.TabIndex = 0;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(65, 117);
            this.lblPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 13);
            this.lblPort.TabIndex = 4;
            this.lblPort.Text = "Port:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(112, 114);
            this.txtPort.Margin = new System.Windows.Forms.Padding(2);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(77, 20);
            this.txtPort.TabIndex = 5;
            // 
            // proxyEnabled
            // 
            this.proxyEnabled.AutoSize = true;
            this.proxyEnabled.Location = new System.Drawing.Point(209, 116);
            this.proxyEnabled.Name = "proxyEnabled";
            this.proxyEnabled.Size = new System.Drawing.Size(65, 17);
            this.proxyEnabled.TabIndex = 6;
            this.proxyEnabled.Text = "Enabled";
            this.proxyEnabled.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 201);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "2017 - Cristian Giagante [+] http://github.com/cristiangiagante/ProxyPluginFOCA";
            // 
            // FrmProxyPlugin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 252);
            this.Controls.Add(this.panel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmProxyPlugin";
            this.Text = "Foca plugin example";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lblDomain;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Button btnSendFoca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox proxyEnabled;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblPort;
    }
}

