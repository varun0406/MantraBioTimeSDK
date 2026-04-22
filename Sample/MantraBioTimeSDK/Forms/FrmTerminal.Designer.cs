namespace MantraBioTimeSDK
{
    partial class FrmTerminal
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
            this.pnlTerminal = new System.Windows.Forms.Panel();
            this.pnlMiddle = new System.Windows.Forms.Panel();
            this.tabDeviceInfo = new System.Windows.Forms.TabControl();
            this.tabDevInfo = new System.Windows.Forms.TabPage();
            this.btnDeleteDB = new System.Windows.Forms.Button();
            this.btnGetDevInfo = new System.Windows.Forms.Button();
            this.lblManufactureTime = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblSerialNo = new System.Windows.Forms.Label();
            this.lblFaceAlgo = new System.Windows.Forms.Label();
            this.lblMAC = new System.Windows.Forms.Label();
            this.txtFaceAlgo = new System.Windows.Forms.TextBox();
            this.txtMac = new System.Windows.Forms.TextBox();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.txtMfr = new System.Windows.Forms.TextBox();
            this.txtMfrTime = new System.Windows.Forms.TextBox();
            this.lblFirmVer = new System.Windows.Forms.Label();
            this.lblFP_Algorithm = new System.Windows.Forms.Label();
            this.lblPlatForm = new System.Windows.Forms.Label();
            this.lblDevName = new System.Windows.Forms.Label();
            this.txtPlatFrm = new System.Windows.Forms.TextBox();
            this.txtDevNm = new System.Windows.Forms.TextBox();
            this.txtFPAlg = new System.Windows.Forms.TextBox();
            this.txtFirmVer = new System.Windows.Forms.TextBox();
            this.tabDevCapacity = new System.Windows.Forms.TabPage();
            this.txtCardCnt = new System.Windows.Forms.TextBox();
            this.lblCardCnt = new System.Windows.Forms.Label();
            this.btnGetDevCapacity = new System.Windows.Forms.Button();
            this.lblFaceCnt = new System.Windows.Forms.Label();
            this.lblOplogCnt = new System.Windows.Forms.Label();
            this.lblFPCnt = new System.Windows.Forms.Label();
            this.lblAttLogCnt = new System.Windows.Forms.Label();
            this.lblPwdCnt = new System.Windows.Forms.Label();
            this.lblAdminCnt = new System.Windows.Forms.Label();
            this.lblUserCnt = new System.Windows.Forms.Label();
            this.txtFaceCnt = new System.Windows.Forms.TextBox();
            this.txtAdminCnt = new System.Windows.Forms.TextBox();
            this.txtUserCnt = new System.Windows.Forms.TextBox();
            this.txtPWDCnt = new System.Windows.Forms.TextBox();
            this.txtOpLogCnt = new System.Windows.Forms.TextBox();
            this.txtAttLogCnt = new System.Windows.Forms.TextBox();
            this.txtFPCnt = new System.Windows.Forms.TextBox();
            this.grpConnect = new System.Windows.Forms.GroupBox();
            this.tabConnect = new System.Windows.Forms.TabControl();
            this.tabTcpIP = new System.Windows.Forms.TabPage();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtDeviceCommKey = new System.Windows.Forms.TextBox();
            this.lblDeviceComm = new System.Windows.Forms.Label();
            this.txtDevicePort = new System.Windows.Forms.TextBox();
            this.lblDevicePort = new System.Windows.Forms.Label();
            this.txtDeviceIP = new System.Windows.Forms.TextBox();
            this.lblDeviceIP = new System.Windows.Forms.Label();
            this.txtDeviceId = new System.Windows.Forms.TextBox();
            this.lblDeviceId = new System.Windows.Forms.Label();
            this.tabRS = new System.Windows.Forms.TabPage();
            this.btn2Connect = new System.Windows.Forms.Button();
            this.lbl2DeviceComm = new System.Windows.Forms.Label();
            this.lbl2BaudRate = new System.Windows.Forms.Label();
            this.lbl2ComPort = new System.Windows.Forms.Label();
            this.txt2CommKey = new System.Windows.Forms.TextBox();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.cmbComPort = new System.Windows.Forms.ComboBox();
            this.txt2DeviceId = new System.Windows.Forms.TextBox();
            this.lbl2DeviceId = new System.Windows.Forms.Label();
            this.tabUSB = new System.Windows.Forms.TabPage();
            this.lbl3DeviceComm = new System.Windows.Forms.Label();
            this.txt3CommKey = new System.Windows.Forms.TextBox();
            this.rbUSBClient = new System.Windows.Forms.RadioButton();
            this.rbUSB = new System.Windows.Forms.RadioButton();
            this.txt3DeviceId = new System.Windows.Forms.TextBox();
            this.lbl3DeviceId = new System.Windows.Forms.Label();
            this.btn3Connect = new System.Windows.Forms.Button();
            this.pnlTerminal.SuspendLayout();
            this.pnlMiddle.SuspendLayout();
            this.tabDeviceInfo.SuspendLayout();
            this.tabDevInfo.SuspendLayout();
            this.tabDevCapacity.SuspendLayout();
            this.grpConnect.SuspendLayout();
            this.tabConnect.SuspendLayout();
            this.tabTcpIP.SuspendLayout();
            this.tabRS.SuspendLayout();
            this.tabUSB.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTerminal
            // 
            this.pnlTerminal.Controls.Add(this.pnlMiddle);
            this.pnlTerminal.Controls.Add(this.grpConnect);
            this.pnlTerminal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTerminal.Location = new System.Drawing.Point(0, 0);
            this.pnlTerminal.Name = "pnlTerminal";
            this.pnlTerminal.Size = new System.Drawing.Size(930, 460);
            this.pnlTerminal.TabIndex = 2;
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.Controls.Add(this.tabDeviceInfo);
            this.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMiddle.Location = new System.Drawing.Point(0, 112);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(930, 348);
            this.pnlMiddle.TabIndex = 7;
            // 
            // tabDeviceInfo
            // 
            this.tabDeviceInfo.Controls.Add(this.tabDevInfo);
            this.tabDeviceInfo.Controls.Add(this.tabDevCapacity);
            this.tabDeviceInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDeviceInfo.Location = new System.Drawing.Point(0, 0);
            this.tabDeviceInfo.Name = "tabDeviceInfo";
            this.tabDeviceInfo.SelectedIndex = 0;
            this.tabDeviceInfo.Size = new System.Drawing.Size(930, 348);
            this.tabDeviceInfo.TabIndex = 4;
            // 
            // tabDevInfo
            // 
            this.tabDevInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabDevInfo.Controls.Add(this.btnDeleteDB);
            this.tabDevInfo.Controls.Add(this.btnGetDevInfo);
            this.tabDevInfo.Controls.Add(this.lblManufactureTime);
            this.tabDevInfo.Controls.Add(this.lblManufacturer);
            this.tabDevInfo.Controls.Add(this.lblSerialNo);
            this.tabDevInfo.Controls.Add(this.lblFaceAlgo);
            this.tabDevInfo.Controls.Add(this.lblMAC);
            this.tabDevInfo.Controls.Add(this.txtFaceAlgo);
            this.tabDevInfo.Controls.Add(this.txtMac);
            this.tabDevInfo.Controls.Add(this.txtSerialNumber);
            this.tabDevInfo.Controls.Add(this.txtMfr);
            this.tabDevInfo.Controls.Add(this.txtMfrTime);
            this.tabDevInfo.Controls.Add(this.lblFirmVer);
            this.tabDevInfo.Controls.Add(this.lblFP_Algorithm);
            this.tabDevInfo.Controls.Add(this.lblPlatForm);
            this.tabDevInfo.Controls.Add(this.lblDevName);
            this.tabDevInfo.Controls.Add(this.txtPlatFrm);
            this.tabDevInfo.Controls.Add(this.txtDevNm);
            this.tabDevInfo.Controls.Add(this.txtFPAlg);
            this.tabDevInfo.Controls.Add(this.txtFirmVer);
            this.tabDevInfo.Location = new System.Drawing.Point(4, 22);
            this.tabDevInfo.Name = "tabDevInfo";
            this.tabDevInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabDevInfo.Size = new System.Drawing.Size(922, 322);
            this.tabDevInfo.TabIndex = 0;
            this.tabDevInfo.Text = "Device Info";
            this.tabDevInfo.UseVisualStyleBackColor = true;
            // 
            // btnDeleteDB
            // 
            this.btnDeleteDB.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteDB.FlatAppearance.BorderSize = 0;
            this.btnDeleteDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDB.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDB.Location = new System.Drawing.Point(736, 283);
            this.btnDeleteDB.Name = "btnDeleteDB";
            this.btnDeleteDB.Size = new System.Drawing.Size(153, 23);
            this.btnDeleteDB.TabIndex = 30;
            this.btnDeleteDB.Text = "DeleteDB";
            this.btnDeleteDB.UseVisualStyleBackColor = false;
            this.btnDeleteDB.Click += new System.EventHandler(this.btnDeleteDB_Click);
            // 
            // btnGetDevInfo
            // 
            this.btnGetDevInfo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGetDevInfo.FlatAppearance.BorderSize = 0;
            this.btnGetDevInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetDevInfo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetDevInfo.Location = new System.Drawing.Point(577, 283);
            this.btnGetDevInfo.Name = "btnGetDevInfo";
            this.btnGetDevInfo.Size = new System.Drawing.Size(153, 23);
            this.btnGetDevInfo.TabIndex = 29;
            this.btnGetDevInfo.Text = "GetDeviceInfo";
            this.btnGetDevInfo.UseVisualStyleBackColor = false;
            this.btnGetDevInfo.Click += new System.EventHandler(this.btnGetDevInfo_Click);
            // 
            // lblManufactureTime
            // 
            this.lblManufactureTime.AutoSize = true;
            this.lblManufactureTime.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManufactureTime.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblManufactureTime.Location = new System.Drawing.Point(503, 138);
            this.lblManufactureTime.Name = "lblManufactureTime";
            this.lblManufactureTime.Size = new System.Drawing.Size(109, 13);
            this.lblManufactureTime.TabIndex = 28;
            this.lblManufactureTime.Text = "Manufacture Time";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManufacturer.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblManufacturer.Location = new System.Drawing.Point(259, 138);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(82, 13);
            this.lblManufacturer.TabIndex = 27;
            this.lblManufacturer.Text = "Manufacturer";
            // 
            // lblSerialNo
            // 
            this.lblSerialNo.AutoSize = true;
            this.lblSerialNo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerialNo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSerialNo.Location = new System.Drawing.Point(527, 98);
            this.lblSerialNo.Name = "lblSerialNo";
            this.lblSerialNo.Size = new System.Drawing.Size(85, 13);
            this.lblSerialNo.TabIndex = 26;
            this.lblSerialNo.Text = "SerialNumber";
            // 
            // lblFaceAlgo
            // 
            this.lblFaceAlgo.AutoSize = true;
            this.lblFaceAlgo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaceAlgo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblFaceAlgo.Location = new System.Drawing.Point(280, 98);
            this.lblFaceAlgo.Name = "lblFaceAlgo";
            this.lblFaceAlgo.Size = new System.Drawing.Size(61, 13);
            this.lblFaceAlgo.TabIndex = 25;
            this.lblFaceAlgo.Text = "Face Algo";
            // 
            // lblMAC
            // 
            this.lblMAC.AutoSize = true;
            this.lblMAC.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMAC.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblMAC.Location = new System.Drawing.Point(579, 58);
            this.lblMAC.Name = "lblMAC";
            this.lblMAC.Size = new System.Drawing.Size(33, 13);
            this.lblMAC.TabIndex = 24;
            this.lblMAC.Text = "MAC";
            // 
            // txtFaceAlgo
            // 
            this.txtFaceAlgo.Location = new System.Drawing.Point(344, 95);
            this.txtFaceAlgo.Name = "txtFaceAlgo";
            this.txtFaceAlgo.ReadOnly = true;
            this.txtFaceAlgo.Size = new System.Drawing.Size(153, 21);
            this.txtFaceAlgo.TabIndex = 23;
            // 
            // txtMac
            // 
            this.txtMac.Location = new System.Drawing.Point(615, 55);
            this.txtMac.Name = "txtMac";
            this.txtMac.ReadOnly = true;
            this.txtMac.Size = new System.Drawing.Size(153, 21);
            this.txtMac.TabIndex = 22;
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Location = new System.Drawing.Point(615, 95);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.ReadOnly = true;
            this.txtSerialNumber.Size = new System.Drawing.Size(153, 21);
            this.txtSerialNumber.TabIndex = 21;
            // 
            // txtMfr
            // 
            this.txtMfr.Location = new System.Drawing.Point(344, 135);
            this.txtMfr.Name = "txtMfr";
            this.txtMfr.ReadOnly = true;
            this.txtMfr.Size = new System.Drawing.Size(153, 21);
            this.txtMfr.TabIndex = 20;
            // 
            // txtMfrTime
            // 
            this.txtMfrTime.BackColor = System.Drawing.SystemColors.Control;
            this.txtMfrTime.Location = new System.Drawing.Point(615, 135);
            this.txtMfrTime.Name = "txtMfrTime";
            this.txtMfrTime.ReadOnly = true;
            this.txtMfrTime.Size = new System.Drawing.Size(153, 21);
            this.txtMfrTime.TabIndex = 19;
            // 
            // lblFirmVer
            // 
            this.lblFirmVer.AutoSize = true;
            this.lblFirmVer.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirmVer.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblFirmVer.Location = new System.Drawing.Point(258, 58);
            this.lblFirmVer.Name = "lblFirmVer";
            this.lblFirmVer.Size = new System.Drawing.Size(83, 13);
            this.lblFirmVer.TabIndex = 18;
            this.lblFirmVer.Text = "Firmware Ver";
            // 
            // lblFP_Algorithm
            // 
            this.lblFP_Algorithm.AutoSize = true;
            this.lblFP_Algorithm.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFP_Algorithm.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblFP_Algorithm.Location = new System.Drawing.Point(563, 18);
            this.lblFP_Algorithm.Name = "lblFP_Algorithm";
            this.lblFP_Algorithm.Size = new System.Drawing.Size(49, 13);
            this.lblFP_Algorithm.TabIndex = 17;
            this.lblFP_Algorithm.Text = "FP Algo";
            // 
            // lblPlatForm
            // 
            this.lblPlatForm.AutoSize = true;
            this.lblPlatForm.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlatForm.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPlatForm.Location = new System.Drawing.Point(280, 18);
            this.lblPlatForm.Name = "lblPlatForm";
            this.lblPlatForm.Size = new System.Drawing.Size(61, 13);
            this.lblPlatForm.TabIndex = 16;
            this.lblPlatForm.Text = "Plat Form";
            // 
            // lblDevName
            // 
            this.lblDevName.AutoSize = true;
            this.lblDevName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDevName.Location = new System.Drawing.Point(9, 18);
            this.lblDevName.Name = "lblDevName";
            this.lblDevName.Size = new System.Drawing.Size(83, 13);
            this.lblDevName.TabIndex = 15;
            this.lblDevName.Text = "Device Name";
            // 
            // txtPlatFrm
            // 
            this.txtPlatFrm.Location = new System.Drawing.Point(344, 15);
            this.txtPlatFrm.Name = "txtPlatFrm";
            this.txtPlatFrm.ReadOnly = true;
            this.txtPlatFrm.Size = new System.Drawing.Size(151, 21);
            this.txtPlatFrm.TabIndex = 9;
            // 
            // txtDevNm
            // 
            this.txtDevNm.Location = new System.Drawing.Point(96, 15);
            this.txtDevNm.Name = "txtDevNm";
            this.txtDevNm.ReadOnly = true;
            this.txtDevNm.Size = new System.Drawing.Size(153, 21);
            this.txtDevNm.TabIndex = 8;
            // 
            // txtFPAlg
            // 
            this.txtFPAlg.Location = new System.Drawing.Point(615, 15);
            this.txtFPAlg.Name = "txtFPAlg";
            this.txtFPAlg.ReadOnly = true;
            this.txtFPAlg.Size = new System.Drawing.Size(151, 21);
            this.txtFPAlg.TabIndex = 10;
            // 
            // txtFirmVer
            // 
            this.txtFirmVer.Location = new System.Drawing.Point(344, 55);
            this.txtFirmVer.Name = "txtFirmVer";
            this.txtFirmVer.ReadOnly = true;
            this.txtFirmVer.Size = new System.Drawing.Size(153, 21);
            this.txtFirmVer.TabIndex = 11;
            // 
            // tabDevCapacity
            // 
            this.tabDevCapacity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabDevCapacity.Controls.Add(this.txtCardCnt);
            this.tabDevCapacity.Controls.Add(this.lblCardCnt);
            this.tabDevCapacity.Controls.Add(this.btnGetDevCapacity);
            this.tabDevCapacity.Controls.Add(this.lblFaceCnt);
            this.tabDevCapacity.Controls.Add(this.lblOplogCnt);
            this.tabDevCapacity.Controls.Add(this.lblFPCnt);
            this.tabDevCapacity.Controls.Add(this.lblAttLogCnt);
            this.tabDevCapacity.Controls.Add(this.lblPwdCnt);
            this.tabDevCapacity.Controls.Add(this.lblAdminCnt);
            this.tabDevCapacity.Controls.Add(this.lblUserCnt);
            this.tabDevCapacity.Controls.Add(this.txtFaceCnt);
            this.tabDevCapacity.Controls.Add(this.txtAdminCnt);
            this.tabDevCapacity.Controls.Add(this.txtUserCnt);
            this.tabDevCapacity.Controls.Add(this.txtPWDCnt);
            this.tabDevCapacity.Controls.Add(this.txtOpLogCnt);
            this.tabDevCapacity.Controls.Add(this.txtAttLogCnt);
            this.tabDevCapacity.Controls.Add(this.txtFPCnt);
            this.tabDevCapacity.Location = new System.Drawing.Point(4, 22);
            this.tabDevCapacity.Name = "tabDevCapacity";
            this.tabDevCapacity.Padding = new System.Windows.Forms.Padding(3);
            this.tabDevCapacity.Size = new System.Drawing.Size(922, 322);
            this.tabDevCapacity.TabIndex = 1;
            this.tabDevCapacity.Text = "Device Capacity";
            this.tabDevCapacity.UseVisualStyleBackColor = true;
            // 
            // txtCardCnt
            // 
            this.txtCardCnt.Location = new System.Drawing.Point(344, 95);
            this.txtCardCnt.Name = "txtCardCnt";
            this.txtCardCnt.ReadOnly = true;
            this.txtCardCnt.Size = new System.Drawing.Size(153, 21);
            this.txtCardCnt.TabIndex = 41;
            // 
            // lblCardCnt
            // 
            this.lblCardCnt.AutoSize = true;
            this.lblCardCnt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardCnt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCardCnt.Location = new System.Drawing.Point(227, 98);
            this.lblCardCnt.Name = "lblCardCnt";
            this.lblCardCnt.Size = new System.Drawing.Size(114, 13);
            this.lblCardCnt.TabIndex = 40;
            this.lblCardCnt.Text = "Card/Badge Count";
            // 
            // btnGetDevCapacity
            // 
            this.btnGetDevCapacity.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGetDevCapacity.FlatAppearance.BorderSize = 0;
            this.btnGetDevCapacity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetDevCapacity.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetDevCapacity.Location = new System.Drawing.Point(736, 282);
            this.btnGetDevCapacity.Name = "btnGetDevCapacity";
            this.btnGetDevCapacity.Size = new System.Drawing.Size(153, 23);
            this.btnGetDevCapacity.TabIndex = 39;
            this.btnGetDevCapacity.Text = "GetDeviceCapacity";
            this.btnGetDevCapacity.UseVisualStyleBackColor = false;
            this.btnGetDevCapacity.Click += new System.EventHandler(this.btnGetDevCapacity_Click);
            // 
            // lblFaceCnt
            // 
            this.lblFaceCnt.AutoSize = true;
            this.lblFaceCnt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaceCnt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblFaceCnt.Location = new System.Drawing.Point(569, 58);
            this.lblFaceCnt.Name = "lblFaceCnt";
            this.lblFaceCnt.Size = new System.Drawing.Size(70, 13);
            this.lblFaceCnt.TabIndex = 38;
            this.lblFaceCnt.Text = "Face Count";
            // 
            // lblOplogCnt
            // 
            this.lblOplogCnt.AutoSize = true;
            this.lblOplogCnt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOplogCnt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblOplogCnt.Location = new System.Drawing.Point(264, 139);
            this.lblOplogCnt.Name = "lblOplogCnt";
            this.lblOplogCnt.Size = new System.Drawing.Size(78, 13);
            this.lblOplogCnt.TabIndex = 37;
            this.lblOplogCnt.Text = "Oplog Count";
            // 
            // lblFPCnt
            // 
            this.lblFPCnt.AutoSize = true;
            this.lblFPCnt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFPCnt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblFPCnt.Location = new System.Drawing.Point(581, 18);
            this.lblFPCnt.Name = "lblFPCnt";
            this.lblFPCnt.Size = new System.Drawing.Size(58, 13);
            this.lblFPCnt.TabIndex = 36;
            this.lblFPCnt.Text = "FP Count";
            // 
            // lblAttLogCnt
            // 
            this.lblAttLogCnt.AutoSize = true;
            this.lblAttLogCnt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttLogCnt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAttLogCnt.Location = new System.Drawing.Point(558, 98);
            this.lblAttLogCnt.Name = "lblAttLogCnt";
            this.lblAttLogCnt.Size = new System.Drawing.Size(81, 13);
            this.lblAttLogCnt.TabIndex = 35;
            this.lblAttLogCnt.Text = "AttLog Count";
            // 
            // lblPwdCnt
            // 
            this.lblPwdCnt.AutoSize = true;
            this.lblPwdCnt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPwdCnt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPwdCnt.Location = new System.Drawing.Point(242, 58);
            this.lblPwdCnt.Name = "lblPwdCnt";
            this.lblPwdCnt.Size = new System.Drawing.Size(99, 13);
            this.lblPwdCnt.TabIndex = 34;
            this.lblPwdCnt.Text = "Password Count";
            // 
            // lblAdminCnt
            // 
            this.lblAdminCnt.AutoSize = true;
            this.lblAdminCnt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminCnt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAdminCnt.Location = new System.Drawing.Point(12, 18);
            this.lblAdminCnt.Name = "lblAdminCnt";
            this.lblAdminCnt.Size = new System.Drawing.Size(81, 13);
            this.lblAdminCnt.TabIndex = 33;
            this.lblAdminCnt.Text = "Admin Count";
            // 
            // lblUserCnt
            // 
            this.lblUserCnt.AutoSize = true;
            this.lblUserCnt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserCnt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblUserCnt.Location = new System.Drawing.Point(270, 18);
            this.lblUserCnt.Name = "lblUserCnt";
            this.lblUserCnt.Size = new System.Drawing.Size(71, 13);
            this.lblUserCnt.TabIndex = 32;
            this.lblUserCnt.Text = "User Count";
            // 
            // txtFaceCnt
            // 
            this.txtFaceCnt.Location = new System.Drawing.Point(642, 55);
            this.txtFaceCnt.Name = "txtFaceCnt";
            this.txtFaceCnt.ReadOnly = true;
            this.txtFaceCnt.Size = new System.Drawing.Size(153, 21);
            this.txtFaceCnt.TabIndex = 31;
            // 
            // txtAdminCnt
            // 
            this.txtAdminCnt.Location = new System.Drawing.Point(96, 15);
            this.txtAdminCnt.Name = "txtAdminCnt";
            this.txtAdminCnt.ReadOnly = true;
            this.txtAdminCnt.Size = new System.Drawing.Size(153, 21);
            this.txtAdminCnt.TabIndex = 26;
            // 
            // txtUserCnt
            // 
            this.txtUserCnt.Location = new System.Drawing.Point(344, 15);
            this.txtUserCnt.Name = "txtUserCnt";
            this.txtUserCnt.ReadOnly = true;
            this.txtUserCnt.Size = new System.Drawing.Size(153, 21);
            this.txtUserCnt.TabIndex = 25;
            // 
            // txtPWDCnt
            // 
            this.txtPWDCnt.Location = new System.Drawing.Point(344, 55);
            this.txtPWDCnt.Name = "txtPWDCnt";
            this.txtPWDCnt.ReadOnly = true;
            this.txtPWDCnt.Size = new System.Drawing.Size(153, 21);
            this.txtPWDCnt.TabIndex = 27;
            // 
            // txtOpLogCnt
            // 
            this.txtOpLogCnt.Location = new System.Drawing.Point(345, 136);
            this.txtOpLogCnt.Name = "txtOpLogCnt";
            this.txtOpLogCnt.ReadOnly = true;
            this.txtOpLogCnt.Size = new System.Drawing.Size(153, 21);
            this.txtOpLogCnt.TabIndex = 30;
            // 
            // txtAttLogCnt
            // 
            this.txtAttLogCnt.Location = new System.Drawing.Point(642, 95);
            this.txtAttLogCnt.Name = "txtAttLogCnt";
            this.txtAttLogCnt.ReadOnly = true;
            this.txtAttLogCnt.Size = new System.Drawing.Size(153, 21);
            this.txtAttLogCnt.TabIndex = 28;
            // 
            // txtFPCnt
            // 
            this.txtFPCnt.Location = new System.Drawing.Point(642, 15);
            this.txtFPCnt.Name = "txtFPCnt";
            this.txtFPCnt.ReadOnly = true;
            this.txtFPCnt.Size = new System.Drawing.Size(153, 21);
            this.txtFPCnt.TabIndex = 29;
            // 
            // grpConnect
            // 
            this.grpConnect.Controls.Add(this.tabConnect);
            this.grpConnect.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpConnect.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpConnect.Location = new System.Drawing.Point(0, 0);
            this.grpConnect.Name = "grpConnect";
            this.grpConnect.Size = new System.Drawing.Size(930, 112);
            this.grpConnect.TabIndex = 2;
            this.grpConnect.TabStop = false;
            this.grpConnect.Text = "Communication";
            // 
            // tabConnect
            // 
            this.tabConnect.Controls.Add(this.tabTcpIP);
            this.tabConnect.Controls.Add(this.tabRS);
            this.tabConnect.Controls.Add(this.tabUSB);
            this.tabConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabConnect.Location = new System.Drawing.Point(3, 18);
            this.tabConnect.Name = "tabConnect";
            this.tabConnect.SelectedIndex = 0;
            this.tabConnect.Size = new System.Drawing.Size(924, 91);
            this.tabConnect.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabConnect.TabIndex = 0;
            // 
            // tabTcpIP
            // 
            this.tabTcpIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabTcpIP.Controls.Add(this.btnConnect);
            this.tabTcpIP.Controls.Add(this.txtDeviceCommKey);
            this.tabTcpIP.Controls.Add(this.lblDeviceComm);
            this.tabTcpIP.Controls.Add(this.txtDevicePort);
            this.tabTcpIP.Controls.Add(this.lblDevicePort);
            this.tabTcpIP.Controls.Add(this.txtDeviceIP);
            this.tabTcpIP.Controls.Add(this.lblDeviceIP);
            this.tabTcpIP.Controls.Add(this.txtDeviceId);
            this.tabTcpIP.Controls.Add(this.lblDeviceId);
            this.tabTcpIP.Location = new System.Drawing.Point(4, 23);
            this.tabTcpIP.Name = "tabTcpIP";
            this.tabTcpIP.Padding = new System.Windows.Forms.Padding(3);
            this.tabTcpIP.Size = new System.Drawing.Size(916, 64);
            this.tabTcpIP.TabIndex = 0;
            this.tabTcpIP.Text = "Tcp / IP";
            this.tabTcpIP.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(136)))), ((int)(((byte)(14)))));
            this.btnConnect.FlatAppearance.BorderSize = 0;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(796, 14);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(90, 23);
            this.btnConnect.TabIndex = 22;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtDeviceCommKey
            // 
            this.txtDeviceCommKey.Location = new System.Drawing.Point(669, 15);
            this.txtDeviceCommKey.Name = "txtDeviceCommKey";
            this.txtDeviceCommKey.Size = new System.Drawing.Size(100, 22);
            this.txtDeviceCommKey.TabIndex = 21;
            this.txtDeviceCommKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeviceCommKey_KeyPress);
            // 
            // lblDeviceComm
            // 
            this.lblDeviceComm.AutoSize = true;
            this.lblDeviceComm.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviceComm.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDeviceComm.Location = new System.Drawing.Point(551, 18);
            this.lblDeviceComm.Name = "lblDeviceComm";
            this.lblDeviceComm.Size = new System.Drawing.Size(114, 14);
            this.lblDeviceComm.TabIndex = 20;
            this.lblDeviceComm.Text = "Device CommKey";
            // 
            // txtDevicePort
            // 
            this.txtDevicePort.Location = new System.Drawing.Point(448, 15);
            this.txtDevicePort.Name = "txtDevicePort";
            this.txtDevicePort.Size = new System.Drawing.Size(100, 22);
            this.txtDevicePort.TabIndex = 19;
            // 
            // lblDevicePort
            // 
            this.lblDevicePort.AutoSize = true;
            this.lblDevicePort.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevicePort.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDevicePort.Location = new System.Drawing.Point(367, 18);
            this.lblDevicePort.Name = "lblDevicePort";
            this.lblDevicePort.Size = new System.Drawing.Size(78, 14);
            this.lblDevicePort.TabIndex = 18;
            this.lblDevicePort.Text = "Device Port";
            // 
            // txtDeviceIP
            // 
            this.txtDeviceIP.Location = new System.Drawing.Point(264, 15);
            this.txtDeviceIP.Name = "txtDeviceIP";
            this.txtDeviceIP.Size = new System.Drawing.Size(100, 22);
            this.txtDeviceIP.TabIndex = 17;
            // 
            // lblDeviceIP
            // 
            this.lblDeviceIP.AutoSize = true;
            this.lblDeviceIP.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviceIP.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDeviceIP.Location = new System.Drawing.Point(196, 18);
            this.lblDeviceIP.Name = "lblDeviceIP";
            this.lblDeviceIP.Size = new System.Drawing.Size(65, 14);
            this.lblDeviceIP.TabIndex = 16;
            this.lblDeviceIP.Text = "Device IP";
            // 
            // txtDeviceId
            // 
            this.txtDeviceId.Location = new System.Drawing.Point(93, 15);
            this.txtDeviceId.Name = "txtDeviceId";
            this.txtDeviceId.Size = new System.Drawing.Size(100, 22);
            this.txtDeviceId.TabIndex = 15;
            // 
            // lblDeviceId
            // 
            this.lblDeviceId.AutoSize = true;
            this.lblDeviceId.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviceId.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDeviceId.Location = new System.Drawing.Point(24, 18);
            this.lblDeviceId.Name = "lblDeviceId";
            this.lblDeviceId.Size = new System.Drawing.Size(65, 14);
            this.lblDeviceId.TabIndex = 14;
            this.lblDeviceId.Text = "Device Id";
            // 
            // tabRS
            // 
            this.tabRS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabRS.Controls.Add(this.btn2Connect);
            this.tabRS.Controls.Add(this.lbl2DeviceComm);
            this.tabRS.Controls.Add(this.lbl2BaudRate);
            this.tabRS.Controls.Add(this.lbl2ComPort);
            this.tabRS.Controls.Add(this.txt2CommKey);
            this.tabRS.Controls.Add(this.cmbBaudRate);
            this.tabRS.Controls.Add(this.cmbComPort);
            this.tabRS.Controls.Add(this.txt2DeviceId);
            this.tabRS.Controls.Add(this.lbl2DeviceId);
            this.tabRS.Location = new System.Drawing.Point(4, 23);
            this.tabRS.Name = "tabRS";
            this.tabRS.Padding = new System.Windows.Forms.Padding(3);
            this.tabRS.Size = new System.Drawing.Size(916, 64);
            this.tabRS.TabIndex = 1;
            this.tabRS.Text = "RS232/RS485";
            this.tabRS.UseVisualStyleBackColor = true;
            // 
            // btn2Connect
            // 
            this.btn2Connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(136)))), ((int)(((byte)(14)))));
            this.btn2Connect.FlatAppearance.BorderSize = 0;
            this.btn2Connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2Connect.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Connect.Location = new System.Drawing.Point(796, 14);
            this.btn2Connect.Name = "btn2Connect";
            this.btn2Connect.Size = new System.Drawing.Size(90, 23);
            this.btn2Connect.TabIndex = 29;
            this.btn2Connect.Text = "Connect";
            this.btn2Connect.UseVisualStyleBackColor = false;
            this.btn2Connect.Click += new System.EventHandler(this.btn2Connect_Click);
            // 
            // lbl2DeviceComm
            // 
            this.lbl2DeviceComm.AutoSize = true;
            this.lbl2DeviceComm.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2DeviceComm.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl2DeviceComm.Location = new System.Drawing.Point(556, 18);
            this.lbl2DeviceComm.Name = "lbl2DeviceComm";
            this.lbl2DeviceComm.Size = new System.Drawing.Size(114, 14);
            this.lbl2DeviceComm.TabIndex = 28;
            this.lbl2DeviceComm.Text = "Device CommKey";
            // 
            // lbl2BaudRate
            // 
            this.lbl2BaudRate.AutoSize = true;
            this.lbl2BaudRate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2BaudRate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl2BaudRate.Location = new System.Drawing.Point(381, 18);
            this.lbl2BaudRate.Name = "lbl2BaudRate";
            this.lbl2BaudRate.Size = new System.Drawing.Size(68, 14);
            this.lbl2BaudRate.TabIndex = 27;
            this.lbl2BaudRate.Text = "BaudRate";
            this.lbl2BaudRate.Visible = false;
            // 
            // lbl2ComPort
            // 
            this.lbl2ComPort.AutoSize = true;
            this.lbl2ComPort.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2ComPort.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl2ComPort.Location = new System.Drawing.Point(196, 18);
            this.lbl2ComPort.Name = "lbl2ComPort";
            this.lbl2ComPort.Size = new System.Drawing.Size(107, 14);
            this.lbl2ComPort.TabIndex = 26;
            this.lbl2ComPort.Text = "Serial(com) Port";
            this.lbl2ComPort.Visible = false;
            // 
            // txt2CommKey
            // 
            this.txt2CommKey.Location = new System.Drawing.Point(673, 15);
            this.txt2CommKey.MaxLength = 6;
            this.txt2CommKey.Name = "txt2CommKey";
            this.txt2CommKey.Size = new System.Drawing.Size(100, 22);
            this.txt2CommKey.TabIndex = 25;
            this.txt2CommKey.Text = "0";
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cmbBaudRate.Location = new System.Drawing.Point(453, 15);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(100, 22);
            this.cmbBaudRate.TabIndex = 24;
            this.cmbBaudRate.Text = "115200";
            // 
            // cmbComPort
            // 
            this.cmbComPort.FormattingEnabled = true;
            this.cmbComPort.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.cmbComPort.Location = new System.Drawing.Point(306, 15);
            this.cmbComPort.Name = "cmbComPort";
            this.cmbComPort.Size = new System.Drawing.Size(72, 22);
            this.cmbComPort.TabIndex = 18;
            this.cmbComPort.Text = "COM1";
            // 
            // txt2DeviceId
            // 
            this.txt2DeviceId.Location = new System.Drawing.Point(93, 15);
            this.txt2DeviceId.Name = "txt2DeviceId";
            this.txt2DeviceId.Size = new System.Drawing.Size(100, 22);
            this.txt2DeviceId.TabIndex = 17;
            // 
            // lbl2DeviceId
            // 
            this.lbl2DeviceId.AutoSize = true;
            this.lbl2DeviceId.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2DeviceId.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl2DeviceId.Location = new System.Drawing.Point(24, 18);
            this.lbl2DeviceId.Name = "lbl2DeviceId";
            this.lbl2DeviceId.Size = new System.Drawing.Size(65, 14);
            this.lbl2DeviceId.TabIndex = 16;
            this.lbl2DeviceId.Text = "Device Id";
            // 
            // tabUSB
            // 
            this.tabUSB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabUSB.Controls.Add(this.lbl3DeviceComm);
            this.tabUSB.Controls.Add(this.txt3CommKey);
            this.tabUSB.Controls.Add(this.rbUSBClient);
            this.tabUSB.Controls.Add(this.rbUSB);
            this.tabUSB.Controls.Add(this.txt3DeviceId);
            this.tabUSB.Controls.Add(this.lbl3DeviceId);
            this.tabUSB.Controls.Add(this.btn3Connect);
            this.tabUSB.Location = new System.Drawing.Point(4, 23);
            this.tabUSB.Name = "tabUSB";
            this.tabUSB.Size = new System.Drawing.Size(916, 64);
            this.tabUSB.TabIndex = 2;
            this.tabUSB.Text = "USB";
            this.tabUSB.UseVisualStyleBackColor = true;
            // 
            // lbl3DeviceComm
            // 
            this.lbl3DeviceComm.AutoSize = true;
            this.lbl3DeviceComm.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3DeviceComm.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl3DeviceComm.Location = new System.Drawing.Point(346, 18);
            this.lbl3DeviceComm.Name = "lbl3DeviceComm";
            this.lbl3DeviceComm.Size = new System.Drawing.Size(114, 14);
            this.lbl3DeviceComm.TabIndex = 37;
            this.lbl3DeviceComm.Text = "Device CommKey";
            // 
            // txt3CommKey
            // 
            this.txt3CommKey.Location = new System.Drawing.Point(463, 15);
            this.txt3CommKey.MaxLength = 6;
            this.txt3CommKey.Name = "txt3CommKey";
            this.txt3CommKey.Size = new System.Drawing.Size(100, 22);
            this.txt3CommKey.TabIndex = 36;
            this.txt3CommKey.Text = "0";
            // 
            // rbUSBClient
            // 
            this.rbUSBClient.AutoSize = true;
            this.rbUSBClient.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rbUSBClient.Location = new System.Drawing.Point(213, 41);
            this.rbUSBClient.Name = "rbUSBClient";
            this.rbUSBClient.Size = new System.Drawing.Size(130, 18);
            this.rbUSBClient.TabIndex = 33;
            this.rbUSBClient.Text = "Virtual USBClient";
            this.rbUSBClient.UseVisualStyleBackColor = true;
            // 
            // rbUSB
            // 
            this.rbUSB.AutoSize = true;
            this.rbUSB.Checked = true;
            this.rbUSB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rbUSB.Location = new System.Drawing.Point(213, 17);
            this.rbUSB.Name = "rbUSB";
            this.rbUSB.Size = new System.Drawing.Size(86, 18);
            this.rbUSB.TabIndex = 34;
            this.rbUSB.TabStop = true;
            this.rbUSB.Text = "USBClient";
            this.rbUSB.UseVisualStyleBackColor = true;
            // 
            // txt3DeviceId
            // 
            this.txt3DeviceId.Location = new System.Drawing.Point(93, 15);
            this.txt3DeviceId.Name = "txt3DeviceId";
            this.txt3DeviceId.Size = new System.Drawing.Size(100, 22);
            this.txt3DeviceId.TabIndex = 32;
            // 
            // lbl3DeviceId
            // 
            this.lbl3DeviceId.AutoSize = true;
            this.lbl3DeviceId.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3DeviceId.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl3DeviceId.Location = new System.Drawing.Point(24, 18);
            this.lbl3DeviceId.Name = "lbl3DeviceId";
            this.lbl3DeviceId.Size = new System.Drawing.Size(65, 14);
            this.lbl3DeviceId.TabIndex = 31;
            this.lbl3DeviceId.Text = "Device Id";
            // 
            // btn3Connect
            // 
            this.btn3Connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(136)))), ((int)(((byte)(14)))));
            this.btn3Connect.FlatAppearance.BorderSize = 0;
            this.btn3Connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3Connect.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3Connect.Location = new System.Drawing.Point(796, 18);
            this.btn3Connect.Name = "btn3Connect";
            this.btn3Connect.Size = new System.Drawing.Size(90, 23);
            this.btn3Connect.TabIndex = 30;
            this.btn3Connect.Text = "Connect";
            this.btn3Connect.UseVisualStyleBackColor = false;
            this.btn3Connect.Click += new System.EventHandler(this.btn3Connect_Click);
            // 
            // FrmTerminal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(930, 460);
            this.Controls.Add(this.pnlTerminal);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTerminal";
            this.Text = "FrmTerminal";
            this.Load += new System.EventHandler(this.FrmTerminal_Load);
            this.pnlTerminal.ResumeLayout(false);
            this.pnlMiddle.ResumeLayout(false);
            this.tabDeviceInfo.ResumeLayout(false);
            this.tabDevInfo.ResumeLayout(false);
            this.tabDevInfo.PerformLayout();
            this.tabDevCapacity.ResumeLayout(false);
            this.tabDevCapacity.PerformLayout();
            this.grpConnect.ResumeLayout(false);
            this.tabConnect.ResumeLayout(false);
            this.tabTcpIP.ResumeLayout(false);
            this.tabTcpIP.PerformLayout();
            this.tabRS.ResumeLayout(false);
            this.tabRS.PerformLayout();
            this.tabUSB.ResumeLayout(false);
            this.tabUSB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTerminal;
        private System.Windows.Forms.TabPage tabTcpIP;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtDeviceCommKey;
        private System.Windows.Forms.Label lblDeviceComm;
        private System.Windows.Forms.Label lblDevicePort;
        private System.Windows.Forms.Label lblDeviceIP;
        private System.Windows.Forms.Label lblDeviceId;
        private System.Windows.Forms.TabPage tabRS;
        private System.Windows.Forms.TabPage tabUSB;
        private System.Windows.Forms.Panel pnlMiddle;
        private System.Windows.Forms.TabControl tabDeviceInfo;
        private System.Windows.Forms.TabPage tabDevInfo;
        private System.Windows.Forms.Label lblManufactureTime;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblSerialNo;
        private System.Windows.Forms.Label lblFaceAlgo;
        private System.Windows.Forms.Label lblMAC;
        private System.Windows.Forms.TextBox txtFaceAlgo;
        private System.Windows.Forms.TextBox txtMac;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.TextBox txtMfr;
        private System.Windows.Forms.TextBox txtMfrTime;
        private System.Windows.Forms.Label lblFirmVer;
        private System.Windows.Forms.Label lblFP_Algorithm;
        private System.Windows.Forms.Label lblPlatForm;
        private System.Windows.Forms.Label lblDevName;
        private System.Windows.Forms.TextBox txtPlatFrm;
        private System.Windows.Forms.TextBox txtDevNm;
        private System.Windows.Forms.TextBox txtFPAlg;
        private System.Windows.Forms.TextBox txtFirmVer;
        private System.Windows.Forms.TabPage tabDevCapacity;
        private System.Windows.Forms.Label lblFaceCnt;
        private System.Windows.Forms.Label lblOplogCnt;
        private System.Windows.Forms.Label lblFPCnt;
        private System.Windows.Forms.Label lblAttLogCnt;
        private System.Windows.Forms.Label lblPwdCnt;
        private System.Windows.Forms.Label lblAdminCnt;
        private System.Windows.Forms.Label lblUserCnt;
        private System.Windows.Forms.TextBox txtFaceCnt;
        private System.Windows.Forms.TextBox txtAdminCnt;
        private System.Windows.Forms.TextBox txtUserCnt;
        private System.Windows.Forms.TextBox txtPWDCnt;
        private System.Windows.Forms.TextBox txtOpLogCnt;
        private System.Windows.Forms.TextBox txtAttLogCnt;
        private System.Windows.Forms.TextBox txtFPCnt;
        private System.Windows.Forms.TextBox txt2DeviceId;
        private System.Windows.Forms.Label lbl2DeviceId;
        private System.Windows.Forms.TextBox txt2CommKey;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.ComboBox cmbComPort;
        private System.Windows.Forms.Label lbl2DeviceComm;
        private System.Windows.Forms.Label lbl2BaudRate;
        private System.Windows.Forms.Label lbl2ComPort;
        private System.Windows.Forms.Button btn2Connect;
        private System.Windows.Forms.TextBox txt3DeviceId;
        private System.Windows.Forms.Label lbl3DeviceId;
        private System.Windows.Forms.Button btn3Connect;
        private System.Windows.Forms.RadioButton rbUSBClient;
        private System.Windows.Forms.RadioButton rbUSB;
        private System.Windows.Forms.TextBox txt3CommKey;
        private System.Windows.Forms.Label lbl3DeviceComm;
        private System.Windows.Forms.Button btnGetDevInfo;
        private System.Windows.Forms.Button btnGetDevCapacity;
        private System.Windows.Forms.TextBox txtCardCnt;
        private System.Windows.Forms.Label lblCardCnt;
        private System.Windows.Forms.Button btnDeleteDB;
        public System.Windows.Forms.TextBox txtDevicePort;
        public System.Windows.Forms.TextBox txtDeviceIP;
        public System.Windows.Forms.TextBox txtDeviceId;
        private System.Windows.Forms.GroupBox grpConnect;
        public System.Windows.Forms.TabControl tabConnect;


    }
}