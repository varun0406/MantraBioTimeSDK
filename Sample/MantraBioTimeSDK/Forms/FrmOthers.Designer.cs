namespace MantraBioTimeSDK
{
    partial class FrmOthers
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
            this.pnlOtherUtilities = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSetThisDeviceTime = new System.Windows.Forms.Button();
            this.btnSetDeviceTime = new System.Windows.Forms.Button();
            this.btnGetDeviceTime = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtDeviceTime = new System.Windows.Forms.DateTimePicker();
            this.lbDeviceTime = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label33 = new System.Windows.Forms.Label();
            this.btnRestartDevice = new System.Windows.Forms.Button();
            this.btnPowerOffDevice = new System.Windows.Forms.Button();
            this.pnlOtherUtilities.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOtherUtilities
            // 
            this.pnlOtherUtilities.Controls.Add(this.groupBox4);
            this.pnlOtherUtilities.Controls.Add(this.groupBox1);
            this.pnlOtherUtilities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOtherUtilities.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlOtherUtilities.Location = new System.Drawing.Point(0, 0);
            this.pnlOtherUtilities.Name = "pnlOtherUtilities";
            this.pnlOtherUtilities.Size = new System.Drawing.Size(930, 460);
            this.pnlOtherUtilities.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSetThisDeviceTime);
            this.groupBox1.Controls.Add(this.btnSetDeviceTime);
            this.groupBox1.Controls.Add(this.btnGetDeviceTime);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtDeviceTime);
            this.groupBox1.Controls.Add(this.lbDeviceTime);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 122);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SYNC Time";
            // 
            // btnSetThisDeviceTime
            // 
            this.btnSetThisDeviceTime.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSetThisDeviceTime.FlatAppearance.BorderSize = 0;
            this.btnSetThisDeviceTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetThisDeviceTime.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetThisDeviceTime.Location = new System.Drawing.Point(17, 88);
            this.btnSetThisDeviceTime.Name = "btnSetThisDeviceTime";
            this.btnSetThisDeviceTime.Size = new System.Drawing.Size(162, 25);
            this.btnSetThisDeviceTime.TabIndex = 106;
            this.btnSetThisDeviceTime.Text = "SetThisDeviceTime";
            this.btnSetThisDeviceTime.UseVisualStyleBackColor = false;
            this.btnSetThisDeviceTime.Click += new System.EventHandler(this.btnSetThisDeviceTime_Click);
            // 
            // btnSetDeviceTime
            // 
            this.btnSetDeviceTime.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSetDeviceTime.FlatAppearance.BorderSize = 0;
            this.btnSetDeviceTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetDeviceTime.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetDeviceTime.Location = new System.Drawing.Point(17, 57);
            this.btnSetDeviceTime.Name = "btnSetDeviceTime";
            this.btnSetDeviceTime.Size = new System.Drawing.Size(117, 25);
            this.btnSetDeviceTime.TabIndex = 105;
            this.btnSetDeviceTime.Text = "SetDeviceTime";
            this.btnSetDeviceTime.UseVisualStyleBackColor = false;
            this.btnSetDeviceTime.Click += new System.EventHandler(this.btnSetDeviceTime_Click);
            // 
            // btnGetDeviceTime
            // 
            this.btnGetDeviceTime.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGetDeviceTime.FlatAppearance.BorderSize = 0;
            this.btnGetDeviceTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetDeviceTime.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetDeviceTime.Location = new System.Drawing.Point(17, 26);
            this.btnGetDeviceTime.Name = "btnGetDeviceTime";
            this.btnGetDeviceTime.Size = new System.Drawing.Size(117, 25);
            this.btnGetDeviceTime.TabIndex = 104;
            this.btnGetDeviceTime.Text = "GetDeviceTime";
            this.btnGetDeviceTime.UseVisualStyleBackColor = false;
            this.btnGetDeviceTime.Click += new System.EventHandler(this.btnGetDeviceTime_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(136)))), ((int)(((byte)(14)))));
            this.label1.Location = new System.Drawing.Point(138, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 14);
            this.label1.TabIndex = 103;
            this.label1.Text = "Your PC\'s time to device";
            // 
            // dtDeviceTime
            // 
            this.dtDeviceTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtDeviceTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDeviceTime.Location = new System.Drawing.Point(185, 90);
            this.dtDeviceTime.Name = "dtDeviceTime";
            this.dtDeviceTime.Size = new System.Drawing.Size(177, 22);
            this.dtDeviceTime.TabIndex = 102;
            // 
            // lbDeviceTime
            // 
            this.lbDeviceTime.AutoSize = true;
            this.lbDeviceTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(136)))), ((int)(((byte)(14)))));
            this.lbDeviceTime.Location = new System.Drawing.Point(138, 31);
            this.lbDeviceTime.Name = "lbDeviceTime";
            this.lbDeviceTime.Size = new System.Drawing.Size(224, 14);
            this.lbDeviceTime.TabIndex = 3;
            this.lbDeviceTime.Text = "show time(yyyy-MM-dd HH:mm:ss)";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnPowerOffDevice);
            this.groupBox4.Controls.Add(this.btnRestartDevice);
            this.groupBox4.Controls.Add(this.label33);
            this.groupBox4.Location = new System.Drawing.Point(3, 131);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(368, 79);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Control";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(136)))), ((int)(((byte)(14)))));
            this.label33.Location = new System.Drawing.Point(92, 18);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(203, 14);
            this.label33.TabIndex = 82;
            this.label33.Text = "Restart or Poweroff the device.";
            // 
            // btnRestartDevice
            // 
            this.btnRestartDevice.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRestartDevice.FlatAppearance.BorderSize = 0;
            this.btnRestartDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestartDevice.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestartDevice.Location = new System.Drawing.Point(55, 44);
            this.btnRestartDevice.Name = "btnRestartDevice";
            this.btnRestartDevice.Size = new System.Drawing.Size(124, 25);
            this.btnRestartDevice.TabIndex = 105;
            this.btnRestartDevice.Text = "RestartDevice";
            this.btnRestartDevice.UseVisualStyleBackColor = false;
            this.btnRestartDevice.Click += new System.EventHandler(this.btnRestartDevice_Click);
            // 
            // btnPowerOffDevice
            // 
            this.btnPowerOffDevice.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPowerOffDevice.FlatAppearance.BorderSize = 0;
            this.btnPowerOffDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPowerOffDevice.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPowerOffDevice.Location = new System.Drawing.Point(185, 44);
            this.btnPowerOffDevice.Name = "btnPowerOffDevice";
            this.btnPowerOffDevice.Size = new System.Drawing.Size(124, 25);
            this.btnPowerOffDevice.TabIndex = 106;
            this.btnPowerOffDevice.Text = "PowerOffDevice";
            this.btnPowerOffDevice.UseVisualStyleBackColor = false;
            this.btnPowerOffDevice.Click += new System.EventHandler(this.btnPowerOffDevice_Click);
            // 
            // FrmOthers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(930, 460);
            this.Controls.Add(this.pnlOtherUtilities);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOthers";
            this.Text = "FrmOthers";
            this.pnlOtherUtilities.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOtherUtilities;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtDeviceTime;
        private System.Windows.Forms.Label lbDeviceTime;
        private System.Windows.Forms.Button btnSetThisDeviceTime;
        private System.Windows.Forms.Button btnSetDeviceTime;
        private System.Windows.Forms.Button btnGetDeviceTime;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnPowerOffDevice;
        private System.Windows.Forms.Button btnRestartDevice;
        private System.Windows.Forms.Label label33;
    }
}