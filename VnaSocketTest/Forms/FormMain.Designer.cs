namespace VnaSocketTest
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxServer = new System.Windows.Forms.GroupBox();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.labelIP = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelText = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelSpacer = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxCommand = new System.Windows.Forms.GroupBox();
            this.buttonCmdRst = new System.Windows.Forms.Button();
            this.buttonCmdOpc = new System.Windows.Forms.Button();
            this.buttonCmdCls = new System.Windows.Forms.Button();
            this.buttonCmdSystErr = new System.Windows.Forms.Button();
            this.buttonCmdIdn = new System.Windows.Forms.Button();
            this.textBoxCommand = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.groupBoxResponse = new System.Windows.Forms.GroupBox();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBoxServer.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.groupBoxCommand.SuspendLayout();
            this.groupBoxResponse.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxServer
            // 
            this.groupBoxServer.Controls.Add(this.buttonDisconnect);
            this.groupBoxServer.Controls.Add(this.buttonConnect);
            this.groupBoxServer.Controls.Add(this.textBoxPort);
            this.groupBoxServer.Controls.Add(this.labelIP);
            this.groupBoxServer.Controls.Add(this.textBoxIP);
            this.groupBoxServer.Controls.Add(this.labelPort);
            this.groupBoxServer.Location = new System.Drawing.Point(12, 12);
            this.groupBoxServer.Name = "groupBoxServer";
            this.groupBoxServer.Size = new System.Drawing.Size(460, 60);
            this.groupBoxServer.TabIndex = 8;
            this.groupBoxServer.TabStop = false;
            this.groupBoxServer.Text = "Server";
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisconnect.Location = new System.Drawing.Point(343, 17);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(110, 35);
            this.buttonDisconnect.TabIndex = 4;
            this.buttonDisconnect.Text = "&Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.Location = new System.Drawing.Point(225, 17);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(110, 35);
            this.buttonConnect.TabIndex = 3;
            this.buttonConnect.Text = "&Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // textBoxPort
            // 
            this.textBoxPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPort.Location = new System.Drawing.Point(113, 32);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(45, 20);
            this.textBoxPort.TabIndex = 2;
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Location = new System.Drawing.Point(4, 17);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(20, 13);
            this.labelIP.TabIndex = 0;
            this.labelIP.Text = "&IP:";
            this.labelIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxIP
            // 
            this.textBoxIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxIP.Location = new System.Drawing.Point(7, 32);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(100, 20);
            this.textBoxIP.TabIndex = 1;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(110, 17);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(29, 13);
            this.labelPort.TabIndex = 0;
            this.labelPort.Text = "&Port:";
            this.labelPort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabelText,
            this.toolStripStatusLabelSpacer,
            this.toolStripStatusLabelVersion});
            this.statusStrip.Location = new System.Drawing.Point(0, 540);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(484, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 9;
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Status:";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabelText
            // 
            this.toolStripStatusLabelText.Name = "toolStripStatusLabelText";
            this.toolStripStatusLabelText.Size = new System.Drawing.Size(22, 17);
            this.toolStripStatusLabelText.Text = "---";
            // 
            // toolStripStatusLabelSpacer
            // 
            this.toolStripStatusLabelSpacer.Name = "toolStripStatusLabelSpacer";
            this.toolStripStatusLabelSpacer.Size = new System.Drawing.Size(374, 17);
            this.toolStripStatusLabelSpacer.Spring = true;
            // 
            // toolStripStatusLabelVersion
            // 
            this.toolStripStatusLabelVersion.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelVersion.ForeColor = System.Drawing.SystemColors.GrayText;
            this.toolStripStatusLabelVersion.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
            this.toolStripStatusLabelVersion.Name = "toolStripStatusLabelVersion";
            this.toolStripStatusLabelVersion.Size = new System.Drawing.Size(26, 17);
            this.toolStripStatusLabelVersion.Text = "v ---";
            this.toolStripStatusLabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBoxCommand
            // 
            this.groupBoxCommand.Controls.Add(this.buttonCmdRst);
            this.groupBoxCommand.Controls.Add(this.buttonCmdOpc);
            this.groupBoxCommand.Controls.Add(this.buttonCmdCls);
            this.groupBoxCommand.Controls.Add(this.buttonCmdSystErr);
            this.groupBoxCommand.Controls.Add(this.buttonCmdIdn);
            this.groupBoxCommand.Controls.Add(this.textBoxCommand);
            this.groupBoxCommand.Controls.Add(this.buttonSend);
            this.groupBoxCommand.Location = new System.Drawing.Point(12, 78);
            this.groupBoxCommand.Name = "groupBoxCommand";
            this.groupBoxCommand.Size = new System.Drawing.Size(459, 75);
            this.groupBoxCommand.TabIndex = 10;
            this.groupBoxCommand.TabStop = false;
            this.groupBoxCommand.Text = "Command";
            // 
            // buttonCmdRst
            // 
            this.buttonCmdRst.Location = new System.Drawing.Point(225, 20);
            this.buttonCmdRst.Name = "buttonCmdRst";
            this.buttonCmdRst.Size = new System.Drawing.Size(68, 23);
            this.buttonCmdRst.TabIndex = 12;
            this.buttonCmdRst.Text = "*RST";
            this.buttonCmdRst.UseVisualStyleBackColor = true;
            this.buttonCmdRst.Click += new System.EventHandler(this.buttonCmdRst_Click);
            // 
            // buttonCmdOpc
            // 
            this.buttonCmdOpc.Location = new System.Drawing.Point(79, 20);
            this.buttonCmdOpc.Name = "buttonCmdOpc";
            this.buttonCmdOpc.Size = new System.Drawing.Size(68, 23);
            this.buttonCmdOpc.TabIndex = 11;
            this.buttonCmdOpc.Text = "*OPC?";
            this.buttonCmdOpc.UseVisualStyleBackColor = true;
            this.buttonCmdOpc.Click += new System.EventHandler(this.buttonCmdOpc_Click);
            // 
            // buttonCmdCls
            // 
            this.buttonCmdCls.Location = new System.Drawing.Point(152, 20);
            this.buttonCmdCls.Name = "buttonCmdCls";
            this.buttonCmdCls.Size = new System.Drawing.Size(68, 23);
            this.buttonCmdCls.TabIndex = 10;
            this.buttonCmdCls.Text = "*CLS";
            this.buttonCmdCls.UseVisualStyleBackColor = true;
            this.buttonCmdCls.Click += new System.EventHandler(this.buttonCmdCls_Click);
            // 
            // buttonCmdSystErr
            // 
            this.buttonCmdSystErr.Location = new System.Drawing.Point(298, 20);
            this.buttonCmdSystErr.Name = "buttonCmdSystErr";
            this.buttonCmdSystErr.Size = new System.Drawing.Size(74, 23);
            this.buttonCmdSystErr.TabIndex = 9;
            this.buttonCmdSystErr.Text = "SYST:ERR?";
            this.buttonCmdSystErr.UseVisualStyleBackColor = true;
            this.buttonCmdSystErr.Click += new System.EventHandler(this.buttonCmdSystErr_Click);
            // 
            // buttonCmdIdn
            // 
            this.buttonCmdIdn.Location = new System.Drawing.Point(6, 20);
            this.buttonCmdIdn.Name = "buttonCmdIdn";
            this.buttonCmdIdn.Size = new System.Drawing.Size(68, 23);
            this.buttonCmdIdn.TabIndex = 0;
            this.buttonCmdIdn.Text = "*IDN?";
            this.buttonCmdIdn.UseVisualStyleBackColor = true;
            this.buttonCmdIdn.Click += new System.EventHandler(this.buttonCmdIdn_Click);
            // 
            // textBoxCommand
            // 
            this.textBoxCommand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCommand.Location = new System.Drawing.Point(7, 47);
            this.textBoxCommand.Name = "textBoxCommand";
            this.textBoxCommand.Size = new System.Drawing.Size(365, 20);
            this.textBoxCommand.TabIndex = 7;
            this.textBoxCommand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCommand_KeyPress);
            // 
            // buttonSend
            // 
            this.buttonSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSend.Location = new System.Drawing.Point(378, 20);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 49);
            this.buttonSend.TabIndex = 8;
            this.buttonSend.Text = "&Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // groupBoxResponse
            // 
            this.groupBoxResponse.Controls.Add(this.textBoxLog);
            this.groupBoxResponse.Controls.Add(this.buttonClear);
            this.groupBoxResponse.Location = new System.Drawing.Point(13, 159);
            this.groupBoxResponse.Name = "groupBoxResponse";
            this.groupBoxResponse.Size = new System.Drawing.Size(459, 373);
            this.groupBoxResponse.TabIndex = 11;
            this.groupBoxResponse.TabStop = false;
            this.groupBoxResponse.Text = "Response";
            // 
            // textBoxLog
            // 
            this.textBoxLog.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLog.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxLog.Location = new System.Drawing.Point(7, 19);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(446, 319);
            this.textBoxLog.TabIndex = 0;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(353, 344);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(100, 23);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "Clea&r";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 562);
            this.Controls.Add(this.groupBoxResponse);
            this.Controls.Add(this.groupBoxCommand);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBoxServer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "< application title goes here >";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormVnaSocketTest_FormClosing);
            this.groupBoxServer.ResumeLayout(false);
            this.groupBoxServer.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupBoxCommand.ResumeLayout(false);
            this.groupBoxCommand.PerformLayout();
            this.groupBoxResponse.ResumeLayout(false);
            this.groupBoxResponse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxServer;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelText;
        private System.Windows.Forms.GroupBox groupBoxCommand;
        private System.Windows.Forms.TextBox textBoxCommand;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.GroupBox groupBoxResponse;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonCmdSystErr;
        private System.Windows.Forms.Button buttonCmdIdn;
        private System.Windows.Forms.Button buttonCmdRst;
        private System.Windows.Forms.Button buttonCmdOpc;
        private System.Windows.Forms.Button buttonCmdCls;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSpacer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelVersion;
    }
}

