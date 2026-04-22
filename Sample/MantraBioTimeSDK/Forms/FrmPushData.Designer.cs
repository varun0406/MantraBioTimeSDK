namespace MantraBioTimeSDK
{
    partial class FrmPushData
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
            this.pnlPushDataScreen = new System.Windows.Forms.Panel();
            this.lvAttLog = new System.Windows.Forms.ListView();
            this.ch_al_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_al_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_al_3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_al_4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_al_5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_al_6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_al_7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GrpLister = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.pnlPushDataScreen.SuspendLayout();
            this.GrpLister.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPushDataScreen
            // 
            this.pnlPushDataScreen.Controls.Add(this.lvAttLog);
            this.pnlPushDataScreen.Controls.Add(this.GrpLister);
            this.pnlPushDataScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPushDataScreen.Font = new System.Drawing.Font("Verdana", 9F);
            this.pnlPushDataScreen.Location = new System.Drawing.Point(0, 0);
            this.pnlPushDataScreen.Name = "pnlPushDataScreen";
            this.pnlPushDataScreen.Size = new System.Drawing.Size(930, 460);
            this.pnlPushDataScreen.TabIndex = 0;
            // 
            // lvAttLog
            // 
            this.lvAttLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_al_1,
            this.ch_al_2,
            this.ch_al_3,
            this.ch_al_4,
            this.ch_al_5,
            this.ch_al_6,
            this.ch_al_7});
            this.lvAttLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvAttLog.FullRowSelect = true;
            this.lvAttLog.Location = new System.Drawing.Point(0, 80);
            this.lvAttLog.Name = "lvAttLog";
            this.lvAttLog.Size = new System.Drawing.Size(930, 380);
            this.lvAttLog.TabIndex = 2;
            this.lvAttLog.UseCompatibleStateImageBehavior = false;
            this.lvAttLog.View = System.Windows.Forms.View.Details;
            // 
            // ch_al_1
            // 
            this.ch_al_1.Text = "MachineNo";
            this.ch_al_1.Width = 80;
            // 
            // ch_al_2
            // 
            this.ch_al_2.Text = "DeviceType";
            this.ch_al_2.Width = 100;
            // 
            // ch_al_3
            // 
            this.ch_al_3.Text = "User Id";
            this.ch_al_3.Width = 80;
            // 
            // ch_al_4
            // 
            this.ch_al_4.Text = "VerifyType";
            this.ch_al_4.Width = 80;
            // 
            // ch_al_5
            // 
            this.ch_al_5.Text = "VerifyMode";
            this.ch_al_5.Width = 80;
            // 
            // ch_al_6
            // 
            this.ch_al_6.Text = "VDateTime";
            this.ch_al_6.Width = 120;
            // 
            // ch_al_7
            // 
            this.ch_al_7.Text = "SerialNo";
            this.ch_al_7.Width = 140;
            // 
            // GrpLister
            // 
            this.GrpLister.Controls.Add(this.btnClear);
            this.GrpLister.Controls.Add(this.btnStart);
            this.GrpLister.Controls.Add(this.txtIP);
            this.GrpLister.Controls.Add(this.txtPort);
            this.GrpLister.Dock = System.Windows.Forms.DockStyle.Top;
            this.GrpLister.Location = new System.Drawing.Point(0, 0);
            this.GrpLister.Name = "GrpLister";
            this.GrpLister.Size = new System.Drawing.Size(930, 80);
            this.GrpLister.TabIndex = 1;
            this.GrpLister.TabStop = false;
            this.GrpLister.Text = "TCP Listner";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(530, 49);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(53, 25);
            this.btnClear.TabIndex = 106;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.SteelBlue;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(407, 50);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(117, 25);
            this.btnStart.TabIndex = 105;
            this.btnStart.Text = "Start listenning";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(407, 21);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(117, 22);
            this.txtIP.TabIndex = 1;
            this.txtIP.Text = "192.168.1.1";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(530, 21);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(53, 22);
            this.txtPort.TabIndex = 2;
            this.txtPort.Text = "5005";
            // 
            // FrmPushData
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(930, 460);
            this.Controls.Add(this.pnlPushDataScreen);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPushData";
            this.Text = "FrmPushData";
            this.pnlPushDataScreen.ResumeLayout(false);
            this.GrpLister.ResumeLayout(false);
            this.GrpLister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPushDataScreen;
        private System.Windows.Forms.GroupBox GrpLister;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListView lvAttLog;
        private System.Windows.Forms.ColumnHeader ch_al_1;
        private System.Windows.Forms.ColumnHeader ch_al_2;
        private System.Windows.Forms.ColumnHeader ch_al_3;
        private System.Windows.Forms.ColumnHeader ch_al_4;
        private System.Windows.Forms.ColumnHeader ch_al_5;
        private System.Windows.Forms.ColumnHeader ch_al_6;
        private System.Windows.Forms.ColumnHeader ch_al_7;
        private System.Windows.Forms.Button btnClear;
    }
}