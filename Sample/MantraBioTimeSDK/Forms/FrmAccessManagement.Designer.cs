namespace MantraBioTimeSDK
{
    partial class FrmAccessManagement
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
            this.pnlAccessManagement = new System.Windows.Forms.Panel();
            this.tabAccess = new System.Windows.Forms.TabControl();
            this.tabAccessTimeZone = new System.Windows.Forms.TabPage();
            this.grpACTimeZone = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSetTZone = new System.Windows.Forms.Button();
            this.btnGetTZone = new System.Windows.Forms.Button();
            this.txtTZoneID = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dtTOMON = new System.Windows.Forms.DateTimePicker();
            this.dtTOTUE = new System.Windows.Forms.DateTimePicker();
            this.dtTOWEN = new System.Windows.Forms.DateTimePicker();
            this.dtTOTHU = new System.Windows.Forms.DateTimePicker();
            this.dtTOSTA = new System.Windows.Forms.DateTimePicker();
            this.dtTOFRI = new System.Windows.Forms.DateTimePicker();
            this.dtTOSUN = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtMON = new System.Windows.Forms.DateTimePicker();
            this.dtTUE = new System.Windows.Forms.DateTimePicker();
            this.dtWEN = new System.Windows.Forms.DateTimePicker();
            this.dtTHU = new System.Windows.Forms.DateTimePicker();
            this.dtSTA = new System.Windows.Forms.DateTimePicker();
            this.dtFRI = new System.Windows.Forms.DateTimePicker();
            this.dtSUN = new System.Windows.Forms.DateTimePicker();
            this.lblACTZindex = new System.Windows.Forms.Label();
            this.lblACTimeZone = new System.Windows.Forms.Label();
            this.tabUserAccess = new System.Windows.Forms.TabPage();
            this.grpUAUserTimeZone = new System.Windows.Forms.GroupBox();
            this.txtUATZoneID = new System.Windows.Forms.TextBox();
            this.txtUATZIdx2 = new System.Windows.Forms.TextBox();
            this.txtUATZIdx3 = new System.Windows.Forms.TextBox();
            this.txtUATZIdx1 = new System.Windows.Forms.TextBox();
            this.lblUATUserID = new System.Windows.Forms.Label();
            this.btnGetUATZone = new System.Windows.Forms.Button();
            this.btnSetUATZone = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlAccessManagement.SuspendLayout();
            this.tabAccess.SuspendLayout();
            this.tabAccessTimeZone.SuspendLayout();
            this.grpACTimeZone.SuspendLayout();
            this.tabUserAccess.SuspendLayout();
            this.grpUAUserTimeZone.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAccessManagement
            // 
            this.pnlAccessManagement.Controls.Add(this.tabAccess);
            this.pnlAccessManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAccessManagement.Location = new System.Drawing.Point(0, 0);
            this.pnlAccessManagement.Name = "pnlAccessManagement";
            this.pnlAccessManagement.Size = new System.Drawing.Size(930, 460);
            this.pnlAccessManagement.TabIndex = 0;
            // 
            // tabAccess
            // 
            this.tabAccess.Controls.Add(this.tabAccessTimeZone);
            this.tabAccess.Controls.Add(this.tabUserAccess);
            this.tabAccess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAccess.Location = new System.Drawing.Point(0, 0);
            this.tabAccess.Name = "tabAccess";
            this.tabAccess.SelectedIndex = 0;
            this.tabAccess.Size = new System.Drawing.Size(930, 460);
            this.tabAccess.TabIndex = 10;
            // 
            // tabAccessTimeZone
            // 
            this.tabAccessTimeZone.Controls.Add(this.grpACTimeZone);
            this.tabAccessTimeZone.Location = new System.Drawing.Point(4, 22);
            this.tabAccessTimeZone.Name = "tabAccessTimeZone";
            this.tabAccessTimeZone.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccessTimeZone.Size = new System.Drawing.Size(922, 434);
            this.tabAccessTimeZone.TabIndex = 0;
            this.tabAccessTimeZone.Text = "Access TimeZone";
            this.tabAccessTimeZone.UseVisualStyleBackColor = true;
            // 
            // grpACTimeZone
            // 
            this.grpACTimeZone.Controls.Add(this.label9);
            this.grpACTimeZone.Controls.Add(this.btnSetTZone);
            this.grpACTimeZone.Controls.Add(this.btnGetTZone);
            this.grpACTimeZone.Controls.Add(this.txtTZoneID);
            this.grpACTimeZone.Controls.Add(this.label23);
            this.grpACTimeZone.Controls.Add(this.label22);
            this.grpACTimeZone.Controls.Add(this.label21);
            this.grpACTimeZone.Controls.Add(this.label20);
            this.grpACTimeZone.Controls.Add(this.label19);
            this.grpACTimeZone.Controls.Add(this.label18);
            this.grpACTimeZone.Controls.Add(this.label16);
            this.grpACTimeZone.Controls.Add(this.dtTOMON);
            this.grpACTimeZone.Controls.Add(this.dtTOTUE);
            this.grpACTimeZone.Controls.Add(this.dtTOWEN);
            this.grpACTimeZone.Controls.Add(this.dtTOTHU);
            this.grpACTimeZone.Controls.Add(this.dtTOSTA);
            this.grpACTimeZone.Controls.Add(this.dtTOFRI);
            this.grpACTimeZone.Controls.Add(this.dtTOSUN);
            this.grpACTimeZone.Controls.Add(this.label15);
            this.grpACTimeZone.Controls.Add(this.label14);
            this.grpACTimeZone.Controls.Add(this.label12);
            this.grpACTimeZone.Controls.Add(this.label11);
            this.grpACTimeZone.Controls.Add(this.label10);
            this.grpACTimeZone.Controls.Add(this.label2);
            this.grpACTimeZone.Controls.Add(this.label1);
            this.grpACTimeZone.Controls.Add(this.dtMON);
            this.grpACTimeZone.Controls.Add(this.dtTUE);
            this.grpACTimeZone.Controls.Add(this.dtWEN);
            this.grpACTimeZone.Controls.Add(this.dtTHU);
            this.grpACTimeZone.Controls.Add(this.dtSTA);
            this.grpACTimeZone.Controls.Add(this.dtFRI);
            this.grpACTimeZone.Controls.Add(this.dtSUN);
            this.grpACTimeZone.Controls.Add(this.lblACTZindex);
            this.grpACTimeZone.Controls.Add(this.lblACTimeZone);
            this.grpACTimeZone.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpACTimeZone.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpACTimeZone.Location = new System.Drawing.Point(6, 6);
            this.grpACTimeZone.Name = "grpACTimeZone";
            this.grpACTimeZone.Size = new System.Drawing.Size(287, 323);
            this.grpACTimeZone.TabIndex = 10;
            this.grpACTimeZone.TabStop = false;
            this.grpACTimeZone.Text = "TimeZone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(136)))), ((int)(((byte)(14)))));
            this.label9.Location = new System.Drawing.Point(157, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 14);
            this.label9.TabIndex = 131;
            this.label9.Text = " [1 - 50]";
            // 
            // btnSetTZone
            // 
            this.btnSetTZone.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSetTZone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetTZone.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btnSetTZone.ForeColor = System.Drawing.Color.Transparent;
            this.btnSetTZone.Location = new System.Drawing.Point(169, 293);
            this.btnSetTZone.Name = "btnSetTZone";
            this.btnSetTZone.Size = new System.Drawing.Size(102, 25);
            this.btnSetTZone.TabIndex = 26;
            this.btnSetTZone.Text = "Set TZone";
            this.btnSetTZone.UseVisualStyleBackColor = false;
            this.btnSetTZone.Click += new System.EventHandler(this.btnSetTZone_Click);
            // 
            // btnGetTZone
            // 
            this.btnGetTZone.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGetTZone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetTZone.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btnGetTZone.ForeColor = System.Drawing.Color.Transparent;
            this.btnGetTZone.Location = new System.Drawing.Point(50, 293);
            this.btnGetTZone.Name = "btnGetTZone";
            this.btnGetTZone.Size = new System.Drawing.Size(106, 25);
            this.btnGetTZone.TabIndex = 23;
            this.btnGetTZone.Text = "Get TZone";
            this.btnGetTZone.UseVisualStyleBackColor = false;
            this.btnGetTZone.Click += new System.EventHandler(this.btnGetTZone_Click);
            // 
            // txtTZoneID
            // 
            this.txtTZoneID.Location = new System.Drawing.Point(82, 21);
            this.txtTZoneID.Name = "txtTZoneID";
            this.txtTZoneID.Size = new System.Drawing.Size(72, 22);
            this.txtTZoneID.TabIndex = 130;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label23.Location = new System.Drawing.Point(167, 106);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(24, 14);
            this.label23.TabIndex = 129;
            this.label23.Text = "TO";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label22.Location = new System.Drawing.Point(167, 263);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(24, 14);
            this.label22.TabIndex = 128;
            this.label22.Text = "TO";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label21.Location = new System.Drawing.Point(167, 232);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(24, 14);
            this.label21.TabIndex = 127;
            this.label21.Text = "TO";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label20.Location = new System.Drawing.Point(167, 201);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(24, 14);
            this.label20.TabIndex = 126;
            this.label20.Text = "TO";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label19.Location = new System.Drawing.Point(167, 169);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(24, 14);
            this.label19.TabIndex = 125;
            this.label19.Text = "TO";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label18.Location = new System.Drawing.Point(167, 138);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(24, 14);
            this.label18.TabIndex = 124;
            this.label18.Text = "TO";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label16.Location = new System.Drawing.Point(167, 75);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 14);
            this.label16.TabIndex = 123;
            this.label16.Text = "TO";
            // 
            // dtTOMON
            // 
            this.dtTOMON.CustomFormat = "HH:mm";
            this.dtTOMON.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTOMON.Location = new System.Drawing.Point(200, 103);
            this.dtTOMON.Name = "dtTOMON";
            this.dtTOMON.ShowUpDown = true;
            this.dtTOMON.Size = new System.Drawing.Size(71, 22);
            this.dtTOMON.TabIndex = 122;
            // 
            // dtTOTUE
            // 
            this.dtTOTUE.CustomFormat = "HH:mm";
            this.dtTOTUE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTOTUE.Location = new System.Drawing.Point(200, 135);
            this.dtTOTUE.Name = "dtTOTUE";
            this.dtTOTUE.ShowUpDown = true;
            this.dtTOTUE.Size = new System.Drawing.Size(71, 22);
            this.dtTOTUE.TabIndex = 121;
            // 
            // dtTOWEN
            // 
            this.dtTOWEN.CustomFormat = "HH:mm";
            this.dtTOWEN.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTOWEN.Location = new System.Drawing.Point(200, 166);
            this.dtTOWEN.Name = "dtTOWEN";
            this.dtTOWEN.ShowUpDown = true;
            this.dtTOWEN.Size = new System.Drawing.Size(71, 22);
            this.dtTOWEN.TabIndex = 120;
            // 
            // dtTOTHU
            // 
            this.dtTOTHU.CustomFormat = "HH:mm";
            this.dtTOTHU.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTOTHU.Location = new System.Drawing.Point(200, 198);
            this.dtTOTHU.Name = "dtTOTHU";
            this.dtTOTHU.ShowUpDown = true;
            this.dtTOTHU.Size = new System.Drawing.Size(71, 22);
            this.dtTOTHU.TabIndex = 119;
            // 
            // dtTOSTA
            // 
            this.dtTOSTA.CustomFormat = "HH:mm";
            this.dtTOSTA.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTOSTA.Location = new System.Drawing.Point(200, 260);
            this.dtTOSTA.Name = "dtTOSTA";
            this.dtTOSTA.ShowUpDown = true;
            this.dtTOSTA.Size = new System.Drawing.Size(71, 22);
            this.dtTOSTA.TabIndex = 118;
            // 
            // dtTOFRI
            // 
            this.dtTOFRI.CustomFormat = "HH:mm";
            this.dtTOFRI.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTOFRI.Location = new System.Drawing.Point(200, 229);
            this.dtTOFRI.Name = "dtTOFRI";
            this.dtTOFRI.ShowUpDown = true;
            this.dtTOFRI.Size = new System.Drawing.Size(71, 22);
            this.dtTOFRI.TabIndex = 117;
            // 
            // dtTOSUN
            // 
            this.dtTOSUN.CustomFormat = "HH:mm";
            this.dtTOSUN.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTOSUN.Location = new System.Drawing.Point(200, 72);
            this.dtTOSUN.Name = "dtTOSUN";
            this.dtTOSUN.ShowUpDown = true;
            this.dtTOSUN.Size = new System.Drawing.Size(71, 22);
            this.dtTOSUN.TabIndex = 116;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label15.Location = new System.Drawing.Point(46, 263);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 14);
            this.label15.TabIndex = 115;
            this.label15.Text = "SAT:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label14.Location = new System.Drawing.Point(47, 232);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 14);
            this.label14.TabIndex = 114;
            this.label14.Text = "FRI:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label12.Location = new System.Drawing.Point(42, 201);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 14);
            this.label12.TabIndex = 113;
            this.label12.Text = "THU:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label11.Location = new System.Drawing.Point(37, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 14);
            this.label11.TabIndex = 112;
            this.label11.Text = "WEN:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(43, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 14);
            this.label10.TabIndex = 111;
            this.label10.Text = "TUE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(38, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 14);
            this.label2.TabIndex = 110;
            this.label2.Text = "MON:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(41, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 14);
            this.label1.TabIndex = 109;
            this.label1.Text = "SUN:";
            // 
            // dtMON
            // 
            this.dtMON.CustomFormat = "HH:mm";
            this.dtMON.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtMON.Location = new System.Drawing.Point(82, 103);
            this.dtMON.Name = "dtMON";
            this.dtMON.ShowUpDown = true;
            this.dtMON.Size = new System.Drawing.Size(71, 22);
            this.dtMON.TabIndex = 108;
            // 
            // dtTUE
            // 
            this.dtTUE.CustomFormat = "HH:mm";
            this.dtTUE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTUE.Location = new System.Drawing.Point(82, 135);
            this.dtTUE.Name = "dtTUE";
            this.dtTUE.ShowUpDown = true;
            this.dtTUE.Size = new System.Drawing.Size(71, 22);
            this.dtTUE.TabIndex = 107;
            // 
            // dtWEN
            // 
            this.dtWEN.CustomFormat = "HH:mm";
            this.dtWEN.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtWEN.Location = new System.Drawing.Point(82, 166);
            this.dtWEN.Name = "dtWEN";
            this.dtWEN.ShowUpDown = true;
            this.dtWEN.Size = new System.Drawing.Size(71, 22);
            this.dtWEN.TabIndex = 106;
            // 
            // dtTHU
            // 
            this.dtTHU.CustomFormat = "HH:mm";
            this.dtTHU.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTHU.Location = new System.Drawing.Point(82, 198);
            this.dtTHU.Name = "dtTHU";
            this.dtTHU.ShowUpDown = true;
            this.dtTHU.Size = new System.Drawing.Size(71, 22);
            this.dtTHU.TabIndex = 105;
            // 
            // dtSTA
            // 
            this.dtSTA.CustomFormat = "HH:mm";
            this.dtSTA.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSTA.Location = new System.Drawing.Point(82, 260);
            this.dtSTA.Name = "dtSTA";
            this.dtSTA.ShowUpDown = true;
            this.dtSTA.Size = new System.Drawing.Size(71, 22);
            this.dtSTA.TabIndex = 104;
            // 
            // dtFRI
            // 
            this.dtFRI.CustomFormat = "HH:mm";
            this.dtFRI.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFRI.Location = new System.Drawing.Point(82, 229);
            this.dtFRI.Name = "dtFRI";
            this.dtFRI.ShowUpDown = true;
            this.dtFRI.Size = new System.Drawing.Size(71, 22);
            this.dtFRI.TabIndex = 103;
            // 
            // dtSUN
            // 
            this.dtSUN.CustomFormat = "HH:mm";
            this.dtSUN.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSUN.Location = new System.Drawing.Point(82, 72);
            this.dtSUN.Name = "dtSUN";
            this.dtSUN.ShowUpDown = true;
            this.dtSUN.Size = new System.Drawing.Size(71, 22);
            this.dtSUN.TabIndex = 102;
            // 
            // lblACTZindex
            // 
            this.lblACTZindex.AutoSize = true;
            this.lblACTZindex.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblACTZindex.Location = new System.Drawing.Point(21, 24);
            this.lblACTZindex.Name = "lblACTZindex";
            this.lblACTZindex.Size = new System.Drawing.Size(58, 14);
            this.lblACTZindex.TabIndex = 24;
            this.lblACTZindex.Text = "TZIndex";
            // 
            // lblACTimeZone
            // 
            this.lblACTimeZone.AutoSize = true;
            this.lblACTimeZone.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACTimeZone.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblACTimeZone.Location = new System.Drawing.Point(8, 55);
            this.lblACTimeZone.Name = "lblACTimeZone";
            this.lblACTimeZone.Size = new System.Drawing.Size(71, 14);
            this.lblACTimeZone.TabIndex = 27;
            this.lblACTimeZone.Text = "TimeZone";
            // 
            // tabUserAccess
            // 
            this.tabUserAccess.Controls.Add(this.grpUAUserTimeZone);
            this.tabUserAccess.Location = new System.Drawing.Point(4, 22);
            this.tabUserAccess.Name = "tabUserAccess";
            this.tabUserAccess.Padding = new System.Windows.Forms.Padding(3);
            this.tabUserAccess.Size = new System.Drawing.Size(922, 434);
            this.tabUserAccess.TabIndex = 1;
            this.tabUserAccess.Text = "User Access";
            this.tabUserAccess.UseVisualStyleBackColor = true;
            // 
            // grpUAUserTimeZone
            // 
            this.grpUAUserTimeZone.Controls.Add(this.label8);
            this.grpUAUserTimeZone.Controls.Add(this.label7);
            this.grpUAUserTimeZone.Controls.Add(this.label6);
            this.grpUAUserTimeZone.Controls.Add(this.label5);
            this.grpUAUserTimeZone.Controls.Add(this.label4);
            this.grpUAUserTimeZone.Controls.Add(this.label3);
            this.grpUAUserTimeZone.Controls.Add(this.btnSetUATZone);
            this.grpUAUserTimeZone.Controls.Add(this.btnGetUATZone);
            this.grpUAUserTimeZone.Controls.Add(this.txtUATZoneID);
            this.grpUAUserTimeZone.Controls.Add(this.txtUATZIdx2);
            this.grpUAUserTimeZone.Controls.Add(this.txtUATZIdx3);
            this.grpUAUserTimeZone.Controls.Add(this.txtUATZIdx1);
            this.grpUAUserTimeZone.Controls.Add(this.lblUATUserID);
            this.grpUAUserTimeZone.Font = new System.Drawing.Font("Verdana", 9F);
            this.grpUAUserTimeZone.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpUAUserTimeZone.Location = new System.Drawing.Point(6, 6);
            this.grpUAUserTimeZone.Name = "grpUAUserTimeZone";
            this.grpUAUserTimeZone.Size = new System.Drawing.Size(225, 212);
            this.grpUAUserTimeZone.TabIndex = 4;
            this.grpUAUserTimeZone.TabStop = false;
            this.grpUAUserTimeZone.Text = "User TimeZone";
            // 
            // txtUATZoneID
            // 
            this.txtUATZoneID.Location = new System.Drawing.Point(78, 35);
            this.txtUATZoneID.Name = "txtUATZoneID";
            this.txtUATZoneID.Size = new System.Drawing.Size(135, 22);
            this.txtUATZoneID.TabIndex = 131;
            // 
            // txtUATZIdx2
            // 
            this.txtUATZIdx2.Location = new System.Drawing.Point(78, 91);
            this.txtUATZIdx2.MaxLength = 2;
            this.txtUATZIdx2.Name = "txtUATZIdx2";
            this.txtUATZIdx2.Size = new System.Drawing.Size(32, 22);
            this.txtUATZIdx2.TabIndex = 79;
            // 
            // txtUATZIdx3
            // 
            this.txtUATZIdx3.Location = new System.Drawing.Point(78, 119);
            this.txtUATZIdx3.MaxLength = 2;
            this.txtUATZIdx3.Name = "txtUATZIdx3";
            this.txtUATZIdx3.Size = new System.Drawing.Size(32, 22);
            this.txtUATZIdx3.TabIndex = 78;
            // 
            // txtUATZIdx1
            // 
            this.txtUATZIdx1.Location = new System.Drawing.Point(78, 63);
            this.txtUATZIdx1.MaxLength = 2;
            this.txtUATZIdx1.Name = "txtUATZIdx1";
            this.txtUATZIdx1.Size = new System.Drawing.Size(32, 22);
            this.txtUATZIdx1.TabIndex = 77;
            // 
            // lblUATUserID
            // 
            this.lblUATUserID.AutoSize = true;
            this.lblUATUserID.Location = new System.Drawing.Point(24, 38);
            this.lblUATUserID.Name = "lblUATUserID";
            this.lblUATUserID.Size = new System.Drawing.Size(50, 14);
            this.lblUATUserID.TabIndex = 71;
            this.lblUATUserID.Text = "UserID";
            // 
            // btnGetUATZone
            // 
            this.btnGetUATZone.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGetUATZone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetUATZone.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btnGetUATZone.ForeColor = System.Drawing.Color.Transparent;
            this.btnGetUATZone.Location = new System.Drawing.Point(44, 147);
            this.btnGetUATZone.Name = "btnGetUATZone";
            this.btnGetUATZone.Size = new System.Drawing.Size(169, 25);
            this.btnGetUATZone.TabIndex = 134;
            this.btnGetUATZone.Text = "Get User Access TZone";
            this.btnGetUATZone.UseVisualStyleBackColor = false;
            this.btnGetUATZone.Click += new System.EventHandler(this.btnGetUATZone_Click);
            // 
            // btnSetUATZone
            // 
            this.btnSetUATZone.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSetUATZone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetUATZone.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btnSetUATZone.ForeColor = System.Drawing.Color.Transparent;
            this.btnSetUATZone.Location = new System.Drawing.Point(44, 178);
            this.btnSetUATZone.Name = "btnSetUATZone";
            this.btnSetUATZone.Size = new System.Drawing.Size(169, 25);
            this.btnSetUATZone.TabIndex = 135;
            this.btnSetUATZone.Text = "Set User Access TZone";
            this.btnSetUATZone.UseVisualStyleBackColor = false;
            this.btnSetUATZone.Click += new System.EventHandler(this.btnSetUATZone_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 14);
            this.label3.TabIndex = 136;
            this.label3.Text = "TZ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 14);
            this.label4.TabIndex = 137;
            this.label4.Text = "TZ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 14);
            this.label5.TabIndex = 138;
            this.label5.Text = "TZ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(136)))), ((int)(((byte)(14)))));
            this.label6.Location = new System.Drawing.Point(113, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 14);
            this.label6.TabIndex = 139;
            this.label6.Text = " [1 - 50]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(136)))), ((int)(((byte)(14)))));
            this.label7.Location = new System.Drawing.Point(113, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 14);
            this.label7.TabIndex = 140;
            this.label7.Text = " [1 - 50]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(136)))), ((int)(((byte)(14)))));
            this.label8.Location = new System.Drawing.Point(113, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 14);
            this.label8.TabIndex = 141;
            this.label8.Text = " [1 - 50]";
            // 
            // FrmAccessManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(930, 460);
            this.Controls.Add(this.pnlAccessManagement);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAccessManagement";
            this.Text = "FrmAccessManagement";
            this.pnlAccessManagement.ResumeLayout(false);
            this.tabAccess.ResumeLayout(false);
            this.tabAccessTimeZone.ResumeLayout(false);
            this.grpACTimeZone.ResumeLayout(false);
            this.grpACTimeZone.PerformLayout();
            this.tabUserAccess.ResumeLayout(false);
            this.grpUAUserTimeZone.ResumeLayout(false);
            this.grpUAUserTimeZone.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAccessManagement;
        private System.Windows.Forms.TabControl tabAccess;
        private System.Windows.Forms.TabPage tabAccessTimeZone;
        private System.Windows.Forms.GroupBox grpACTimeZone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTZoneID;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtTOMON;
        private System.Windows.Forms.DateTimePicker dtTOTUE;
        private System.Windows.Forms.DateTimePicker dtTOWEN;
        private System.Windows.Forms.DateTimePicker dtTOTHU;
        private System.Windows.Forms.DateTimePicker dtTOSTA;
        private System.Windows.Forms.DateTimePicker dtTOFRI;
        private System.Windows.Forms.DateTimePicker dtTOSUN;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtMON;
        private System.Windows.Forms.DateTimePicker dtTUE;
        private System.Windows.Forms.DateTimePicker dtWEN;
        private System.Windows.Forms.DateTimePicker dtTHU;
        private System.Windows.Forms.DateTimePicker dtSTA;
        private System.Windows.Forms.DateTimePicker dtFRI;
        private System.Windows.Forms.DateTimePicker dtSUN;
        private System.Windows.Forms.Label lblACTZindex;
        private System.Windows.Forms.Button btnGetTZone;
        private System.Windows.Forms.Label lblACTimeZone;
        private System.Windows.Forms.Button btnSetTZone;
        private System.Windows.Forms.TabPage tabUserAccess;
        private System.Windows.Forms.GroupBox grpUAUserTimeZone;
        private System.Windows.Forms.TextBox txtUATZIdx2;
        private System.Windows.Forms.TextBox txtUATZIdx3;
        private System.Windows.Forms.TextBox txtUATZIdx1;
        private System.Windows.Forms.Label lblUATUserID;
        private System.Windows.Forms.TextBox txtUATZoneID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSetUATZone;
        private System.Windows.Forms.Button btnGetUATZone;
    }
}