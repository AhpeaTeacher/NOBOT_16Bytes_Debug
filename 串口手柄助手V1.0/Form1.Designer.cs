namespace 串口手柄助手V1._0
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnOpen = new System.Windows.Forms.Button();
            this.cbxPort = new System.Windows.Forms.ComboBox();
            this.rbxTx = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxAngelSpeed1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxLineSpeed1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxAngelSpeed2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxLineSpeed2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbxAngelSpeed3 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbxLineSpeed3 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSetSpeed = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbxBaud = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.rbtX = new System.Windows.Forms.RadioButton();
            this.rbtB = new System.Windows.Forms.RadioButton();
            this.rbtA = new System.Windows.Forms.RadioButton();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.tbxYpos = new System.Windows.Forms.TextBox();
            this.tbxXpos = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tbxTolerance = new System.Windows.Forms.TextBox();
            this.btnSetJoy = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.rbtLeftFor = new System.Windows.Forms.RadioButton();
            this.rbtFor = new System.Windows.Forms.RadioButton();
            this.rbtRightFor = new System.Windows.Forms.RadioButton();
            this.rbtLeft = new System.Windows.Forms.RadioButton();
            this.rbtStop = new System.Windows.Forms.RadioButton();
            this.rbtRight = new System.Windows.Forms.RadioButton();
            this.rbtLeftBack = new System.Windows.Forms.RadioButton();
            this.rbtBack = new System.Windows.Forms.RadioButton();
            this.rbtRightBack = new System.Windows.Forms.RadioButton();
            this.label18 = new System.Windows.Forms.Label();
            this.tbxTimer = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.tbxJoySupportStatus = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(199, 35);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 40);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "打开串口";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // cbxPort
            // 
            this.cbxPort.FormattingEnabled = true;
            this.cbxPort.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.cbxPort.Location = new System.Drawing.Point(70, 32);
            this.cbxPort.Name = "cbxPort";
            this.cbxPort.Size = new System.Drawing.Size(91, 23);
            this.cbxPort.TabIndex = 2;
            this.cbxPort.Text = "COM1";
            // 
            // rbxTx
            // 
            this.rbxTx.Location = new System.Drawing.Point(6, 35);
            this.rbxTx.Name = "rbxTx";
            this.rbxTx.Size = new System.Drawing.Size(426, 202);
            this.rbxTx.TabIndex = 4;
            this.rbxTx.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "发送记录:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbxAngelSpeed1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbxLineSpeed1);
            this.groupBox1.Location = new System.Drawing.Point(6, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 83);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "一级速度:A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "rad/s";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "m/s";
            // 
            // tbxAngelSpeed1
            // 
            this.tbxAngelSpeed1.Location = new System.Drawing.Point(76, 54);
            this.tbxAngelSpeed1.Name = "tbxAngelSpeed1";
            this.tbxAngelSpeed1.Size = new System.Drawing.Size(62, 25);
            this.tbxAngelSpeed1.TabIndex = 3;
            this.tbxAngelSpeed1.Text = "0.5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "角速度:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "线速度:";
            // 
            // tbxLineSpeed1
            // 
            this.tbxLineSpeed1.Location = new System.Drawing.Point(76, 24);
            this.tbxLineSpeed1.Name = "tbxLineSpeed1";
            this.tbxLineSpeed1.Size = new System.Drawing.Size(62, 25);
            this.tbxLineSpeed1.TabIndex = 0;
            this.tbxLineSpeed1.Text = "0.4";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbxAngelSpeed2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tbxLineSpeed2);
            this.groupBox2.Location = new System.Drawing.Point(6, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 90);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "二级速度:B";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(144, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "rad/s";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(144, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "m/s";
            // 
            // tbxAngelSpeed2
            // 
            this.tbxAngelSpeed2.Location = new System.Drawing.Point(76, 54);
            this.tbxAngelSpeed2.Name = "tbxAngelSpeed2";
            this.tbxAngelSpeed2.Size = new System.Drawing.Size(62, 25);
            this.tbxAngelSpeed2.TabIndex = 3;
            this.tbxAngelSpeed2.Text = "0.3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "角速度:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "线速度:";
            // 
            // tbxLineSpeed2
            // 
            this.tbxLineSpeed2.Location = new System.Drawing.Point(76, 24);
            this.tbxLineSpeed2.Name = "tbxLineSpeed2";
            this.tbxLineSpeed2.Size = new System.Drawing.Size(62, 25);
            this.tbxLineSpeed2.TabIndex = 0;
            this.tbxLineSpeed2.Text = "1.0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.tbxAngelSpeed3);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.tbxLineSpeed3);
            this.groupBox3.Location = new System.Drawing.Point(6, 203);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 86);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "三级速度:X";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(144, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 15);
            this.label11.TabIndex = 5;
            this.label11.Text = "rad/s";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(144, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 15);
            this.label12.TabIndex = 4;
            this.label12.Text = "m/s";
            // 
            // tbxAngelSpeed3
            // 
            this.tbxAngelSpeed3.Location = new System.Drawing.Point(76, 54);
            this.tbxAngelSpeed3.Name = "tbxAngelSpeed3";
            this.tbxAngelSpeed3.Size = new System.Drawing.Size(62, 25);
            this.tbxAngelSpeed3.TabIndex = 3;
            this.tbxAngelSpeed3.Text = "0.1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 15);
            this.label13.TabIndex = 2;
            this.label13.Text = "角速度:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 15);
            this.label14.TabIndex = 1;
            this.label14.Text = "线速度:";
            // 
            // tbxLineSpeed3
            // 
            this.tbxLineSpeed3.Location = new System.Drawing.Point(76, 24);
            this.tbxLineSpeed3.Name = "tbxLineSpeed3";
            this.tbxLineSpeed3.Size = new System.Drawing.Size(62, 25);
            this.tbxLineSpeed3.TabIndex = 0;
            this.tbxLineSpeed3.Text = "2.0";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.rbxTx);
            this.groupBox4.Location = new System.Drawing.Point(527, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(438, 243);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnSetSpeed);
            this.groupBox5.Controls.Add(this.groupBox1);
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Controls.Add(this.groupBox3);
            this.groupBox5.Location = new System.Drawing.Point(299, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(222, 351);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "速度设置";
            // 
            // btnSetSpeed
            // 
            this.btnSetSpeed.Location = new System.Drawing.Point(131, 298);
            this.btnSetSpeed.Name = "btnSetSpeed";
            this.btnSetSpeed.Size = new System.Drawing.Size(75, 40);
            this.btnSetSpeed.TabIndex = 12;
            this.btnSetSpeed.Text = "设置";
            this.btnSetSpeed.UseVisualStyleBackColor = true;
            this.btnSetSpeed.Click += new System.EventHandler(this.btnSetSpeed_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cbxBaud);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.cbxPort);
            this.groupBox6.Controls.Add(this.btnOpen);
            this.groupBox6.Location = new System.Drawing.Point(12, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(281, 107);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "串口设置";
            // 
            // cbxBaud
            // 
            this.cbxBaud.FormattingEnabled = true;
            this.cbxBaud.Items.AddRange(new object[] {
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200"});
            this.cbxBaud.Location = new System.Drawing.Point(70, 64);
            this.cbxBaud.Name = "cbxBaud";
            this.cbxBaud.Size = new System.Drawing.Size(91, 23);
            this.cbxBaud.TabIndex = 4;
            this.cbxBaud.Text = "115200";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 70);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 15);
            this.label16.TabIndex = 3;
            this.label16.Text = "波特率:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 37);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 15);
            this.label15.TabIndex = 0;
            this.label15.Text = "端口:";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.groupBox10);
            this.groupBox9.Controls.Add(this.groupBox8);
            this.groupBox9.Controls.Add(this.tbxTolerance);
            this.groupBox9.Controls.Add(this.btnSetJoy);
            this.groupBox9.Controls.Add(this.groupBox7);
            this.groupBox9.Controls.Add(this.label18);
            this.groupBox9.Controls.Add(this.tbxTimer);
            this.groupBox9.Controls.Add(this.label17);
            this.groupBox9.Controls.Add(this.label25);
            this.groupBox9.Controls.Add(this.tbxJoySupportStatus);
            this.groupBox9.Location = new System.Drawing.Point(12, 121);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(281, 240);
            this.groupBox9.TabIndex = 18;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "手柄设置";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.rbtX);
            this.groupBox10.Controls.Add(this.rbtB);
            this.groupBox10.Controls.Add(this.rbtA);
            this.groupBox10.Location = new System.Drawing.Point(144, 174);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(131, 60);
            this.groupBox10.TabIndex = 33;
            this.groupBox10.TabStop = false;
            // 
            // rbtX
            // 
            this.rbtX.AutoSize = true;
            this.rbtX.Location = new System.Drawing.Point(10, 38);
            this.rbtX.Name = "rbtX";
            this.rbtX.Size = new System.Drawing.Size(36, 19);
            this.rbtX.TabIndex = 2;
            this.rbtX.TabStop = true;
            this.rbtX.Text = "X";
            this.rbtX.UseVisualStyleBackColor = true;
            // 
            // rbtB
            // 
            this.rbtB.AutoSize = true;
            this.rbtB.Location = new System.Drawing.Point(75, 13);
            this.rbtB.Name = "rbtB";
            this.rbtB.Size = new System.Drawing.Size(36, 19);
            this.rbtB.TabIndex = 1;
            this.rbtB.TabStop = true;
            this.rbtB.Text = "B";
            this.rbtB.UseVisualStyleBackColor = true;
            // 
            // rbtA
            // 
            this.rbtA.AutoSize = true;
            this.rbtA.Location = new System.Drawing.Point(10, 13);
            this.rbtA.Name = "rbtA";
            this.rbtA.Size = new System.Drawing.Size(36, 19);
            this.rbtA.TabIndex = 0;
            this.rbtA.TabStop = true;
            this.rbtA.Text = "A";
            this.rbtA.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.tbxYpos);
            this.groupBox8.Controls.Add(this.tbxXpos);
            this.groupBox8.Controls.Add(this.label20);
            this.groupBox8.Controls.Add(this.label19);
            this.groupBox8.Location = new System.Drawing.Point(144, 76);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(131, 94);
            this.groupBox8.TabIndex = 19;
            this.groupBox8.TabStop = false;
            // 
            // tbxYpos
            // 
            this.tbxYpos.Location = new System.Drawing.Point(55, 57);
            this.tbxYpos.Name = "tbxYpos";
            this.tbxYpos.Size = new System.Drawing.Size(65, 25);
            this.tbxYpos.TabIndex = 3;
            // 
            // tbxXpos
            // 
            this.tbxXpos.Location = new System.Drawing.Point(55, 18);
            this.tbxXpos.Name = "tbxXpos";
            this.tbxXpos.Size = new System.Drawing.Size(65, 25);
            this.tbxXpos.TabIndex = 2;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(7, 60);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(47, 15);
            this.label20.TabIndex = 1;
            this.label20.Text = "Ypos:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 25);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 15);
            this.label19.TabIndex = 0;
            this.label19.Text = "Xpos:";
            // 
            // tbxTolerance
            // 
            this.tbxTolerance.Location = new System.Drawing.Point(96, 14);
            this.tbxTolerance.Name = "tbxTolerance";
            this.tbxTolerance.Size = new System.Drawing.Size(59, 25);
            this.tbxTolerance.TabIndex = 32;
            this.tbxTolerance.Text = "2200";
            this.tbxTolerance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSetJoy
            // 
            this.btnSetJoy.Location = new System.Drawing.Point(199, 21);
            this.btnSetJoy.Name = "btnSetJoy";
            this.btnSetJoy.Size = new System.Drawing.Size(75, 40);
            this.btnSetJoy.TabIndex = 31;
            this.btnSetJoy.Text = "设置";
            this.btnSetJoy.UseVisualStyleBackColor = true;
            this.btnSetJoy.Click += new System.EventHandler(this.btnSetJoy_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.rbtLeftFor);
            this.groupBox7.Controls.Add(this.rbtFor);
            this.groupBox7.Controls.Add(this.rbtRightFor);
            this.groupBox7.Controls.Add(this.rbtLeft);
            this.groupBox7.Controls.Add(this.rbtStop);
            this.groupBox7.Controls.Add(this.rbtRight);
            this.groupBox7.Controls.Add(this.rbtLeftBack);
            this.groupBox7.Controls.Add(this.rbtBack);
            this.groupBox7.Controls.Add(this.rbtRightBack);
            this.groupBox7.Location = new System.Drawing.Point(6, 76);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(132, 123);
            this.groupBox7.TabIndex = 30;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "手柄方位显示";
            // 
            // rbtLeftFor
            // 
            this.rbtLeftFor.AutoSize = true;
            this.rbtLeftFor.Location = new System.Drawing.Point(14, 24);
            this.rbtLeftFor.Name = "rbtLeftFor";
            this.rbtLeftFor.Size = new System.Drawing.Size(17, 16);
            this.rbtLeftFor.TabIndex = 0;
            this.rbtLeftFor.UseVisualStyleBackColor = true;
            // 
            // rbtFor
            // 
            this.rbtFor.AutoSize = true;
            this.rbtFor.Location = new System.Drawing.Point(60, 24);
            this.rbtFor.Name = "rbtFor";
            this.rbtFor.Size = new System.Drawing.Size(17, 16);
            this.rbtFor.TabIndex = 1;
            this.rbtFor.UseVisualStyleBackColor = true;
            // 
            // rbtRightFor
            // 
            this.rbtRightFor.AutoSize = true;
            this.rbtRightFor.Location = new System.Drawing.Point(105, 24);
            this.rbtRightFor.Name = "rbtRightFor";
            this.rbtRightFor.Size = new System.Drawing.Size(17, 16);
            this.rbtRightFor.TabIndex = 2;
            this.rbtRightFor.UseVisualStyleBackColor = true;
            // 
            // rbtLeft
            // 
            this.rbtLeft.AutoSize = true;
            this.rbtLeft.Location = new System.Drawing.Point(14, 61);
            this.rbtLeft.Name = "rbtLeft";
            this.rbtLeft.Size = new System.Drawing.Size(17, 16);
            this.rbtLeft.TabIndex = 3;
            this.rbtLeft.UseVisualStyleBackColor = true;
            // 
            // rbtStop
            // 
            this.rbtStop.AutoSize = true;
            this.rbtStop.Checked = true;
            this.rbtStop.Location = new System.Drawing.Point(60, 61);
            this.rbtStop.Name = "rbtStop";
            this.rbtStop.Size = new System.Drawing.Size(17, 16);
            this.rbtStop.TabIndex = 4;
            this.rbtStop.TabStop = true;
            this.rbtStop.UseVisualStyleBackColor = true;
            // 
            // rbtRight
            // 
            this.rbtRight.AutoSize = true;
            this.rbtRight.Location = new System.Drawing.Point(105, 61);
            this.rbtRight.Name = "rbtRight";
            this.rbtRight.Size = new System.Drawing.Size(17, 16);
            this.rbtRight.TabIndex = 5;
            this.rbtRight.UseVisualStyleBackColor = true;
            // 
            // rbtLeftBack
            // 
            this.rbtLeftBack.AutoSize = true;
            this.rbtLeftBack.Location = new System.Drawing.Point(14, 98);
            this.rbtLeftBack.Name = "rbtLeftBack";
            this.rbtLeftBack.Size = new System.Drawing.Size(17, 16);
            this.rbtLeftBack.TabIndex = 6;
            this.rbtLeftBack.UseVisualStyleBackColor = true;
            // 
            // rbtBack
            // 
            this.rbtBack.AutoSize = true;
            this.rbtBack.Location = new System.Drawing.Point(60, 98);
            this.rbtBack.Name = "rbtBack";
            this.rbtBack.Size = new System.Drawing.Size(17, 16);
            this.rbtBack.TabIndex = 7;
            this.rbtBack.UseVisualStyleBackColor = true;
            // 
            // rbtRightBack
            // 
            this.rbtRightBack.AutoSize = true;
            this.rbtRightBack.Location = new System.Drawing.Point(105, 98);
            this.rbtRightBack.Name = "rbtRightBack";
            this.rbtRightBack.Size = new System.Drawing.Size(17, 16);
            this.rbtRightBack.TabIndex = 8;
            this.rbtRightBack.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(163, 51);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(23, 15);
            this.label18.TabIndex = 29;
            this.label18.Text = "HZ";
            // 
            // tbxTimer
            // 
            this.tbxTimer.Location = new System.Drawing.Point(96, 45);
            this.tbxTimer.Name = "tbxTimer";
            this.tbxTimer.Size = new System.Drawing.Size(59, 25);
            this.tbxTimer.TabIndex = 28;
            this.tbxTimer.Text = "20";
            this.tbxTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 51);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 15);
            this.label17.TabIndex = 27;
            this.label17.Text = "检测频率:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 24);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(90, 15);
            this.label25.TabIndex = 18;
            this.label25.Text = "前后向容差:";
            // 
            // tbxJoySupportStatus
            // 
            this.tbxJoySupportStatus.ForeColor = System.Drawing.Color.Red;
            this.tbxJoySupportStatus.Location = new System.Drawing.Point(9, 205);
            this.tbxJoySupportStatus.Name = "tbxJoySupportStatus";
            this.tbxJoySupportStatus.Size = new System.Drawing.Size(98, 25);
            this.tbxJoySupportStatus.TabIndex = 9;
            this.tbxJoySupportStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(527, 257);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(444, 102);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 372);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "诺博特底盘16位接口专用调试软件Beta1.0";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ComboBox cbxPort;
        private System.Windows.Forms.RichTextBox rbxTx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxAngelSpeed1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxLineSpeed1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxAngelSpeed2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxLineSpeed2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbxAngelSpeed3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbxLineSpeed3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cbxBaud;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.RadioButton rbtRightBack;
        private System.Windows.Forms.RadioButton rbtBack;
        private System.Windows.Forms.RadioButton rbtLeftBack;
        private System.Windows.Forms.RadioButton rbtRight;
        private System.Windows.Forms.RadioButton rbtStop;
        private System.Windows.Forms.RadioButton rbtLeft;
        private System.Windows.Forms.RadioButton rbtRightFor;
        private System.Windows.Forms.RadioButton rbtFor;
        private System.Windows.Forms.RadioButton rbtLeftFor;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox tbxJoySupportStatus;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbxTimer;
        private System.Windows.Forms.Label label17;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSetSpeed;
        private System.Windows.Forms.Button btnSetJoy;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox tbxYpos;
        private System.Windows.Forms.TextBox tbxXpos;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbxTolerance;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.RadioButton rbtX;
        private System.Windows.Forms.RadioButton rbtB;
        private System.Windows.Forms.RadioButton rbtA;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

