namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cBoxCOMPORT = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbTCResult = new System.Windows.Forms.GroupBox();
            this.tbTCResult = new System.Windows.Forms.TextBox();
            this.gbServerLog = new System.Windows.Forms.GroupBox();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.btnMEFAuthS = new System.Windows.Forms.Button();
            this.gbLwM2MServer = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.tBResultCode = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnTCResultSave = new System.Windows.Forms.Button();
            this.gbOneM2MServer = new System.Windows.Forms.GroupBox();
            this.lbDirectRxData = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbmodemfwrver = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbdevicever = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnDeviceCheck = new System.Windows.Forms.Button();
            this.lbSvroneM2MData = new System.Windows.Forms.Label();
            this.lboneM2MRxData = new System.Windows.Forms.Label();
            this.btnDataRetrive = new System.Windows.Forms.Button();
            this.btnSendtoDeviceoneM2M = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.gbOneM2MDevice = new System.Windows.Forms.GroupBox();
            this.btReset = new System.Windows.Forms.Button();
            this.lbDirectTxData = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnoneM2MFullTest = new System.Windows.Forms.Button();
            this.btnoneM2MModuleVer = new System.Windows.Forms.Button();
            this.btnDelSubscript = new System.Windows.Forms.Button();
            this.lbSendedData = new System.Windows.Forms.Label();
            this.btnDelRxContainer = new System.Windows.Forms.Button();
            this.btnSetRxContainer = new System.Windows.Forms.Button();
            this.btnoneM2MDeviceVer = new System.Windows.Forms.Button();
            this.btnSetSubscript = new System.Windows.Forms.Button();
            this.btnMEFAuthD = new System.Windows.Forms.Button();
            this.btnDeviceUpdateCSR = new System.Windows.Forms.Button();
            this.lboneM2MRcvData = new System.Windows.Forms.Label();
            this.btnRcvDataOneM2M = new System.Windows.Forms.Button();
            this.btnDelContainer = new System.Windows.Forms.Button();
            this.btnSetContainer = new System.Windows.Forms.Button();
            this.btnDelDeviceCSR = new System.Windows.Forms.Button();
            this.btnCreateDeviceCSR = new System.Windows.Forms.Button();
            this.btnModemFOTA = new System.Windows.Forms.Button();
            this.btnDeviceFOTA = new System.Windows.Forms.Button();
            this.btnGetDeviceCSR = new System.Windows.Forms.Button();
            this.btnGetCSED = new System.Windows.Forms.Button();
            this.btnSendDataOneM2M = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.lbActionState = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cBoxATCMD = new System.Windows.Forms.ComboBox();
            this.btnATCMD = new System.Windows.Forms.Button();
            this.gbLwM2MDevice = new System.Windows.Forms.GroupBox();
            this.btnLwM2MFullTest = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.lbLwM2MRcvData = new System.Windows.Forms.Label();
            this.lbDevLwM2MData = new System.Windows.Forms.Label();
            this.btnLwM2MDisable = new System.Windows.Forms.Button();
            this.btnDeviceVerLwM2M = new System.Windows.Forms.Button();
            this.btnDeregister = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnBootstrap = new System.Windows.Forms.Button();
            this.btnSendData = new System.Windows.Forms.Button();
            this.gbModule = new System.Windows.Forms.GroupBox();
            this.lbDevEntityId = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbIccid = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbIMSI = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbModemVer = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbMaker = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbModel = new System.Windows.Forms.Label();
            this.lbModelName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnModuleInfo = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBoxDeviceVer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxDeviceSN = new System.Windows.Forms.TextBox();
            this.tbSvcCd = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tBoxDeviceModel = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.tbSvcSvrNum = new System.Windows.Forms.TextBox();
            this.tbSvcSvrCd = new System.Windows.Forms.TextBox();
            this.gbDeviceLog = new System.Windows.Forms.GroupBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.tBoxDataIN = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gbTCResult.SuspendLayout();
            this.gbServerLog.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.gbLwM2MServer.SuspendLayout();
            this.gbOneM2MServer.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.gbOneM2MDevice.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.gbLwM2MDevice.SuspendLayout();
            this.gbModule.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.gbDeviceLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // cBoxCOMPORT
            // 
            this.cBoxCOMPORT.FormattingEnabled = true;
            this.cBoxCOMPORT.Location = new System.Drawing.Point(19, 19);
            this.cBoxCOMPORT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxCOMPORT.Name = "cBoxCOMPORT";
            this.cBoxCOMPORT.Size = new System.Drawing.Size(73, 20);
            this.cBoxCOMPORT.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.progressBar1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.progressBar1.Location = new System.Drawing.Point(98, 21);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(36, 18);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Click += new System.EventHandler(this.ProgressBar1_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.ReadTimeout = 500;
            this.serialPort1.WriteTimeout = 500;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbTCResult);
            this.panel1.Controls.Add(this.gbServerLog);
            this.panel1.Controls.Add(this.groupBox11);
            this.panel1.Controls.Add(this.groupBox7);
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.gbDeviceLog);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1395, 709);
            this.panel1.TabIndex = 10;
            // 
            // gbTCResult
            // 
            this.gbTCResult.Controls.Add(this.tbTCResult);
            this.gbTCResult.Location = new System.Drawing.Point(475, 518);
            this.gbTCResult.Name = "gbTCResult";
            this.gbTCResult.Size = new System.Drawing.Size(472, 179);
            this.gbTCResult.TabIndex = 37;
            this.gbTCResult.TabStop = false;
            this.gbTCResult.Text = "TestCase Message";
            // 
            // tbTCResult
            // 
            this.tbTCResult.Location = new System.Drawing.Point(0, 25);
            this.tbTCResult.Multiline = true;
            this.tbTCResult.Name = "tbTCResult";
            this.tbTCResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbTCResult.Size = new System.Drawing.Size(466, 146);
            this.tbTCResult.TabIndex = 35;
            // 
            // gbServerLog
            // 
            this.gbServerLog.Controls.Add(this.tbLog);
            this.gbServerLog.Location = new System.Drawing.Point(475, 320);
            this.gbServerLog.Name = "gbServerLog";
            this.gbServerLog.Size = new System.Drawing.Size(472, 182);
            this.gbServerLog.TabIndex = 36;
            this.gbServerLog.TabStop = false;
            this.gbServerLog.Text = "Server Message";
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(0, 25);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLog.Size = new System.Drawing.Size(466, 146);
            this.tbLog.TabIndex = 35;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.btnMEFAuthS);
            this.groupBox11.Controls.Add(this.gbLwM2MServer);
            this.groupBox11.Controls.Add(this.gbOneM2MServer);
            this.groupBox11.Location = new System.Drawing.Point(953, 103);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(435, 594);
            this.groupBox11.TabIndex = 34;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "SERVER 동작";
            // 
            // btnMEFAuthS
            // 
            this.btnMEFAuthS.Location = new System.Drawing.Point(15, 20);
            this.btnMEFAuthS.Name = "btnMEFAuthS";
            this.btnMEFAuthS.Size = new System.Drawing.Size(112, 19);
            this.btnMEFAuthS.TabIndex = 0;
            this.btnMEFAuthS.Text = "MEF 인증";
            this.btnMEFAuthS.UseVisualStyleBackColor = true;
            this.btnMEFAuthS.Click += new System.EventHandler(this.btnMEFAuthS_Click);
            // 
            // gbLwM2MServer
            // 
            this.gbLwM2MServer.Controls.Add(this.button6);
            this.gbLwM2MServer.Controls.Add(this.button5);
            this.gbLwM2MServer.Controls.Add(this.tBResultCode);
            this.gbLwM2MServer.Controls.Add(this.button4);
            this.gbLwM2MServer.Controls.Add(this.label19);
            this.gbLwM2MServer.Controls.Add(this.label12);
            this.gbLwM2MServer.Controls.Add(this.textBox1);
            this.gbLwM2MServer.Controls.Add(this.listBox1);
            this.gbLwM2MServer.Controls.Add(this.btnTCResultSave);
            this.gbLwM2MServer.Location = new System.Drawing.Point(15, 217);
            this.gbLwM2MServer.Name = "gbLwM2MServer";
            this.gbLwM2MServer.Size = new System.Drawing.Size(414, 371);
            this.gbLwM2MServer.TabIndex = 33;
            this.gbLwM2MServer.TabStop = false;
            this.gbLwM2MServer.Text = "LwM2M Device DATA";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(261, 21);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(131, 19);
            this.button5.TabIndex = 54;
            this.button5.Text = "펌웨어 이력초기화";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tBResultCode
            // 
            this.tBResultCode.Location = new System.Drawing.Point(95, 150);
            this.tBResultCode.Name = "tBResultCode";
            this.tBResultCode.Size = new System.Drawing.Size(88, 21);
            this.tBResultCode.TabIndex = 53;
            this.tBResultCode.Text = "20000000";
            this.tBResultCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(192, 151);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 19);
            this.button4.TabIndex = 52;
            this.button4.Text = "코드조회";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 157);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 12);
            this.label19.TabIndex = 51;
            this.label19.Text = "ResultCode : ";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(298, 12);
            this.label12.TabIndex = 50;
            this.label12.Text = "Time        ID         Type       Result       ResultCode";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 175);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(401, 190);
            this.textBox1.TabIndex = 45;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(7, 58);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(401, 88);
            this.listBox1.TabIndex = 44;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnTCResultSave
            // 
            this.btnTCResultSave.Location = new System.Drawing.Point(7, 20);
            this.btnTCResultSave.Name = "btnTCResultSave";
            this.btnTCResultSave.Size = new System.Drawing.Size(121, 20);
            this.btnTCResultSave.TabIndex = 43;
            this.btnTCResultSave.Text = "서버 로그 검색";
            this.btnTCResultSave.UseVisualStyleBackColor = true;
            this.btnTCResultSave.Click += new System.EventHandler(this.btnTCResultSave_Click);
            // 
            // gbOneM2MServer
            // 
            this.gbOneM2MServer.Controls.Add(this.lbDirectRxData);
            this.gbOneM2MServer.Controls.Add(this.label13);
            this.gbOneM2MServer.Controls.Add(this.button3);
            this.gbOneM2MServer.Controls.Add(this.button2);
            this.gbOneM2MServer.Controls.Add(this.lbmodemfwrver);
            this.gbOneM2MServer.Controls.Add(this.label14);
            this.gbOneM2MServer.Controls.Add(this.lbdevicever);
            this.gbOneM2MServer.Controls.Add(this.label16);
            this.gbOneM2MServer.Controls.Add(this.btnDeviceCheck);
            this.gbOneM2MServer.Controls.Add(this.lbSvroneM2MData);
            this.gbOneM2MServer.Controls.Add(this.lboneM2MRxData);
            this.gbOneM2MServer.Controls.Add(this.btnDataRetrive);
            this.gbOneM2MServer.Controls.Add(this.btnSendtoDeviceoneM2M);
            this.gbOneM2MServer.Location = new System.Drawing.Point(13, 48);
            this.gbOneM2MServer.Name = "gbOneM2MServer";
            this.gbOneM2MServer.Size = new System.Drawing.Size(416, 163);
            this.gbOneM2MServer.TabIndex = 32;
            this.gbOneM2MServer.TabStop = false;
            this.gbOneM2MServer.Text = "Device Information";
            // 
            // lbDirectRxData
            // 
            this.lbDirectRxData.Location = new System.Drawing.Point(147, 82);
            this.lbDirectRxData.Name = "lbDirectRxData";
            this.lbDirectRxData.Size = new System.Drawing.Size(242, 22);
            this.lbDirectRxData.TabIndex = 50;
            this.lbDirectRxData.Text = "No received data";
            this.lbDirectRxData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(149, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 12);
            this.label13.TabIndex = 49;
            this.label13.Text = "No data";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 137);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 23);
            this.button3.TabIndex = 48;
            this.button3.Text = "데이터 전송(단말)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 47;
            this.button2.Text = "데이터 확인 (단말)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbmodemfwrver
            // 
            this.lbmodemfwrver.Location = new System.Drawing.Point(204, 33);
            this.lbmodemfwrver.Name = "lbmodemfwrver";
            this.lbmodemfwrver.Size = new System.Drawing.Size(164, 16);
            this.lbmodemfwrver.TabIndex = 43;
            this.lbmodemfwrver.Text = ".";
            this.lbmodemfwrver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(144, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 17);
            this.label14.TabIndex = 44;
            this.label14.Text = "modem =";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbdevicever
            // 
            this.lbdevicever.Location = new System.Drawing.Point(204, 16);
            this.lbdevicever.Name = "lbdevicever";
            this.lbdevicever.Size = new System.Drawing.Size(164, 16);
            this.lbdevicever.TabIndex = 45;
            this.lbdevicever.Text = ".";
            this.lbdevicever.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(141, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 16);
            this.label16.TabIndex = 46;
            this.label16.Text = "device =";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDeviceCheck
            // 
            this.btnDeviceCheck.Location = new System.Drawing.Point(9, 16);
            this.btnDeviceCheck.Name = "btnDeviceCheck";
            this.btnDeviceCheck.Size = new System.Drawing.Size(116, 32);
            this.btnDeviceCheck.TabIndex = 40;
            this.btnDeviceCheck.Text = "펌웨어 버전";
            this.btnDeviceCheck.UseVisualStyleBackColor = true;
            this.btnDeviceCheck.Click += new System.EventHandler(this.btnDeviceCheck_Click);
            // 
            // lbSvroneM2MData
            // 
            this.lbSvroneM2MData.AutoSize = true;
            this.lbSvroneM2MData.Location = new System.Drawing.Point(149, 116);
            this.lbSvroneM2MData.Name = "lbSvroneM2MData";
            this.lbSvroneM2MData.Size = new System.Drawing.Size(49, 12);
            this.lbSvroneM2MData.TabIndex = 39;
            this.lbSvroneM2MData.Text = "No data";
            this.lbSvroneM2MData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lboneM2MRxData
            // 
            this.lboneM2MRxData.Location = new System.Drawing.Point(149, 55);
            this.lboneM2MRxData.Name = "lboneM2MRxData";
            this.lboneM2MRxData.Size = new System.Drawing.Size(242, 22);
            this.lboneM2MRxData.TabIndex = 16;
            this.lboneM2MRxData.Text = "No received data";
            this.lboneM2MRxData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDataRetrive
            // 
            this.btnDataRetrive.Location = new System.Drawing.Point(9, 54);
            this.btnDataRetrive.Name = "btnDataRetrive";
            this.btnDataRetrive.Size = new System.Drawing.Size(116, 23);
            this.btnDataRetrive.TabIndex = 14;
            this.btnDataRetrive.Text = "데이터 확인 (DB)";
            this.btnDataRetrive.UseVisualStyleBackColor = true;
            this.btnDataRetrive.Click += new System.EventHandler(this.btnDataRetrive_Click);
            // 
            // btnSendtoDeviceoneM2M
            // 
            this.btnSendtoDeviceoneM2M.Location = new System.Drawing.Point(9, 110);
            this.btnSendtoDeviceoneM2M.Name = "btnSendtoDeviceoneM2M";
            this.btnSendtoDeviceoneM2M.Size = new System.Drawing.Size(116, 23);
            this.btnSendtoDeviceoneM2M.TabIndex = 3;
            this.btnSendtoDeviceoneM2M.Text = "데이터 전송(DB)";
            this.btnSendtoDeviceoneM2M.UseVisualStyleBackColor = true;
            this.btnSendtoDeviceoneM2M.Click += new System.EventHandler(this.btnSendtoDeviceoneM2M_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.gbOneM2MDevice);
            this.groupBox7.Controls.Add(this.groupBox5);
            this.groupBox7.Controls.Add(this.gbLwM2MDevice);
            this.groupBox7.Controls.Add(this.gbModule);
            this.groupBox7.Location = new System.Drawing.Point(28, 94);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(438, 603);
            this.groupBox7.TabIndex = 16;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "DEVICE 동작";
            // 
            // gbOneM2MDevice
            // 
            this.gbOneM2MDevice.Controls.Add(this.btReset);
            this.gbOneM2MDevice.Controls.Add(this.lbDirectTxData);
            this.gbOneM2MDevice.Controls.Add(this.button1);
            this.gbOneM2MDevice.Controls.Add(this.btnoneM2MFullTest);
            this.gbOneM2MDevice.Controls.Add(this.btnoneM2MModuleVer);
            this.gbOneM2MDevice.Controls.Add(this.btnDelSubscript);
            this.gbOneM2MDevice.Controls.Add(this.lbSendedData);
            this.gbOneM2MDevice.Controls.Add(this.btnDelRxContainer);
            this.gbOneM2MDevice.Controls.Add(this.btnSetRxContainer);
            this.gbOneM2MDevice.Controls.Add(this.btnoneM2MDeviceVer);
            this.gbOneM2MDevice.Controls.Add(this.btnSetSubscript);
            this.gbOneM2MDevice.Controls.Add(this.btnMEFAuthD);
            this.gbOneM2MDevice.Controls.Add(this.btnDeviceUpdateCSR);
            this.gbOneM2MDevice.Controls.Add(this.lboneM2MRcvData);
            this.gbOneM2MDevice.Controls.Add(this.btnRcvDataOneM2M);
            this.gbOneM2MDevice.Controls.Add(this.btnDelContainer);
            this.gbOneM2MDevice.Controls.Add(this.btnSetContainer);
            this.gbOneM2MDevice.Controls.Add(this.btnDelDeviceCSR);
            this.gbOneM2MDevice.Controls.Add(this.btnCreateDeviceCSR);
            this.gbOneM2MDevice.Controls.Add(this.btnModemFOTA);
            this.gbOneM2MDevice.Controls.Add(this.btnDeviceFOTA);
            this.gbOneM2MDevice.Controls.Add(this.btnGetDeviceCSR);
            this.gbOneM2MDevice.Controls.Add(this.btnGetCSED);
            this.gbOneM2MDevice.Controls.Add(this.btnSendDataOneM2M);
            this.gbOneM2MDevice.Enabled = false;
            this.gbOneM2MDevice.Location = new System.Drawing.Point(14, 205);
            this.gbOneM2MDevice.Name = "gbOneM2MDevice";
            this.gbOneM2MDevice.Size = new System.Drawing.Size(413, 249);
            this.gbOneM2MDevice.TabIndex = 25;
            this.gbOneM2MDevice.TabStop = false;
            this.gbOneM2MDevice.Text = "oneM2M";
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(333, 206);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(65, 35);
            this.btReset.TabIndex = 44;
            this.btReset.Text = "RESET 보고";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // lbDirectTxData
            // 
            this.lbDirectTxData.AutoSize = true;
            this.lbDirectTxData.Location = new System.Drawing.Point(150, 188);
            this.lbDirectTxData.Name = "lbDirectTxData";
            this.lbDirectTxData.Size = new System.Drawing.Size(49, 12);
            this.lbDirectTxData.TabIndex = 43;
            this.lbDirectTxData.Text = "No data";
            this.lbDirectTxData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 20);
            this.button1.TabIndex = 42;
            this.button1.Text = "데이터전송 (서버)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnoneM2MFullTest
            // 
            this.btnoneM2MFullTest.Location = new System.Drawing.Point(335, 137);
            this.btnoneM2MFullTest.Name = "btnoneM2MFullTest";
            this.btnoneM2MFullTest.Size = new System.Drawing.Size(63, 20);
            this.btnoneM2MFullTest.TabIndex = 41;
            this.btnoneM2MFullTest.Text = "TC전체";
            this.btnoneM2MFullTest.UseVisualStyleBackColor = true;
            this.btnoneM2MFullTest.Click += new System.EventHandler(this.btnoneM2MFullTest_Click);
            // 
            // btnoneM2MModuleVer
            // 
            this.btnoneM2MModuleVer.Font = new System.Drawing.Font("굴림", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnoneM2MModuleVer.Location = new System.Drawing.Point(173, 208);
            this.btnoneM2MModuleVer.Name = "btnoneM2MModuleVer";
            this.btnoneM2MModuleVer.Size = new System.Drawing.Size(73, 35);
            this.btnoneM2MModuleVer.TabIndex = 40;
            this.btnoneM2MModuleVer.Text = "ModemFW 보고";
            this.btnoneM2MModuleVer.UseVisualStyleBackColor = true;
            this.btnoneM2MModuleVer.Click += new System.EventHandler(this.btnoneM2MModuleVer_Click);
            // 
            // btnDelSubscript
            // 
            this.btnDelSubscript.Location = new System.Drawing.Point(323, 77);
            this.btnDelSubscript.Name = "btnDelSubscript";
            this.btnDelSubscript.Size = new System.Drawing.Size(75, 20);
            this.btnDelSubscript.TabIndex = 39;
            this.btnDelSubscript.Text = "구독삭제";
            this.btnDelSubscript.UseVisualStyleBackColor = true;
            this.btnDelSubscript.Click += new System.EventHandler(this.btnDelSubscript_Click);
            // 
            // lbSendedData
            // 
            this.lbSendedData.AutoSize = true;
            this.lbSendedData.Location = new System.Drawing.Point(150, 167);
            this.lbSendedData.Name = "lbSendedData";
            this.lbSendedData.Size = new System.Drawing.Size(49, 12);
            this.lbSendedData.TabIndex = 38;
            this.lbSendedData.Text = "No data";
            this.lbSendedData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDelRxContainer
            // 
            this.btnDelRxContainer.Location = new System.Drawing.Point(120, 77);
            this.btnDelRxContainer.Name = "btnDelRxContainer";
            this.btnDelRxContainer.Size = new System.Drawing.Size(88, 20);
            this.btnDelRxContainer.TabIndex = 37;
            this.btnDelRxContainer.Text = "수신폴더삭제";
            this.btnDelRxContainer.UseVisualStyleBackColor = true;
            this.btnDelRxContainer.Click += new System.EventHandler(this.btnDelRxContainer_Click);
            // 
            // btnSetRxContainer
            // 
            this.btnSetRxContainer.Location = new System.Drawing.Point(13, 77);
            this.btnSetRxContainer.Name = "btnSetRxContainer";
            this.btnSetRxContainer.Size = new System.Drawing.Size(92, 20);
            this.btnSetRxContainer.TabIndex = 36;
            this.btnSetRxContainer.Text = "수신폴더생성";
            this.btnSetRxContainer.UseVisualStyleBackColor = true;
            this.btnSetRxContainer.Click += new System.EventHandler(this.btnSetRxContainer_Click);
            // 
            // btnoneM2MDeviceVer
            // 
            this.btnoneM2MDeviceVer.Font = new System.Drawing.Font("굴림", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnoneM2MDeviceVer.Location = new System.Drawing.Point(12, 208);
            this.btnoneM2MDeviceVer.Name = "btnoneM2MDeviceVer";
            this.btnoneM2MDeviceVer.Size = new System.Drawing.Size(79, 35);
            this.btnoneM2MDeviceVer.TabIndex = 35;
            this.btnoneM2MDeviceVer.Text = "DeviceFW 보고";
            this.btnoneM2MDeviceVer.UseVisualStyleBackColor = true;
            this.btnoneM2MDeviceVer.Click += new System.EventHandler(this.btnoneM2MDeviceVer_Click);
            // 
            // btnSetSubscript
            // 
            this.btnSetSubscript.Location = new System.Drawing.Point(231, 77);
            this.btnSetSubscript.Name = "btnSetSubscript";
            this.btnSetSubscript.Size = new System.Drawing.Size(75, 20);
            this.btnSetSubscript.TabIndex = 34;
            this.btnSetSubscript.Text = "구독신청";
            this.btnSetSubscript.UseVisualStyleBackColor = true;
            this.btnSetSubscript.Click += new System.EventHandler(this.btnSetSubscript_Click);
            // 
            // btnMEFAuthD
            // 
            this.btnMEFAuthD.Location = new System.Drawing.Point(13, 25);
            this.btnMEFAuthD.Name = "btnMEFAuthD";
            this.btnMEFAuthD.Size = new System.Drawing.Size(121, 20);
            this.btnMEFAuthD.TabIndex = 33;
            this.btnMEFAuthD.Text = "MEF 인증";
            this.btnMEFAuthD.UseVisualStyleBackColor = true;
            this.btnMEFAuthD.Click += new System.EventHandler(this.btnMEFAuthD_Click);
            // 
            // btnDeviceUpdateCSR
            // 
            this.btnDeviceUpdateCSR.Location = new System.Drawing.Point(281, 25);
            this.btnDeviceUpdateCSR.Name = "btnDeviceUpdateCSR";
            this.btnDeviceUpdateCSR.Size = new System.Drawing.Size(119, 20);
            this.btnDeviceUpdateCSR.TabIndex = 32;
            this.btnDeviceUpdateCSR.Text = "CSR 수정";
            this.btnDeviceUpdateCSR.UseVisualStyleBackColor = true;
            this.btnDeviceUpdateCSR.Click += new System.EventHandler(this.btnDeviceUpdateCSR_Click);
            // 
            // lboneM2MRcvData
            // 
            this.lboneM2MRcvData.AutoSize = true;
            this.lboneM2MRcvData.Location = new System.Drawing.Point(146, 111);
            this.lboneM2MRcvData.Name = "lboneM2MRcvData";
            this.lboneM2MRcvData.Size = new System.Drawing.Size(101, 12);
            this.lboneM2MRcvData.TabIndex = 31;
            this.lboneM2MRcvData.Text = "No received data";
            this.lboneM2MRcvData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnRcvDataOneM2M
            // 
            this.btnRcvDataOneM2M.Location = new System.Drawing.Point(13, 107);
            this.btnRcvDataOneM2M.Name = "btnRcvDataOneM2M";
            this.btnRcvDataOneM2M.Size = new System.Drawing.Size(121, 20);
            this.btnRcvDataOneM2M.TabIndex = 30;
            this.btnRcvDataOneM2M.Text = "데이터 수신";
            this.btnRcvDataOneM2M.UseVisualStyleBackColor = true;
            this.btnRcvDataOneM2M.Click += new System.EventHandler(this.btnRcvDataOneM2M_Click);
            // 
            // btnDelContainer
            // 
            this.btnDelContainer.Location = new System.Drawing.Point(138, 137);
            this.btnDelContainer.Name = "btnDelContainer";
            this.btnDelContainer.Size = new System.Drawing.Size(137, 20);
            this.btnDelContainer.TabIndex = 29;
            this.btnDelContainer.Text = "송신폴더삭제";
            this.btnDelContainer.UseVisualStyleBackColor = true;
            this.btnDelContainer.Click += new System.EventHandler(this.btnDelContainer_Click);
            // 
            // btnSetContainer
            // 
            this.btnSetContainer.Location = new System.Drawing.Point(13, 137);
            this.btnSetContainer.Name = "btnSetContainer";
            this.btnSetContainer.Size = new System.Drawing.Size(121, 20);
            this.btnSetContainer.TabIndex = 27;
            this.btnSetContainer.Text = "송신폴더생성";
            this.btnSetContainer.UseVisualStyleBackColor = true;
            this.btnSetContainer.Click += new System.EventHandler(this.btnSetContainer_Click);
            // 
            // btnDelDeviceCSR
            // 
            this.btnDelDeviceCSR.Location = new System.Drawing.Point(281, 50);
            this.btnDelDeviceCSR.Name = "btnDelDeviceCSR";
            this.btnDelDeviceCSR.Size = new System.Drawing.Size(119, 20);
            this.btnDelDeviceCSR.TabIndex = 26;
            this.btnDelDeviceCSR.Text = "CSR 삭제";
            this.btnDelDeviceCSR.UseVisualStyleBackColor = true;
            this.btnDelDeviceCSR.Click += new System.EventHandler(this.btnDelDeviceCSR_Click);
            // 
            // btnCreateDeviceCSR
            // 
            this.btnCreateDeviceCSR.Location = new System.Drawing.Point(140, 51);
            this.btnCreateDeviceCSR.Name = "btnCreateDeviceCSR";
            this.btnCreateDeviceCSR.Size = new System.Drawing.Size(135, 20);
            this.btnCreateDeviceCSR.TabIndex = 25;
            this.btnCreateDeviceCSR.Text = "CSR 생성";
            this.btnCreateDeviceCSR.UseVisualStyleBackColor = true;
            this.btnCreateDeviceCSR.Click += new System.EventHandler(this.btnCreateDeviceCSR_Click);
            // 
            // btnModemFOTA
            // 
            this.btnModemFOTA.Location = new System.Drawing.Point(253, 208);
            this.btnModemFOTA.Name = "btnModemFOTA";
            this.btnModemFOTA.Size = new System.Drawing.Size(76, 35);
            this.btnModemFOTA.TabIndex = 24;
            this.btnModemFOTA.Text = "ModemFW 조회";
            this.btnModemFOTA.UseVisualStyleBackColor = true;
            this.btnModemFOTA.Click += new System.EventHandler(this.btnModemFOTA_Click);
            // 
            // btnDeviceFOTA
            // 
            this.btnDeviceFOTA.Font = new System.Drawing.Font("굴림", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDeviceFOTA.Location = new System.Drawing.Point(96, 208);
            this.btnDeviceFOTA.Name = "btnDeviceFOTA";
            this.btnDeviceFOTA.Size = new System.Drawing.Size(70, 35);
            this.btnDeviceFOTA.TabIndex = 23;
            this.btnDeviceFOTA.Text = "DeviceFW 조회";
            this.btnDeviceFOTA.UseVisualStyleBackColor = true;
            this.btnDeviceFOTA.Click += new System.EventHandler(this.btnDeviceFOTA_Click);
            // 
            // btnGetDeviceCSR
            // 
            this.btnGetDeviceCSR.Location = new System.Drawing.Point(13, 51);
            this.btnGetDeviceCSR.Name = "btnGetDeviceCSR";
            this.btnGetDeviceCSR.Size = new System.Drawing.Size(121, 20);
            this.btnGetDeviceCSR.TabIndex = 22;
            this.btnGetDeviceCSR.Text = "CSR 조회";
            this.btnGetDeviceCSR.UseVisualStyleBackColor = true;
            this.btnGetDeviceCSR.Click += new System.EventHandler(this.btnGetDeviceCSR_Click);
            // 
            // btnGetCSED
            // 
            this.btnGetCSED.Location = new System.Drawing.Point(140, 25);
            this.btnGetCSED.Name = "btnGetCSED";
            this.btnGetCSED.Size = new System.Drawing.Size(135, 20);
            this.btnGetCSED.TabIndex = 21;
            this.btnGetCSED.Text = "CSEBase 조회";
            this.btnGetCSED.UseVisualStyleBackColor = true;
            this.btnGetCSED.Click += new System.EventHandler(this.btnGetCSED_Click);
            // 
            // btnSendDataOneM2M
            // 
            this.btnSendDataOneM2M.Location = new System.Drawing.Point(13, 163);
            this.btnSendDataOneM2M.Name = "btnSendDataOneM2M";
            this.btnSendDataOneM2M.Size = new System.Drawing.Size(121, 20);
            this.btnSendDataOneM2M.TabIndex = 19;
            this.btnSendDataOneM2M.Text = "데이터전송 (DB)";
            this.btnSendDataOneM2M.UseVisualStyleBackColor = true;
            this.btnSendDataOneM2M.Click += new System.EventHandler(this.btnSendDataOneM2M_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.progressBar2);
            this.groupBox5.Controls.Add(this.groupBox10);
            this.groupBox5.Controls.Add(this.lbActionState);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.cBoxCOMPORT);
            this.groupBox5.Controls.Add(this.cBoxATCMD);
            this.groupBox5.Controls.Add(this.btnATCMD);
            this.groupBox5.Controls.Add(this.progressBar1);
            this.groupBox5.Location = new System.Drawing.Point(14, 20);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(413, 75);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "COM 포트";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(138, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 37;
            this.label15.Text = "9600";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(94, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 36;
            this.label10.Text = "115200";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.progressBar2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.progressBar2.Location = new System.Drawing.Point(142, 22);
            this.progressBar2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(36, 18);
            this.progressBar2.TabIndex = 35;
            this.progressBar2.Click += new System.EventHandler(this.progressBar2_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Location = new System.Drawing.Point(237, 75);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(786, 588);
            this.groupBox10.TabIndex = 34;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "groupBox10";
            // 
            // lbActionState
            // 
            this.lbActionState.AutoSize = true;
            this.lbActionState.Location = new System.Drawing.Point(300, 22);
            this.lbActionState.Name = "lbActionState";
            this.lbActionState.Size = new System.Drawing.Size(43, 12);
            this.lbActionState.TabIndex = 26;
            this.lbActionState.Text = "closed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 12);
            this.label6.TabIndex = 24;
            this.label6.Text = "동작상태 :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cBoxATCMD
            // 
            this.cBoxATCMD.FormattingEnabled = true;
            this.cBoxATCMD.Location = new System.Drawing.Point(17, 43);
            this.cBoxATCMD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxATCMD.Name = "cBoxATCMD";
            this.cBoxATCMD.Size = new System.Drawing.Size(245, 20);
            this.cBoxATCMD.TabIndex = 18;
            this.cBoxATCMD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CBoxATCMD_KeyDown);
            // 
            // btnATCMD
            // 
            this.btnATCMD.Location = new System.Drawing.Point(268, 42);
            this.btnATCMD.Name = "btnATCMD";
            this.btnATCMD.Size = new System.Drawing.Size(75, 20);
            this.btnATCMD.TabIndex = 17;
            this.btnATCMD.Text = "AT명령";
            this.btnATCMD.UseVisualStyleBackColor = true;
            this.btnATCMD.Click += new System.EventHandler(this.btnATCMD_Click);
            // 
            // gbLwM2MDevice
            // 
            this.gbLwM2MDevice.Controls.Add(this.btnLwM2MFullTest);
            this.gbLwM2MDevice.Controls.Add(this.label17);
            this.gbLwM2MDevice.Controls.Add(this.lbLwM2MRcvData);
            this.gbLwM2MDevice.Controls.Add(this.lbDevLwM2MData);
            this.gbLwM2MDevice.Controls.Add(this.btnLwM2MDisable);
            this.gbLwM2MDevice.Controls.Add(this.btnDeviceVerLwM2M);
            this.gbLwM2MDevice.Controls.Add(this.btnDeregister);
            this.gbLwM2MDevice.Controls.Add(this.btnRegister);
            this.gbLwM2MDevice.Controls.Add(this.btnBootstrap);
            this.gbLwM2MDevice.Controls.Add(this.btnSendData);
            this.gbLwM2MDevice.Enabled = false;
            this.gbLwM2MDevice.Location = new System.Drawing.Point(14, 460);
            this.gbLwM2MDevice.Name = "gbLwM2MDevice";
            this.gbLwM2MDevice.Size = new System.Drawing.Size(413, 135);
            this.gbLwM2MDevice.TabIndex = 15;
            this.gbLwM2MDevice.TabStop = false;
            this.gbLwM2MDevice.Text = "LwM2M";
            // 
            // btnLwM2MFullTest
            // 
            this.btnLwM2MFullTest.Location = new System.Drawing.Point(335, 103);
            this.btnLwM2MFullTest.Name = "btnLwM2MFullTest";
            this.btnLwM2MFullTest.Size = new System.Drawing.Size(63, 20);
            this.btnLwM2MFullTest.TabIndex = 42;
            this.btnLwM2MFullTest.Text = "TC전체";
            this.btnLwM2MFullTest.UseVisualStyleBackColor = true;
            this.btnLwM2MFullTest.Click += new System.EventHandler(this.btnLwM2MFullTest_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(39, 61);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 12);
            this.label17.TabIndex = 41;
            this.label17.Text = "데이터 수신 : ";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbLwM2MRcvData
            // 
            this.lbLwM2MRcvData.AutoSize = true;
            this.lbLwM2MRcvData.Location = new System.Drawing.Point(146, 61);
            this.lbLwM2MRcvData.Name = "lbLwM2MRcvData";
            this.lbLwM2MRcvData.Size = new System.Drawing.Size(101, 12);
            this.lbLwM2MRcvData.TabIndex = 40;
            this.lbLwM2MRcvData.Text = "No received data";
            this.lbLwM2MRcvData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbDevLwM2MData
            // 
            this.lbDevLwM2MData.AutoSize = true;
            this.lbDevLwM2MData.Location = new System.Drawing.Point(150, 83);
            this.lbDevLwM2MData.Name = "lbDevLwM2MData";
            this.lbDevLwM2MData.Size = new System.Drawing.Size(49, 12);
            this.lbDevLwM2MData.TabIndex = 39;
            this.lbDevLwM2MData.Text = "No data";
            this.lbDevLwM2MData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLwM2MDisable
            // 
            this.btnLwM2MDisable.Location = new System.Drawing.Point(148, 103);
            this.btnLwM2MDisable.Name = "btnLwM2MDisable";
            this.btnLwM2MDisable.Size = new System.Drawing.Size(127, 20);
            this.btnLwM2MDisable.TabIndex = 25;
            this.btnLwM2MDisable.Text = "LwM2M해제";
            this.btnLwM2MDisable.UseVisualStyleBackColor = true;
            this.btnLwM2MDisable.Click += new System.EventHandler(this.btnLwM2MDisable_Click);
            // 
            // btnDeviceVerLwM2M
            // 
            this.btnDeviceVerLwM2M.Location = new System.Drawing.Point(281, 30);
            this.btnDeviceVerLwM2M.Name = "btnDeviceVerLwM2M";
            this.btnDeviceVerLwM2M.Size = new System.Drawing.Size(119, 20);
            this.btnDeviceVerLwM2M.TabIndex = 24;
            this.btnDeviceVerLwM2M.Text = "DEVICE 버전 보고";
            this.btnDeviceVerLwM2M.UseVisualStyleBackColor = true;
            this.btnDeviceVerLwM2M.Click += new System.EventHandler(this.btnDeviceVerLwM2M_Click);
            // 
            // btnDeregister
            // 
            this.btnDeregister.Location = new System.Drawing.Point(13, 103);
            this.btnDeregister.Name = "btnDeregister";
            this.btnDeregister.Size = new System.Drawing.Size(127, 20);
            this.btnDeregister.TabIndex = 23;
            this.btnDeregister.Text = "DEREGISTER";
            this.btnDeregister.UseVisualStyleBackColor = true;
            this.btnDeregister.Click += new System.EventHandler(this.btnDeregister_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(148, 30);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(127, 20);
            this.btnRegister.TabIndex = 22;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnBootstrap
            // 
            this.btnBootstrap.Location = new System.Drawing.Point(13, 30);
            this.btnBootstrap.Name = "btnBootstrap";
            this.btnBootstrap.Size = new System.Drawing.Size(127, 20);
            this.btnBootstrap.TabIndex = 21;
            this.btnBootstrap.Text = "BOOTSTRAP";
            this.btnBootstrap.UseVisualStyleBackColor = true;
            this.btnBootstrap.Click += new System.EventHandler(this.btnBootstrap_Click);
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(13, 77);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(127, 20);
            this.btnSendData.TabIndex = 19;
            this.btnSendData.Text = "데이터전송";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // gbModule
            // 
            this.gbModule.Controls.Add(this.lbDevEntityId);
            this.gbModule.Controls.Add(this.label18);
            this.gbModule.Controls.Add(this.lbIccid);
            this.gbModule.Controls.Add(this.label11);
            this.gbModule.Controls.Add(this.lbIMSI);
            this.gbModule.Controls.Add(this.label9);
            this.gbModule.Controls.Add(this.lbModemVer);
            this.gbModule.Controls.Add(this.label8);
            this.gbModule.Controls.Add(this.lbMaker);
            this.gbModule.Controls.Add(this.label7);
            this.gbModule.Controls.Add(this.lbModel);
            this.gbModule.Controls.Add(this.lbModelName);
            this.gbModule.Controls.Add(this.label5);
            this.gbModule.Controls.Add(this.btnModuleInfo);
            this.gbModule.Enabled = false;
            this.gbModule.Location = new System.Drawing.Point(14, 100);
            this.gbModule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbModule.Name = "gbModule";
            this.gbModule.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbModule.Size = new System.Drawing.Size(413, 100);
            this.gbModule.TabIndex = 11;
            this.gbModule.TabStop = false;
            this.gbModule.Text = "모듈 정보";
            // 
            // lbDevEntityId
            // 
            this.lbDevEntityId.Location = new System.Drawing.Point(130, 81);
            this.lbDevEntityId.Name = "lbDevEntityId";
            this.lbDevEntityId.Size = new System.Drawing.Size(189, 16);
            this.lbDevEntityId.TabIndex = 35;
            this.lbDevEntityId.Text = "dev.entityId";
            this.lbDevEntityId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(49, 82);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 16);
            this.label18.TabIndex = 34;
            this.label18.Text = "entityId =";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbIccid
            // 
            this.lbIccid.AutoSize = true;
            this.lbIccid.Location = new System.Drawing.Point(267, 67);
            this.lbIccid.Name = "lbIccid";
            this.lbIccid.Size = new System.Drawing.Size(9, 12);
            this.lbIccid.TabIndex = 33;
            this.lbIccid.Text = ".";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(219, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 12);
            this.label11.TabIndex = 32;
            this.label11.Text = "ICCID :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbIMSI
            // 
            this.lbIMSI.AutoSize = true;
            this.lbIMSI.Location = new System.Drawing.Point(114, 67);
            this.lbIMSI.Name = "lbIMSI";
            this.lbIMSI.Size = new System.Drawing.Size(9, 12);
            this.lbIMSI.TabIndex = 31;
            this.lbIMSI.Text = ".";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 12);
            this.label9.TabIndex = 30;
            this.label9.Text = "CTN :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbModemVer
            // 
            this.lbModemVer.AutoSize = true;
            this.lbModemVer.Location = new System.Drawing.Point(267, 44);
            this.lbModemVer.Name = "lbModemVer";
            this.lbModemVer.Size = new System.Drawing.Size(9, 12);
            this.lbModemVer.TabIndex = 29;
            this.lbModemVer.Text = ".";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(203, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 12);
            this.label8.TabIndex = 28;
            this.label8.Text = "모듈버전 :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbMaker
            // 
            this.lbMaker.AutoSize = true;
            this.lbMaker.Location = new System.Drawing.Point(124, 23);
            this.lbMaker.Name = "lbMaker";
            this.lbMaker.Size = new System.Drawing.Size(9, 12);
            this.lbMaker.TabIndex = 27;
            this.lbMaker.Text = ".";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 12);
            this.label7.TabIndex = 26;
            this.label7.Text = "제조사 :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbModel
            // 
            this.lbModel.AutoSize = true;
            this.lbModel.Location = new System.Drawing.Point(124, 42);
            this.lbModel.Name = "lbModel";
            this.lbModel.Size = new System.Drawing.Size(9, 12);
            this.lbModel.TabIndex = 25;
            this.lbModel.Text = ".";
            // 
            // lbModelName
            // 
            this.lbModelName.AutoSize = true;
            this.lbModelName.Location = new System.Drawing.Point(176, 25);
            this.lbModelName.Name = "lbModelName";
            this.lbModelName.Size = new System.Drawing.Size(0, 12);
            this.lbModelName.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 12);
            this.label5.TabIndex = 23;
            this.label5.Text = "모델명 :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnModuleInfo
            // 
            this.btnModuleInfo.Location = new System.Drawing.Point(17, 26);
            this.btnModuleInfo.Name = "btnModuleInfo";
            this.btnModuleInfo.Size = new System.Drawing.Size(49, 49);
            this.btnModuleInfo.TabIndex = 16;
            this.btnModuleInfo.Text = "조회";
            this.btnModuleInfo.UseVisualStyleBackColor = true;
            this.btnModuleInfo.Click += new System.EventHandler(this.btnModuleInfo_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.tBoxDeviceVer);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.tBoxDeviceSN);
            this.groupBox6.Controls.Add(this.tbSvcCd);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Controls.Add(this.tBoxDeviceModel);
            this.groupBox6.Controls.Add(this.label28);
            this.groupBox6.Controls.Add(this.tbSvcSvrNum);
            this.groupBox6.Controls.Add(this.tbSvcSvrCd);
            this.groupBox6.Location = new System.Drawing.Point(28, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1360, 64);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "프로젝트";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(747, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 26;
            this.label4.Text = "디바이스 버전 :";
            // 
            // tBoxDeviceVer
            // 
            this.tBoxDeviceVer.Location = new System.Drawing.Point(842, 19);
            this.tBoxDeviceVer.Name = "tBoxDeviceVer";
            this.tBoxDeviceVer.Size = new System.Drawing.Size(126, 21);
            this.tBoxDeviceVer.TabIndex = 25;
            this.tBoxDeviceVer.Text = "1.0.0";
            this.tBoxDeviceVer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(494, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 12);
            this.label3.TabIndex = 24;
            this.label3.Text = "디바이스 일련번호 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 22;
            this.label2.Text = "디바이스 모델명 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "서비스 코드 :";
            // 
            // tBoxDeviceSN
            // 
            this.tBoxDeviceSN.Location = new System.Drawing.Point(610, 20);
            this.tBoxDeviceSN.Name = "tBoxDeviceSN";
            this.tBoxDeviceSN.Size = new System.Drawing.Size(126, 21);
            this.tBoxDeviceSN.TabIndex = 23;
            this.tBoxDeviceSN.Text = "123456";
            this.tBoxDeviceSN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSvcCd
            // 
            this.tbSvcCd.Location = new System.Drawing.Point(96, 20);
            this.tbSvcCd.Name = "tbSvcCd";
            this.tbSvcCd.Size = new System.Drawing.Size(126, 21);
            this.tbSvcCd.TabIndex = 17;
            this.tbSvcCd.Text = "CATM";
            this.tbSvcCd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSvcCd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSvcCd_KeyDown);
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(979, 23);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(86, 16);
            this.label23.TabIndex = 6;
            this.label23.Text = "서버 SEQ :";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tBoxDeviceModel
            // 
            this.tBoxDeviceModel.Location = new System.Drawing.Point(351, 18);
            this.tBoxDeviceModel.Name = "tBoxDeviceModel";
            this.tBoxDeviceModel.Size = new System.Drawing.Size(126, 21);
            this.tBoxDeviceModel.TabIndex = 21;
            this.tBoxDeviceModel.Text = "LWEMG";
            this.tBoxDeviceModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label28
            // 
            this.label28.Location = new System.Drawing.Point(1177, 22);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(86, 16);
            this.label28.TabIndex = 6;
            this.label28.Text = "서버 NUM :";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbSvcSvrNum
            // 
            this.tbSvcSvrNum.Location = new System.Drawing.Point(1275, 20);
            this.tbSvcSvrNum.Name = "tbSvcSvrNum";
            this.tbSvcSvrNum.Size = new System.Drawing.Size(68, 21);
            this.tbSvcSvrNum.TabIndex = 7;
            this.tbSvcSvrNum.Text = "1";
            this.tbSvcSvrNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSvcSvrCd
            // 
            this.tbSvcSvrCd.Location = new System.Drawing.Point(1071, 20);
            this.tbSvcSvrCd.Name = "tbSvcSvrCd";
            this.tbSvcSvrCd.Size = new System.Drawing.Size(100, 21);
            this.tbSvcSvrCd.TabIndex = 7;
            this.tbSvcSvrCd.Text = "111";
            this.tbSvcSvrCd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbDeviceLog
            // 
            this.gbDeviceLog.Controls.Add(this.groupBox12);
            this.gbDeviceLog.Controls.Add(this.tBoxDataIN);
            this.gbDeviceLog.Location = new System.Drawing.Point(472, 103);
            this.gbDeviceLog.Name = "gbDeviceLog";
            this.gbDeviceLog.Size = new System.Drawing.Size(475, 211);
            this.gbDeviceLog.TabIndex = 12;
            this.gbDeviceLog.TabStop = false;
            this.gbDeviceLog.Text = "Device Message";
            // 
            // groupBox12
            // 
            this.groupBox12.Location = new System.Drawing.Point(51, 241);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(200, 100);
            this.groupBox12.TabIndex = 36;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "groupBox12";
            // 
            // tBoxDataIN
            // 
            this.tBoxDataIN.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tBoxDataIN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tBoxDataIN.Location = new System.Drawing.Point(3, 20);
            this.tBoxDataIN.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tBoxDataIN.Multiline = true;
            this.tBoxDataIN.Name = "tBoxDataIN";
            this.tBoxDataIN.ReadOnly = true;
            this.tBoxDataIN.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tBoxDataIN.Size = new System.Drawing.Size(469, 188);
            this.tBoxDataIN.TabIndex = 22;
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(138, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(117, 19);
            this.button6.TabIndex = 55;
            this.button6.Text = "Device 정보 조회";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 709);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1920, 1076);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(748, 452);
            this.Name = "Form1";
            this.Text = "oneM2M/LwM2M Device PCT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.gbTCResult.ResumeLayout(false);
            this.gbTCResult.PerformLayout();
            this.gbServerLog.ResumeLayout(false);
            this.gbServerLog.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.gbLwM2MServer.ResumeLayout(false);
            this.gbLwM2MServer.PerformLayout();
            this.gbOneM2MServer.ResumeLayout(false);
            this.gbOneM2MServer.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.gbOneM2MDevice.ResumeLayout(false);
            this.gbOneM2MDevice.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.gbLwM2MDevice.ResumeLayout(false);
            this.gbLwM2MDevice.PerformLayout();
            this.gbModule.ResumeLayout(false);
            this.gbModule.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.gbDeviceLog.ResumeLayout(false);
            this.gbDeviceLog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox cBoxCOMPORT;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbModule;
        private System.Windows.Forms.TextBox tbSvcCd;
        private System.Windows.Forms.GroupBox gbDeviceLog;
        private System.Windows.Forms.TextBox tBoxDeviceSN;
        private System.Windows.Forms.TextBox tBoxDeviceVer;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxDeviceModel;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnModuleInfo;
        private System.Windows.Forms.Label lbModel;
        private System.Windows.Forms.Label lbModelName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbMaker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbModemVer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbIccid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbIMSI;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbActionState;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbLwM2MDevice;
        private System.Windows.Forms.Button btnATCMD;
        private System.Windows.Forms.ComboBox cBoxATCMD;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.Button btnBootstrap;
        private System.Windows.Forms.TextBox tBoxDataIN;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnDeregister;
        private System.Windows.Forms.Button btnDeviceVerLwM2M;
        private System.Windows.Forms.GroupBox gbOneM2MDevice;
        private System.Windows.Forms.Button btnModemFOTA;
        private System.Windows.Forms.Button btnDeviceFOTA;
        private System.Windows.Forms.Button btnGetDeviceCSR;
        private System.Windows.Forms.Button btnGetCSED;
        private System.Windows.Forms.Button btnSendDataOneM2M;
        private System.Windows.Forms.Button btnRcvDataOneM2M;
        private System.Windows.Forms.Button btnDelContainer;
        private System.Windows.Forms.Button btnSetContainer;
        private System.Windows.Forms.Button btnDelDeviceCSR;
        private System.Windows.Forms.Button btnCreateDeviceCSR;
        private System.Windows.Forms.Label lboneM2MRcvData;
        private System.Windows.Forms.Button btnDeviceUpdateCSR;
        private System.Windows.Forms.GroupBox gbLwM2MServer;
        private System.Windows.Forms.GroupBox gbOneM2MServer;
        private System.Windows.Forms.Label lboneM2MRxData;
        private System.Windows.Forms.Button btnDataRetrive;
        private System.Windows.Forms.Button btnSendtoDeviceoneM2M;
        private System.Windows.Forms.Button btnMEFAuthS;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tbSvcSvrCd;
        private System.Windows.Forms.TextBox tbSvcSvrNum;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox gbServerLog;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Button btnMEFAuthD;
        private System.Windows.Forms.Button btnSetSubscript;
        private System.Windows.Forms.Button btnoneM2MDeviceVer;
        private System.Windows.Forms.Button btnLwM2MDisable;
        private System.Windows.Forms.GroupBox gbTCResult;
        private System.Windows.Forms.TextBox tbTCResult;
        private System.Windows.Forms.Button btnDelRxContainer;
        private System.Windows.Forms.Button btnSetRxContainer;
        private System.Windows.Forms.Button btnDelSubscript;
        private System.Windows.Forms.Label lbSendedData;
        private System.Windows.Forms.Label lbSvroneM2MData;
        private System.Windows.Forms.Label lbDevLwM2MData;
        private System.Windows.Forms.Button btnDeviceCheck;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbLwM2MRcvData;
        private System.Windows.Forms.Button btnoneM2MModuleVer;
        private System.Windows.Forms.Button btnoneM2MFullTest;
        private System.Windows.Forms.Button btnLwM2MFullTest;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnTCResultSave;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbDirectTxData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbDirectRxData;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label lbDevEntityId;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Label lbmodemfwrver;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbdevicever;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tBResultCode;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

