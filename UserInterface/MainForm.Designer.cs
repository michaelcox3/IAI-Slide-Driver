namespace IAIProject
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.TextTimer = new System.Windows.Forms.Timer(this.components);
            this.SerialPortsAvail = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnServoOff = new System.Windows.Forms.Button();
            this.BtnServoOn = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.BtnJogUp = new System.Windows.Forms.Button();
            this.BtnJogDn = new System.Windows.Forms.Button();
            this.BtnInchDn = new System.Windows.Forms.Button();
            this.BtnInchUp = new System.Windows.Forms.Button();
            this.BtnAbsMove = new System.Windows.Forms.Button();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.TbCurAmps = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbCurSpeed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TbCurPos = new System.Windows.Forms.TextBox();
            this.BtnResetAlarm = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CBPresets = new System.Windows.Forms.ComboBox();
            this.TbPresetPos = new System.Windows.Forms.TextBox();
            this.BtnAddPreset = new System.Windows.Forms.Button();
            this.NumRelMove = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TbServoStatus = new System.Windows.Forms.TextBox();
            this.TbAlarmCode = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NumAbsMove = new System.Windows.Forms.NumericUpDown();
            this.BtnStop = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnDelPreset = new System.Windows.Forms.Button();
            this.BtnNewPreset = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnGoToPreset = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.NumAmpLimit = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.NumAmpDownLimit = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPresetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePresetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.errorCodeDocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.additionalInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.InchLoop = new System.Windows.Forms.Timer(this.components);
            this.JogLoop = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NumRelMove)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumAbsMove)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumAmpLimit)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumAmpDownLimit)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(24, 55);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(165, 25);
            this.BtnConnect.TabIndex = 0;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // TextTimer
            // 
            this.TextTimer.Interval = 25;
            this.TextTimer.Tick += new System.EventHandler(this.TextTimer_Tick);
            // 
            // SerialPortsAvail
            // 
            this.SerialPortsAvail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SerialPortsAvail.FormattingEnabled = true;
            this.SerialPortsAvail.Location = new System.Drawing.Point(91, 24);
            this.SerialPortsAvail.Name = "SerialPortsAvail";
            this.SerialPortsAvail.Size = new System.Drawing.Size(98, 21);
            this.SerialPortsAvail.TabIndex = 3;
            this.SerialPortsAvail.SelectedIndexChanged += new System.EventHandler(this.SerialPortsAvail_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "COM Port";
            // 
            // BtnServoOff
            // 
            this.BtnServoOff.Location = new System.Drawing.Point(112, 19);
            this.BtnServoOff.Name = "BtnServoOff";
            this.BtnServoOff.Size = new System.Drawing.Size(100, 50);
            this.BtnServoOff.TabIndex = 34;
            this.BtnServoOff.Text = "Servo Off";
            this.BtnServoOff.UseVisualStyleBackColor = true;
            this.BtnServoOff.Click += new System.EventHandler(this.BtnServoOff_Click);
            // 
            // BtnServoOn
            // 
            this.BtnServoOn.Location = new System.Drawing.Point(6, 19);
            this.BtnServoOn.Name = "BtnServoOn";
            this.BtnServoOn.Size = new System.Drawing.Size(100, 50);
            this.BtnServoOn.TabIndex = 33;
            this.BtnServoOn.Text = "Servo On";
            this.BtnServoOn.UseVisualStyleBackColor = true;
            this.BtnServoOn.Click += new System.EventHandler(this.BtnServoOn_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.Location = new System.Drawing.Point(6, 75);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(207, 50);
            this.BtnHome.TabIndex = 41;
            this.BtnHome.Text = "Home";
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // BtnJogUp
            // 
            this.BtnJogUp.Location = new System.Drawing.Point(112, 131);
            this.BtnJogUp.Name = "BtnJogUp";
            this.BtnJogUp.Size = new System.Drawing.Size(100, 50);
            this.BtnJogUp.TabIndex = 28;
            this.BtnJogUp.Text = "Jog Up";
            this.BtnJogUp.UseVisualStyleBackColor = true;
            this.BtnJogUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnJogUp_MouseDown);
            this.BtnJogUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnInchUp_MouseUp);
            // 
            // BtnJogDn
            // 
            this.BtnJogDn.Location = new System.Drawing.Point(6, 131);
            this.BtnJogDn.Name = "BtnJogDn";
            this.BtnJogDn.Size = new System.Drawing.Size(100, 50);
            this.BtnJogDn.TabIndex = 27;
            this.BtnJogDn.Text = "Jog Down";
            this.BtnJogDn.UseVisualStyleBackColor = true;
            this.BtnJogDn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnJogDn_MouseDown);
            this.BtnJogDn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnInchUp_MouseUp);
            // 
            // BtnInchDn
            // 
            this.BtnInchDn.Location = new System.Drawing.Point(6, 187);
            this.BtnInchDn.Name = "BtnInchDn";
            this.BtnInchDn.Size = new System.Drawing.Size(100, 50);
            this.BtnInchDn.TabIndex = 29;
            this.BtnInchDn.Text = "Inch Down";
            this.BtnInchDn.UseVisualStyleBackColor = true;
            this.BtnInchDn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnInchDn_MouseDown);
            this.BtnInchDn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnInchUp_MouseUp);
            // 
            // BtnInchUp
            // 
            this.BtnInchUp.Location = new System.Drawing.Point(112, 187);
            this.BtnInchUp.Name = "BtnInchUp";
            this.BtnInchUp.Size = new System.Drawing.Size(100, 50);
            this.BtnInchUp.TabIndex = 30;
            this.BtnInchUp.Text = "Inch Up";
            this.BtnInchUp.UseVisualStyleBackColor = true;
            this.BtnInchUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnInchUp_MouseDown);
            this.BtnInchUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnInchUp_MouseUp);
            // 
            // BtnAbsMove
            // 
            this.BtnAbsMove.Location = new System.Drawing.Point(6, 299);
            this.BtnAbsMove.Name = "BtnAbsMove";
            this.BtnAbsMove.Size = new System.Drawing.Size(100, 50);
            this.BtnAbsMove.TabIndex = 42;
            this.BtnAbsMove.Text = "Absolute Move";
            this.BtnAbsMove.UseVisualStyleBackColor = true;
            this.BtnAbsMove.Click += new System.EventHandler(this.BtnAbsMove_Click);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(162, 113);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(22, 13);
            this.Label8.TabIndex = 54;
            this.Label8.Text = "mA";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(162, 87);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(33, 13);
            this.Label7.TabIndex = 53;
            this.Label7.Text = "mm/s";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(162, 61);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(23, 13);
            this.Label6.TabIndex = 52;
            this.Label6.Text = "mm";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(40, 113);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(62, 13);
            this.Label3.TabIndex = 51;
            this.Label3.Text = "Motor Draw";
            // 
            // TbCurAmps
            // 
            this.TbCurAmps.Location = new System.Drawing.Point(110, 110);
            this.TbCurAmps.Name = "TbCurAmps";
            this.TbCurAmps.ReadOnly = true;
            this.TbCurAmps.Size = new System.Drawing.Size(48, 20);
            this.TbCurAmps.TabIndex = 50;
            this.TbCurAmps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Current Speed";
            // 
            // TbCurSpeed
            // 
            this.TbCurSpeed.Location = new System.Drawing.Point(110, 84);
            this.TbCurSpeed.Name = "TbCurSpeed";
            this.TbCurSpeed.ReadOnly = true;
            this.TbCurSpeed.Size = new System.Drawing.Size(48, 20);
            this.TbCurSpeed.TabIndex = 48;
            this.TbCurSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Current Position";
            // 
            // TbCurPos
            // 
            this.TbCurPos.Location = new System.Drawing.Point(110, 58);
            this.TbCurPos.Name = "TbCurPos";
            this.TbCurPos.ReadOnly = true;
            this.TbCurPos.Size = new System.Drawing.Size(48, 20);
            this.TbCurPos.TabIndex = 46;
            this.TbCurPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnResetAlarm
            // 
            this.BtnResetAlarm.Location = new System.Drawing.Point(6, 162);
            this.BtnResetAlarm.Name = "BtnResetAlarm";
            this.BtnResetAlarm.Size = new System.Drawing.Size(201, 26);
            this.BtnResetAlarm.TabIndex = 55;
            this.BtnResetAlarm.Text = "Reset Alarm";
            this.BtnResetAlarm.UseVisualStyleBackColor = true;
            this.BtnResetAlarm.Click += new System.EventHandler(this.BtnResetAlarm_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(178, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "mm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "Inch Distance";
            // 
            // CBPresets
            // 
            this.CBPresets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBPresets.FormattingEnabled = true;
            this.CBPresets.Location = new System.Drawing.Point(6, 19);
            this.CBPresets.Name = "CBPresets";
            this.CBPresets.Size = new System.Drawing.Size(96, 21);
            this.CBPresets.TabIndex = 58;
            this.CBPresets.SelectedIndexChanged += new System.EventHandler(this.CBPresets_SelectedIndexChanged);
            // 
            // TbPresetPos
            // 
            this.TbPresetPos.Location = new System.Drawing.Point(108, 19);
            this.TbPresetPos.Name = "TbPresetPos";
            this.TbPresetPos.ReadOnly = true;
            this.TbPresetPos.Size = new System.Drawing.Size(75, 20);
            this.TbPresetPos.TabIndex = 60;
            // 
            // BtnAddPreset
            // 
            this.BtnAddPreset.Location = new System.Drawing.Point(6, 113);
            this.BtnAddPreset.Name = "BtnAddPreset";
            this.BtnAddPreset.Size = new System.Drawing.Size(201, 23);
            this.BtnAddPreset.TabIndex = 61;
            this.BtnAddPreset.Text = "Create Preset At Current Position";
            this.BtnAddPreset.UseVisualStyleBackColor = true;
            this.BtnAddPreset.Click += new System.EventHandler(this.BtnAddPreset_Click);
            // 
            // NumRelMove
            // 
            this.NumRelMove.DecimalPlaces = 2;
            this.NumRelMove.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.NumRelMove.Location = new System.Drawing.Point(100, 19);
            this.NumRelMove.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumRelMove.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            this.NumRelMove.Name = "NumRelMove";
            this.NumRelMove.Size = new System.Drawing.Size(72, 20);
            this.NumRelMove.TabIndex = 62;
            this.NumRelMove.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TbServoStatus);
            this.groupBox1.Controls.Add(this.TbAlarmCode);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TbCurPos);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TbCurSpeed);
            this.groupBox1.Controls.Add(this.BtnResetAlarm);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TbCurAmps);
            this.groupBox1.Controls.Add(this.Label3);
            this.groupBox1.Controls.Add(this.Label6);
            this.groupBox1.Controls.Add(this.Label7);
            this.groupBox1.Controls.Add(this.Label8);
            this.groupBox1.Location = new System.Drawing.Point(239, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 201);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // TbServoStatus
            // 
            this.TbServoStatus.Location = new System.Drawing.Point(110, 32);
            this.TbServoStatus.Name = "TbServoStatus";
            this.TbServoStatus.ReadOnly = true;
            this.TbServoStatus.Size = new System.Drawing.Size(48, 20);
            this.TbServoStatus.TabIndex = 77;
            this.TbServoStatus.Text = "N/A";
            this.TbServoStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TbAlarmCode
            // 
            this.TbAlarmCode.Location = new System.Drawing.Point(110, 136);
            this.TbAlarmCode.Name = "TbAlarmCode";
            this.TbAlarmCode.ReadOnly = true;
            this.TbAlarmCode.Size = new System.Drawing.Size(48, 20);
            this.TbAlarmCode.TabIndex = 76;
            this.TbAlarmCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(43, 139);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 76;
            this.label15.Text = "Alarm Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 76;
            this.label2.Text = "Servo Status";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NumAbsMove);
            this.groupBox2.Controls.Add(this.BtnInchUp);
            this.groupBox2.Controls.Add(this.BtnJogUp);
            this.groupBox2.Controls.Add(this.BtnJogDn);
            this.groupBox2.Controls.Add(this.BtnInchDn);
            this.groupBox2.Controls.Add(this.BtnStop);
            this.groupBox2.Controls.Add(this.BtnServoOff);
            this.groupBox2.Controls.Add(this.BtnHome);
            this.groupBox2.Controls.Add(this.BtnServoOn);
            this.groupBox2.Controls.Add(this.BtnAbsMove);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 361);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controls";
            // 
            // NumAbsMove
            // 
            this.NumAbsMove.DecimalPlaces = 2;
            this.NumAbsMove.Location = new System.Drawing.Point(117, 316);
            this.NumAbsMove.Maximum = new decimal(new int[] {
            700,
            0,
            0,
            0});
            this.NumAbsMove.Name = "NumAbsMove";
            this.NumAbsMove.Size = new System.Drawing.Size(72, 20);
            this.NumAbsMove.TabIndex = 81;
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(6, 243);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(206, 50);
            this.BtnStop.TabIndex = 31;
            this.BtnStop.Text = "Stop Motion";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(190, 318);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 67;
            this.label12.Text = "mm";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.SerialPortsAvail);
            this.groupBox3.Controls.Add(this.BtnConnect);
            this.groupBox3.Location = new System.Drawing.Point(12, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(221, 92);
            this.groupBox3.TabIndex = 65;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Connection";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnDelPreset);
            this.groupBox4.Controls.Add(this.BtnNewPreset);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.BtnGoToPreset);
            this.groupBox4.Controls.Add(this.CBPresets);
            this.groupBox4.Controls.Add(this.TbPresetPos);
            this.groupBox4.Controls.Add(this.BtnAddPreset);
            this.groupBox4.Location = new System.Drawing.Point(239, 342);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(213, 171);
            this.groupBox4.TabIndex = 66;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Presets";
            // 
            // BtnDelPreset
            // 
            this.BtnDelPreset.Location = new System.Drawing.Point(6, 142);
            this.BtnDelPreset.Name = "BtnDelPreset";
            this.BtnDelPreset.Size = new System.Drawing.Size(201, 23);
            this.BtnDelPreset.TabIndex = 69;
            this.BtnDelPreset.Text = "Delete Selected Preset";
            this.BtnDelPreset.UseVisualStyleBackColor = true;
            this.BtnDelPreset.Click += new System.EventHandler(this.BtnDelPreset_Click);
            // 
            // BtnNewPreset
            // 
            this.BtnNewPreset.Location = new System.Drawing.Point(6, 84);
            this.BtnNewPreset.Name = "BtnNewPreset";
            this.BtnNewPreset.Size = new System.Drawing.Size(201, 23);
            this.BtnNewPreset.TabIndex = 68;
            this.BtnNewPreset.Text = "Create Preset";
            this.BtnNewPreset.UseVisualStyleBackColor = true;
            this.BtnNewPreset.Click += new System.EventHandler(this.BtnNewPreset_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(184, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 67;
            this.label11.Text = "mm";
            // 
            // BtnGoToPreset
            // 
            this.BtnGoToPreset.Location = new System.Drawing.Point(6, 55);
            this.BtnGoToPreset.Name = "BtnGoToPreset";
            this.BtnGoToPreset.Size = new System.Drawing.Size(201, 23);
            this.BtnGoToPreset.TabIndex = 62;
            this.BtnGoToPreset.Text = "Goto Selected Preset";
            this.BtnGoToPreset.UseVisualStyleBackColor = true;
            this.BtnGoToPreset.Click += new System.EventHandler(this.BtnGoToPreset_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.LightGreen;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 519);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(463, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 75;
            this.statusStrip1.Text = "Connected";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(65, 17);
            this.toolStripStatusLabel1.Text = "Connected";
            // 
            // NumAmpLimit
            // 
            this.NumAmpLimit.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumAmpLimit.Location = new System.Drawing.Point(100, 45);
            this.NumAmpLimit.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.NumAmpLimit.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumAmpLimit.Name = "NumAmpLimit";
            this.NumAmpLimit.Size = new System.Drawing.Size(72, 20);
            this.NumAmpLimit.TabIndex = 77;
            this.NumAmpLimit.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.NumAmpLimit.ValueChanged += new System.EventHandler(this.NumAmpLimit_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(178, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 13);
            this.label13.TabIndex = 76;
            this.label13.Text = "mA";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.NumAmpDownLimit);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.NumRelMove);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.NumAmpLimit);
            this.groupBox5.Location = new System.Drawing.Point(239, 234);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(213, 102);
            this.groupBox5.TabIndex = 78;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Settings";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 74);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 13);
            this.label16.TabIndex = 81;
            this.label16.Text = "Amp Limit (Down)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(178, 74);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(22, 13);
            this.label17.TabIndex = 79;
            this.label17.Text = "mA";
            // 
            // NumAmpDownLimit
            // 
            this.NumAmpDownLimit.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumAmpDownLimit.Location = new System.Drawing.Point(100, 71);
            this.NumAmpDownLimit.Maximum = new decimal(new int[] {
            380,
            0,
            0,
            0});
            this.NumAmpDownLimit.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumAmpDownLimit.Name = "NumAmpDownLimit";
            this.NumAmpDownLimit.Size = new System.Drawing.Size(72, 20);
            this.NumAmpDownLimit.TabIndex = 80;
            this.NumAmpDownLimit.Value = new decimal(new int[] {
            160,
            0,
            0,
            0});
            this.NumAmpDownLimit.ValueChanged += new System.EventHandler(this.NumAmpDownLimit_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 78;
            this.label14.Text = "Amp Limit (Up)";
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.HelpMenu,
            this.AboutMenu});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(463, 24);
            this.MenuStrip.TabIndex = 80;
            this.MenuStrip.Text = "Main Menu";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadPresetsToolStripMenuItem,
            this.savePresetsToolStripMenuItem});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(37, 20);
            this.FileMenu.Text = "File";
            // 
            // loadPresetsToolStripMenuItem
            // 
            this.loadPresetsToolStripMenuItem.Name = "loadPresetsToolStripMenuItem";
            this.loadPresetsToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.loadPresetsToolStripMenuItem.Text = "Load Preset";
            this.loadPresetsToolStripMenuItem.Click += new System.EventHandler(this.loadPresetsToolStripMenuItem_Click);
            // 
            // savePresetsToolStripMenuItem
            // 
            this.savePresetsToolStripMenuItem.Name = "savePresetsToolStripMenuItem";
            this.savePresetsToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.savePresetsToolStripMenuItem.Text = "Save Preset";
            this.savePresetsToolStripMenuItem.Click += new System.EventHandler(this.savePresetsToolStripMenuItem_Click);
            // 
            // HelpMenu
            // 
            this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.errorCodeDocToolStripMenuItem,
            this.additionalInfoToolStripMenuItem});
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(44, 20);
            this.HelpMenu.Text = "Help";
            // 
            // errorCodeDocToolStripMenuItem
            // 
            this.errorCodeDocToolStripMenuItem.Name = "errorCodeDocToolStripMenuItem";
            this.errorCodeDocToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.errorCodeDocToolStripMenuItem.Text = "Error Code Documentation";
            this.errorCodeDocToolStripMenuItem.Click += new System.EventHandler(this.errorCodeDocToolStripMenuItem_Click);
            // 
            // additionalInfoToolStripMenuItem
            // 
            this.additionalInfoToolStripMenuItem.Name = "additionalInfoToolStripMenuItem";
            this.additionalInfoToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.additionalInfoToolStripMenuItem.Text = "Additional Info";
            this.additionalInfoToolStripMenuItem.Click += new System.EventHandler(this.additionalInfoToolStripMenuItem_Click);
            // 
            // AboutMenu
            // 
            this.AboutMenu.Name = "AboutMenu";
            this.AboutMenu.Size = new System.Drawing.Size(52, 20);
            this.AboutMenu.Text = "About";
            this.AboutMenu.Click += new System.EventHandler(this.AboutMenu_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // InchLoop
            // 
            this.InchLoop.Interval = 500;
            this.InchLoop.Tick += new System.EventHandler(this.InchLoop_Tick);
            // 
            // JogLoop
            // 
            this.JogLoop.Interval = 400;
            this.JogLoop.Tick += new System.EventHandler(this.JogLoop_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 541);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Slide Controller";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumRelMove)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumAbsMove)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumAmpLimit)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumAmpDownLimit)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.Timer TextTimer;
        private System.Windows.Forms.ComboBox SerialPortsAvail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnServoOff;
        private System.Windows.Forms.Button BtnServoOn;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Button BtnInchDn;
        private System.Windows.Forms.Button BtnJogDn;
        private System.Windows.Forms.Button BtnJogUp;
        private System.Windows.Forms.Button BtnInchUp;
        private System.Windows.Forms.Button BtnAbsMove;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox TbCurAmps;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox TbCurSpeed;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox TbCurPos;
        private System.Windows.Forms.Button BtnResetAlarm;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CBPresets;
        internal System.Windows.Forms.TextBox TbPresetPos;
        private System.Windows.Forms.Button BtnAddPreset;
        private System.Windows.Forms.NumericUpDown NumRelMove;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnGoToPreset;
        internal System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnNewPreset;
        private System.Windows.Forms.Button BtnStop;
        internal System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BtnDelPreset;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox TbServoStatus;
        internal System.Windows.Forms.TextBox TbAlarmCode;
        internal System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown NumAmpLimit;
        internal System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox5;
        internal System.Windows.Forms.Label label14;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.ToolStripMenuItem AboutMenu;
        private System.Windows.Forms.ToolStripMenuItem errorCodeDocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem additionalInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem savePresetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadPresetsToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer InchLoop;
        internal System.Windows.Forms.Label label16;
        internal System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown NumAmpDownLimit;
        private System.Windows.Forms.NumericUpDown NumAbsMove;
        private System.Windows.Forms.Timer JogLoop;
    }
}

