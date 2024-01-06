
namespace HV_Power_Supply_GUI_ver._1
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_AllOff = new System.Windows.Forms.Button();
            this.button_AllOn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_ModulSetting = new System.Windows.Forms.Button();
            this.label_debug = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.radioButton_UDP = new System.Windows.Forms.RadioButton();
            this.radioButton_Serial = new System.Windows.Forms.RadioButton();
            this.label_SerialStatus = new System.Windows.Forms.Label();
            this.button_OpenClose = new System.Windows.Forms.Button();
            this.button_PortScan = new System.Windows.Forms.Button();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_pg_CH3 = new System.Windows.Forms.Label();
            this.label_oc_CH3 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.button_outputOFF_CH3 = new System.Windows.Forms.Button();
            this.button_outputON_CH3 = new System.Windows.Forms.Button();
            this.label_output_CH3 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.radioButton_negative_CH3 = new System.Windows.Forms.RadioButton();
            this.radioButton_positive_CH3 = new System.Windows.Forms.RadioButton();
            this.label_info_voltage_CH3 = new System.Windows.Forms.Label();
            this.numericUpDown_voltage_CH3 = new System.Windows.Forms.NumericUpDown();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label_current_CH3 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label_voltage_CH3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_pg_CH2 = new System.Windows.Forms.Label();
            this.label_oc_CH2 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.button_outputOFF_CH2 = new System.Windows.Forms.Button();
            this.button_outputON_CH2 = new System.Windows.Forms.Button();
            this.label_output_CH2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButton_negative_CH2 = new System.Windows.Forms.RadioButton();
            this.radioButton_positive_CH2 = new System.Windows.Forms.RadioButton();
            this.label_info_voltage_CH2 = new System.Windows.Forms.Label();
            this.numericUpDown_voltage_CH2 = new System.Windows.Forms.NumericUpDown();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label_current_CH2 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label_voltage_CH2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel_Channel1 = new System.Windows.Forms.Panel();
            this.label_pg_CH1 = new System.Windows.Forms.Label();
            this.label_oc_CH1 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.button_outputOFF_CH1 = new System.Windows.Forms.Button();
            this.button_outputON_CH1 = new System.Windows.Forms.Button();
            this.label_output_CH1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton_negative_CH1 = new System.Windows.Forms.RadioButton();
            this.radioButton_positive_CH1 = new System.Windows.Forms.RadioButton();
            this.label_info_voltage_CH1 = new System.Windows.Forms.Label();
            this.numericUpDown_voltage_CH1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_current_CH1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_voltage_CH1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.XserialPort = new System.IO.Ports.SerialPort(this.components);
            this.timer_req = new System.Windows.Forms.Timer(this.components);
            this.button_LoadSetAllOn = new System.Windows.Forms.Button();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.button_OFF_CH1 = new System.Windows.Forms.Button();
            this.button_ON_CH1 = new System.Windows.Forms.Button();
            this.label_enable_CH1 = new System.Windows.Forms.Label();
            this.bar_current_CH3 = new Seriak.Bar();
            this.bar_voltage_CH3 = new Seriak.Bar();
            this.bar_current_CH2 = new Seriak.Bar();
            this.bar_voltage_CH2 = new Seriak.Bar();
            this.bar_current_CH1 = new Seriak.Bar();
            this.bar_voltage_CH1 = new Seriak.Bar();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.button_OFF_CH2 = new System.Windows.Forms.Button();
            this.button_ON_CH2 = new System.Windows.Forms.Button();
            this.label_enable_CH2 = new System.Windows.Forms.Label();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.button_OFF_CH3 = new System.Windows.Forms.Button();
            this.button_ON_CH3 = new System.Windows.Forms.Button();
            this.label_enable_CH3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_voltage_CH3)).BeginInit();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_voltage_CH2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.panel_Channel1.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_voltage_CH1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button_LoadSetAllOn);
            this.panel1.Controls.Add(this.button_AllOff);
            this.panel1.Controls.Add(this.button_AllOn);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button_ModulSetting);
            this.panel1.Controls.Add(this.label_debug);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 73);
            this.panel1.TabIndex = 0;
            // 
            // button_AllOff
            // 
            this.button_AllOff.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_AllOff.FlatAppearance.BorderSize = 2;
            this.button_AllOff.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button_AllOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_AllOff.Location = new System.Drawing.Point(740, 11);
            this.button_AllOff.Margin = new System.Windows.Forms.Padding(2);
            this.button_AllOff.Name = "button_AllOff";
            this.button_AllOff.Size = new System.Drawing.Size(67, 54);
            this.button_AllOff.TabIndex = 25;
            this.button_AllOff.Text = "ALL OFF";
            this.button_AllOff.UseVisualStyleBackColor = true;
            this.button_AllOff.Click += new System.EventHandler(this.button_AllOff_Click);
            // 
            // button_AllOn
            // 
            this.button_AllOn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_AllOn.FlatAppearance.BorderSize = 2;
            this.button_AllOn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button_AllOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_AllOn.Location = new System.Drawing.Point(669, 11);
            this.button_AllOn.Margin = new System.Windows.Forms.Padding(2);
            this.button_AllOn.Name = "button_AllOn";
            this.button_AllOn.Size = new System.Drawing.Size(67, 54);
            this.button_AllOn.TabIndex = 24;
            this.button_AllOn.Text = "ALL ON";
            this.button_AllOn.UseVisualStyleBackColor = true;
            this.button_AllOn.Click += new System.EventHandler(this.button_AllOn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(358, 39);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 26);
            this.button2.TabIndex = 23;
            this.button2.Text = "Save Setting";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 26);
            this.button1.TabIndex = 22;
            this.button1.Text = "Load Setting";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button_ModulSetting
            // 
            this.button_ModulSetting.Location = new System.Drawing.Point(448, 11);
            this.button_ModulSetting.Margin = new System.Windows.Forms.Padding(2);
            this.button_ModulSetting.Name = "button_ModulSetting";
            this.button_ModulSetting.Size = new System.Drawing.Size(89, 26);
            this.button_ModulSetting.TabIndex = 20;
            this.button_ModulSetting.Text = "Modul Setting ";
            this.button_ModulSetting.UseVisualStyleBackColor = true;
            this.button_ModulSetting.Click += new System.EventHandler(this.button_set_Click);
            // 
            // label_debug
            // 
            this.label_debug.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_debug.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_debug.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_debug.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_debug.Location = new System.Drawing.Point(448, 39);
            this.label_debug.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_debug.Name = "label_debug";
            this.label_debug.Size = new System.Drawing.Size(89, 24);
            this.label_debug.TabIndex = 19;
            this.label_debug.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_IP);
            this.groupBox2.Controls.Add(this.radioButton_UDP);
            this.groupBox2.Controls.Add(this.radioButton_Serial);
            this.groupBox2.Controls.Add(this.label_SerialStatus);
            this.groupBox2.Controls.Add(this.button_OpenClose);
            this.groupBox2.Controls.Add(this.button_PortScan);
            this.groupBox2.Controls.Add(this.comboBoxPorts);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 73);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Communication";
            // 
            // textBox_IP
            // 
            this.textBox_IP.Location = new System.Drawing.Point(130, 45);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(90, 20);
            this.textBox_IP.TabIndex = 22;
            this.textBox_IP.Text = "192.168.1.22";
            // 
            // radioButton_UDP
            // 
            this.radioButton_UDP.AutoSize = true;
            this.radioButton_UDP.Location = new System.Drawing.Point(8, 46);
            this.radioButton_UDP.Name = "radioButton_UDP";
            this.radioButton_UDP.Size = new System.Drawing.Size(48, 17);
            this.radioButton_UDP.TabIndex = 21;
            this.radioButton_UDP.TabStop = true;
            this.radioButton_UDP.Text = "UDP";
            this.radioButton_UDP.UseVisualStyleBackColor = true;
            // 
            // radioButton_Serial
            // 
            this.radioButton_Serial.AutoSize = true;
            this.radioButton_Serial.Location = new System.Drawing.Point(8, 20);
            this.radioButton_Serial.Name = "radioButton_Serial";
            this.radioButton_Serial.Size = new System.Drawing.Size(51, 17);
            this.radioButton_Serial.TabIndex = 20;
            this.radioButton_Serial.TabStop = true;
            this.radioButton_Serial.Text = "Serial";
            this.radioButton_Serial.UseVisualStyleBackColor = true;
            // 
            // label_SerialStatus
            // 
            this.label_SerialStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_SerialStatus.Location = new System.Drawing.Point(231, 23);
            this.label_SerialStatus.Name = "label_SerialStatus";
            this.label_SerialStatus.Size = new System.Drawing.Size(43, 31);
            this.label_SerialStatus.TabIndex = 19;
            this.label_SerialStatus.Text = "Close";
            this.label_SerialStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_OpenClose
            // 
            this.button_OpenClose.Location = new System.Drawing.Point(279, 19);
            this.button_OpenClose.Margin = new System.Windows.Forms.Padding(2);
            this.button_OpenClose.Name = "button_OpenClose";
            this.button_OpenClose.Size = new System.Drawing.Size(56, 40);
            this.button_OpenClose.TabIndex = 5;
            this.button_OpenClose.Text = "Open Close";
            this.button_OpenClose.UseVisualStyleBackColor = true;
            this.button_OpenClose.Click += new System.EventHandler(this.button_OpenClose_Click);
            // 
            // button_PortScan
            // 
            this.button_PortScan.Location = new System.Drawing.Point(63, 18);
            this.button_PortScan.Margin = new System.Windows.Forms.Padding(2);
            this.button_PortScan.Name = "button_PortScan";
            this.button_PortScan.Size = new System.Drawing.Size(63, 22);
            this.button_PortScan.TabIndex = 6;
            this.button_PortScan.Text = "Port Scan";
            this.button_PortScan.UseVisualStyleBackColor = true;
            this.button_PortScan.Click += new System.EventHandler(this.button_PortScan_Click);
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(130, 19);
            this.comboBoxPorts.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(90, 21);
            this.comboBoxPorts.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_Channel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 73);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(824, 564);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.groupBox16);
            this.panel3.Controls.Add(this.label_pg_CH3);
            this.panel3.Controls.Add(this.label_oc_CH3);
            this.panel3.Controls.Add(this.groupBox13);
            this.panel3.Controls.Add(this.groupBox8);
            this.panel3.Controls.Add(this.groupBox9);
            this.panel3.Controls.Add(this.groupBox10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(558, 10);
            this.panel3.Margin = new System.Windows.Forms.Padding(10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(256, 544);
            this.panel3.TabIndex = 2;
            // 
            // label_pg_CH3
            // 
            this.label_pg_CH3.AutoSize = true;
            this.label_pg_CH3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_pg_CH3.Location = new System.Drawing.Point(215, 45);
            this.label_pg_CH3.Name = "label_pg_CH3";
            this.label_pg_CH3.Size = new System.Drawing.Size(24, 15);
            this.label_pg_CH3.TabIndex = 13;
            this.label_pg_CH3.Text = "PG";
            // 
            // label_oc_CH3
            // 
            this.label_oc_CH3.AutoSize = true;
            this.label_oc_CH3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_oc_CH3.Location = new System.Drawing.Point(215, 60);
            this.label_oc_CH3.Name = "label_oc_CH3";
            this.label_oc_CH3.Size = new System.Drawing.Size(24, 15);
            this.label_oc_CH3.TabIndex = 12;
            this.label_oc_CH3.Text = "OC";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.button_outputOFF_CH3);
            this.groupBox13.Controls.Add(this.button_outputON_CH3);
            this.groupBox13.Controls.Add(this.label_output_CH3);
            this.groupBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox13.Location = new System.Drawing.Point(25, 453);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(206, 77);
            this.groupBox13.TabIndex = 7;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Output:";
            // 
            // button_outputOFF_CH3
            // 
            this.button_outputOFF_CH3.Location = new System.Drawing.Point(139, 21);
            this.button_outputOFF_CH3.Name = "button_outputOFF_CH3";
            this.button_outputOFF_CH3.Size = new System.Drawing.Size(61, 41);
            this.button_outputOFF_CH3.TabIndex = 11;
            this.button_outputOFF_CH3.Text = "Output OFF";
            this.button_outputOFF_CH3.UseVisualStyleBackColor = true;
            this.button_outputOFF_CH3.Click += new System.EventHandler(this.button_outputOFF_CH3_Click);
            // 
            // button_outputON_CH3
            // 
            this.button_outputON_CH3.Location = new System.Drawing.Point(5, 21);
            this.button_outputON_CH3.Name = "button_outputON_CH3";
            this.button_outputON_CH3.Size = new System.Drawing.Size(61, 41);
            this.button_outputON_CH3.TabIndex = 9;
            this.button_outputON_CH3.Text = "Output ON";
            this.button_outputON_CH3.UseVisualStyleBackColor = true;
            this.button_outputON_CH3.Click += new System.EventHandler(this.button_outputON_CH3_Click);
            // 
            // label_output_CH3
            // 
            this.label_output_CH3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_output_CH3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_output_CH3.Location = new System.Drawing.Point(72, 32);
            this.label_output_CH3.Name = "label_output_CH3";
            this.label_output_CH3.Size = new System.Drawing.Size(61, 20);
            this.label_output_CH3.TabIndex = 10;
            this.label_output_CH3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.radioButton_negative_CH3);
            this.groupBox8.Controls.Add(this.radioButton_positive_CH3);
            this.groupBox8.Controls.Add(this.label_info_voltage_CH3);
            this.groupBox8.Controls.Add(this.numericUpDown_voltage_CH3);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox8.Location = new System.Drawing.Point(25, 300);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(206, 146);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Setting:";
            // 
            // radioButton_negative_CH3
            // 
            this.radioButton_negative_CH3.AutoSize = true;
            this.radioButton_negative_CH3.Location = new System.Drawing.Point(117, 99);
            this.radioButton_negative_CH3.Name = "radioButton_negative_CH3";
            this.radioButton_negative_CH3.Size = new System.Drawing.Size(81, 20);
            this.radioButton_negative_CH3.TabIndex = 5;
            this.radioButton_negative_CH3.Text = "Negative";
            this.radioButton_negative_CH3.UseVisualStyleBackColor = true;
            this.radioButton_negative_CH3.CheckedChanged += new System.EventHandler(this.radioButton_negative_CH3_CheckedChanged);
            // 
            // radioButton_positive_CH3
            // 
            this.radioButton_positive_CH3.AutoSize = true;
            this.radioButton_positive_CH3.Checked = true;
            this.radioButton_positive_CH3.Location = new System.Drawing.Point(12, 99);
            this.radioButton_positive_CH3.Name = "radioButton_positive_CH3";
            this.radioButton_positive_CH3.Size = new System.Drawing.Size(74, 20);
            this.radioButton_positive_CH3.TabIndex = 4;
            this.radioButton_positive_CH3.TabStop = true;
            this.radioButton_positive_CH3.Text = "Positive";
            this.radioButton_positive_CH3.UseVisualStyleBackColor = true;
            this.radioButton_positive_CH3.CheckedChanged += new System.EventHandler(this.radioButton_positive_CH3_CheckedChanged);
            // 
            // label_info_voltage_CH3
            // 
            this.label_info_voltage_CH3.AutoSize = true;
            this.label_info_voltage_CH3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_info_voltage_CH3.Location = new System.Drawing.Point(16, 55);
            this.label_info_voltage_CH3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_info_voltage_CH3.Name = "label_info_voltage_CH3";
            this.label_info_voltage_CH3.Size = new System.Drawing.Size(68, 20);
            this.label_info_voltage_CH3.TabIndex = 3;
            this.label_info_voltage_CH3.Text = "Voltage:";
            this.label_info_voltage_CH3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDown_voltage_CH3
            // 
            this.numericUpDown_voltage_CH3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_voltage_CH3.Location = new System.Drawing.Point(101, 38);
            this.numericUpDown_voltage_CH3.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_voltage_CH3.Maximum = new decimal(new int[] {
            550,
            0,
            0,
            0});
            this.numericUpDown_voltage_CH3.Name = "numericUpDown_voltage_CH3";
            this.numericUpDown_voltage_CH3.Size = new System.Drawing.Size(90, 45);
            this.numericUpDown_voltage_CH3.TabIndex = 2;
            this.numericUpDown_voltage_CH3.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown_voltage_CH3.ValueChanged += new System.EventHandler(this.numericUpDown_voltage_CH3_ValueChanged);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.bar_current_CH3);
            this.groupBox9.Controls.Add(this.label_current_CH3);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox9.Location = new System.Drawing.Point(25, 197);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(206, 97);
            this.groupBox9.TabIndex = 4;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Current:";
            // 
            // label_current_CH3
            // 
            this.label_current_CH3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_current_CH3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_current_CH3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_current_CH3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_current_CH3.Location = new System.Drawing.Point(47, 22);
            this.label_current_CH3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_current_CH3.Name = "label_current_CH3";
            this.label_current_CH3.Size = new System.Drawing.Size(110, 31);
            this.label_current_CH3.TabIndex = 11;
            this.label_current_CH3.Text = "12.2 uA";
            this.label_current_CH3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.bar_voltage_CH3);
            this.groupBox10.Controls.Add(this.label_voltage_CH3);
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox10.Location = new System.Drawing.Point(25, 95);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(206, 97);
            this.groupBox10.TabIndex = 1;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Voltage:";
            // 
            // label_voltage_CH3
            // 
            this.label_voltage_CH3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_voltage_CH3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_voltage_CH3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_voltage_CH3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_voltage_CH3.Location = new System.Drawing.Point(47, 22);
            this.label_voltage_CH3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_voltage_CH3.Name = "label_voltage_CH3";
            this.label_voltage_CH3.Size = new System.Drawing.Size(110, 31);
            this.label_voltage_CH3.TabIndex = 11;
            this.label_voltage_CH3.Text = "500.2 V";
            this.label_voltage_CH3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Margin = new System.Windows.Forms.Padding(3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(254, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Channel 3";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.groupBox15);
            this.panel2.Controls.Add(this.label_pg_CH2);
            this.panel2.Controls.Add(this.label_oc_CH2);
            this.panel2.Controls.Add(this.groupBox12);
            this.panel2.Controls.Add(this.groupBox5);
            this.panel2.Controls.Add(this.groupBox6);
            this.panel2.Controls.Add(this.groupBox7);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(284, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 544);
            this.panel2.TabIndex = 1;
            // 
            // label_pg_CH2
            // 
            this.label_pg_CH2.AutoSize = true;
            this.label_pg_CH2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_pg_CH2.Location = new System.Drawing.Point(215, 46);
            this.label_pg_CH2.Name = "label_pg_CH2";
            this.label_pg_CH2.Size = new System.Drawing.Size(24, 15);
            this.label_pg_CH2.TabIndex = 11;
            this.label_pg_CH2.Text = "PG";
            // 
            // label_oc_CH2
            // 
            this.label_oc_CH2.AutoSize = true;
            this.label_oc_CH2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_oc_CH2.Location = new System.Drawing.Point(215, 61);
            this.label_oc_CH2.Name = "label_oc_CH2";
            this.label_oc_CH2.Size = new System.Drawing.Size(24, 15);
            this.label_oc_CH2.TabIndex = 10;
            this.label_oc_CH2.Text = "OC";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.button_outputOFF_CH2);
            this.groupBox12.Controls.Add(this.button_outputON_CH2);
            this.groupBox12.Controls.Add(this.label_output_CH2);
            this.groupBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox12.Location = new System.Drawing.Point(25, 453);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(206, 77);
            this.groupBox12.TabIndex = 7;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Output:";
            // 
            // button_outputOFF_CH2
            // 
            this.button_outputOFF_CH2.Location = new System.Drawing.Point(139, 21);
            this.button_outputOFF_CH2.Name = "button_outputOFF_CH2";
            this.button_outputOFF_CH2.Size = new System.Drawing.Size(61, 41);
            this.button_outputOFF_CH2.TabIndex = 11;
            this.button_outputOFF_CH2.Text = "Output OFF";
            this.button_outputOFF_CH2.UseVisualStyleBackColor = true;
            this.button_outputOFF_CH2.Click += new System.EventHandler(this.button_outputOFF_CH2_Click);
            // 
            // button_outputON_CH2
            // 
            this.button_outputON_CH2.Location = new System.Drawing.Point(5, 21);
            this.button_outputON_CH2.Name = "button_outputON_CH2";
            this.button_outputON_CH2.Size = new System.Drawing.Size(61, 41);
            this.button_outputON_CH2.TabIndex = 9;
            this.button_outputON_CH2.Text = "Output ON";
            this.button_outputON_CH2.UseVisualStyleBackColor = true;
            this.button_outputON_CH2.Click += new System.EventHandler(this.button_outputON_CH2_Click);
            // 
            // label_output_CH2
            // 
            this.label_output_CH2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_output_CH2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_output_CH2.Location = new System.Drawing.Point(72, 32);
            this.label_output_CH2.Name = "label_output_CH2";
            this.label_output_CH2.Size = new System.Drawing.Size(61, 20);
            this.label_output_CH2.TabIndex = 10;
            this.label_output_CH2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButton_negative_CH2);
            this.groupBox5.Controls.Add(this.radioButton_positive_CH2);
            this.groupBox5.Controls.Add(this.label_info_voltage_CH2);
            this.groupBox5.Controls.Add(this.numericUpDown_voltage_CH2);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox5.Location = new System.Drawing.Point(25, 300);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(206, 146);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Setting:";
            // 
            // radioButton_negative_CH2
            // 
            this.radioButton_negative_CH2.AutoSize = true;
            this.radioButton_negative_CH2.Location = new System.Drawing.Point(117, 99);
            this.radioButton_negative_CH2.Name = "radioButton_negative_CH2";
            this.radioButton_negative_CH2.Size = new System.Drawing.Size(81, 20);
            this.radioButton_negative_CH2.TabIndex = 5;
            this.radioButton_negative_CH2.Text = "Negative";
            this.radioButton_negative_CH2.UseVisualStyleBackColor = true;
            this.radioButton_negative_CH2.CheckedChanged += new System.EventHandler(this.radioButton_negative_CH2_CheckedChanged);
            // 
            // radioButton_positive_CH2
            // 
            this.radioButton_positive_CH2.AutoSize = true;
            this.radioButton_positive_CH2.Checked = true;
            this.radioButton_positive_CH2.Location = new System.Drawing.Point(12, 99);
            this.radioButton_positive_CH2.Name = "radioButton_positive_CH2";
            this.radioButton_positive_CH2.Size = new System.Drawing.Size(74, 20);
            this.radioButton_positive_CH2.TabIndex = 4;
            this.radioButton_positive_CH2.TabStop = true;
            this.radioButton_positive_CH2.Text = "Positive";
            this.radioButton_positive_CH2.UseVisualStyleBackColor = true;
            this.radioButton_positive_CH2.CheckedChanged += new System.EventHandler(this.radioButton_positive_CH2_CheckedChanged);
            // 
            // label_info_voltage_CH2
            // 
            this.label_info_voltage_CH2.AutoSize = true;
            this.label_info_voltage_CH2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_info_voltage_CH2.Location = new System.Drawing.Point(16, 55);
            this.label_info_voltage_CH2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_info_voltage_CH2.Name = "label_info_voltage_CH2";
            this.label_info_voltage_CH2.Size = new System.Drawing.Size(68, 20);
            this.label_info_voltage_CH2.TabIndex = 3;
            this.label_info_voltage_CH2.Text = "Voltage:";
            this.label_info_voltage_CH2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDown_voltage_CH2
            // 
            this.numericUpDown_voltage_CH2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_voltage_CH2.Location = new System.Drawing.Point(101, 38);
            this.numericUpDown_voltage_CH2.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_voltage_CH2.Maximum = new decimal(new int[] {
            550,
            0,
            0,
            0});
            this.numericUpDown_voltage_CH2.Name = "numericUpDown_voltage_CH2";
            this.numericUpDown_voltage_CH2.Size = new System.Drawing.Size(90, 45);
            this.numericUpDown_voltage_CH2.TabIndex = 2;
            this.numericUpDown_voltage_CH2.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown_voltage_CH2.ValueChanged += new System.EventHandler(this.numericUpDown_voltage_CH2_ValueChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.bar_current_CH2);
            this.groupBox6.Controls.Add(this.label_current_CH2);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox6.Location = new System.Drawing.Point(25, 197);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(206, 97);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Current:";
            // 
            // label_current_CH2
            // 
            this.label_current_CH2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_current_CH2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_current_CH2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_current_CH2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_current_CH2.Location = new System.Drawing.Point(47, 22);
            this.label_current_CH2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_current_CH2.Name = "label_current_CH2";
            this.label_current_CH2.Size = new System.Drawing.Size(110, 31);
            this.label_current_CH2.TabIndex = 11;
            this.label_current_CH2.Text = "12.2 uA";
            this.label_current_CH2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.bar_voltage_CH2);
            this.groupBox7.Controls.Add(this.label_voltage_CH2);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox7.Location = new System.Drawing.Point(25, 95);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(206, 97);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Voltage:";
            // 
            // label_voltage_CH2
            // 
            this.label_voltage_CH2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_voltage_CH2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_voltage_CH2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_voltage_CH2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_voltage_CH2.Location = new System.Drawing.Point(47, 22);
            this.label_voltage_CH2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_voltage_CH2.Name = "label_voltage_CH2";
            this.label_voltage_CH2.Size = new System.Drawing.Size(110, 31);
            this.label_voltage_CH2.TabIndex = 11;
            this.label_voltage_CH2.Text = "500.2 V";
            this.label_voltage_CH2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(252, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Channel 2";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Channel1
            // 
            this.panel_Channel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Channel1.Controls.Add(this.groupBox14);
            this.panel_Channel1.Controls.Add(this.label_pg_CH1);
            this.panel_Channel1.Controls.Add(this.label_oc_CH1);
            this.panel_Channel1.Controls.Add(this.groupBox11);
            this.panel_Channel1.Controls.Add(this.groupBox4);
            this.panel_Channel1.Controls.Add(this.groupBox3);
            this.panel_Channel1.Controls.Add(this.groupBox1);
            this.panel_Channel1.Controls.Add(this.label1);
            this.panel_Channel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Channel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel_Channel1.Location = new System.Drawing.Point(10, 10);
            this.panel_Channel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel_Channel1.Name = "panel_Channel1";
            this.panel_Channel1.Size = new System.Drawing.Size(254, 544);
            this.panel_Channel1.TabIndex = 0;
            // 
            // label_pg_CH1
            // 
            this.label_pg_CH1.AutoSize = true;
            this.label_pg_CH1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_pg_CH1.Location = new System.Drawing.Point(215, 46);
            this.label_pg_CH1.Name = "label_pg_CH1";
            this.label_pg_CH1.Size = new System.Drawing.Size(24, 15);
            this.label_pg_CH1.TabIndex = 9;
            this.label_pg_CH1.Text = "PG";
            // 
            // label_oc_CH1
            // 
            this.label_oc_CH1.AutoSize = true;
            this.label_oc_CH1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_oc_CH1.Location = new System.Drawing.Point(215, 61);
            this.label_oc_CH1.Name = "label_oc_CH1";
            this.label_oc_CH1.Size = new System.Drawing.Size(24, 15);
            this.label_oc_CH1.TabIndex = 8;
            this.label_oc_CH1.Text = "OC";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.button_outputOFF_CH1);
            this.groupBox11.Controls.Add(this.button_outputON_CH1);
            this.groupBox11.Controls.Add(this.label_output_CH1);
            this.groupBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox11.Location = new System.Drawing.Point(26, 453);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(206, 77);
            this.groupBox11.TabIndex = 6;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Output:";
            // 
            // button_outputOFF_CH1
            // 
            this.button_outputOFF_CH1.Location = new System.Drawing.Point(139, 21);
            this.button_outputOFF_CH1.Name = "button_outputOFF_CH1";
            this.button_outputOFF_CH1.Size = new System.Drawing.Size(61, 41);
            this.button_outputOFF_CH1.TabIndex = 11;
            this.button_outputOFF_CH1.Text = "Output OFF";
            this.button_outputOFF_CH1.UseVisualStyleBackColor = true;
            this.button_outputOFF_CH1.Click += new System.EventHandler(this.button_outputOFF_CH1_Click);
            // 
            // button_outputON_CH1
            // 
            this.button_outputON_CH1.Location = new System.Drawing.Point(5, 21);
            this.button_outputON_CH1.Name = "button_outputON_CH1";
            this.button_outputON_CH1.Size = new System.Drawing.Size(61, 41);
            this.button_outputON_CH1.TabIndex = 9;
            this.button_outputON_CH1.Text = "Output ON";
            this.button_outputON_CH1.UseVisualStyleBackColor = true;
            this.button_outputON_CH1.Click += new System.EventHandler(this.button_outputON_CH1_Click);
            // 
            // label_output_CH1
            // 
            this.label_output_CH1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_output_CH1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_output_CH1.Location = new System.Drawing.Point(72, 32);
            this.label_output_CH1.Name = "label_output_CH1";
            this.label_output_CH1.Size = new System.Drawing.Size(61, 20);
            this.label_output_CH1.TabIndex = 10;
            this.label_output_CH1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton_negative_CH1);
            this.groupBox4.Controls.Add(this.radioButton_positive_CH1);
            this.groupBox4.Controls.Add(this.label_info_voltage_CH1);
            this.groupBox4.Controls.Add(this.numericUpDown_voltage_CH1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox4.Location = new System.Drawing.Point(25, 300);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(206, 146);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Setting:";
            // 
            // radioButton_negative_CH1
            // 
            this.radioButton_negative_CH1.AutoSize = true;
            this.radioButton_negative_CH1.Location = new System.Drawing.Point(117, 99);
            this.radioButton_negative_CH1.Name = "radioButton_negative_CH1";
            this.radioButton_negative_CH1.Size = new System.Drawing.Size(81, 20);
            this.radioButton_negative_CH1.TabIndex = 5;
            this.radioButton_negative_CH1.Text = "Negative";
            this.radioButton_negative_CH1.UseVisualStyleBackColor = true;
            this.radioButton_negative_CH1.CheckedChanged += new System.EventHandler(this.radioButton_negative_CH1_CheckedChanged);
            // 
            // radioButton_positive_CH1
            // 
            this.radioButton_positive_CH1.AutoSize = true;
            this.radioButton_positive_CH1.Checked = true;
            this.radioButton_positive_CH1.Location = new System.Drawing.Point(12, 99);
            this.radioButton_positive_CH1.Name = "radioButton_positive_CH1";
            this.radioButton_positive_CH1.Size = new System.Drawing.Size(74, 20);
            this.radioButton_positive_CH1.TabIndex = 4;
            this.radioButton_positive_CH1.TabStop = true;
            this.radioButton_positive_CH1.Text = "Positive";
            this.radioButton_positive_CH1.UseVisualStyleBackColor = true;
            this.radioButton_positive_CH1.CheckedChanged += new System.EventHandler(this.radioButton_positive_CH1_CheckedChanged);
            // 
            // label_info_voltage_CH1
            // 
            this.label_info_voltage_CH1.AutoSize = true;
            this.label_info_voltage_CH1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_info_voltage_CH1.Location = new System.Drawing.Point(16, 55);
            this.label_info_voltage_CH1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_info_voltage_CH1.Name = "label_info_voltage_CH1";
            this.label_info_voltage_CH1.Size = new System.Drawing.Size(68, 20);
            this.label_info_voltage_CH1.TabIndex = 3;
            this.label_info_voltage_CH1.Text = "Voltage:";
            this.label_info_voltage_CH1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDown_voltage_CH1
            // 
            this.numericUpDown_voltage_CH1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_voltage_CH1.Location = new System.Drawing.Point(101, 38);
            this.numericUpDown_voltage_CH1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_voltage_CH1.Maximum = new decimal(new int[] {
            550,
            0,
            0,
            0});
            this.numericUpDown_voltage_CH1.Name = "numericUpDown_voltage_CH1";
            this.numericUpDown_voltage_CH1.Size = new System.Drawing.Size(90, 45);
            this.numericUpDown_voltage_CH1.TabIndex = 2;
            this.numericUpDown_voltage_CH1.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown_voltage_CH1.ValueChanged += new System.EventHandler(this.numericUpDown_voltage_CH1_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bar_current_CH1);
            this.groupBox3.Controls.Add(this.label_current_CH1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(25, 197);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(206, 97);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Current:";
            // 
            // label_current_CH1
            // 
            this.label_current_CH1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_current_CH1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_current_CH1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_current_CH1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_current_CH1.Location = new System.Drawing.Point(47, 22);
            this.label_current_CH1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_current_CH1.Name = "label_current_CH1";
            this.label_current_CH1.Size = new System.Drawing.Size(110, 31);
            this.label_current_CH1.TabIndex = 11;
            this.label_current_CH1.Text = "12.2 uA";
            this.label_current_CH1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bar_voltage_CH1);
            this.groupBox1.Controls.Add(this.label_voltage_CH1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(25, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 97);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Voltage:";
            // 
            // label_voltage_CH1
            // 
            this.label_voltage_CH1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_voltage_CH1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_voltage_CH1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_voltage_CH1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_voltage_CH1.Location = new System.Drawing.Point(47, 22);
            this.label_voltage_CH1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_voltage_CH1.Name = "label_voltage_CH1";
            this.label_voltage_CH1.Size = new System.Drawing.Size(110, 31);
            this.label_voltage_CH1.TabIndex = 11;
            this.label_voltage_CH1.Text = "500.2 V";
            this.label_voltage_CH1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Channel 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // XserialPort
            // 
            this.XserialPort.BaudRate = 115200;
            // 
            // timer_req
            // 
            this.timer_req.Interval = 200;
            this.timer_req.Tick += new System.EventHandler(this.timer_req_Tick);
            // 
            // button_LoadSetAllOn
            // 
            this.button_LoadSetAllOn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_LoadSetAllOn.FlatAppearance.BorderSize = 2;
            this.button_LoadSetAllOn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button_LoadSetAllOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_LoadSetAllOn.Location = new System.Drawing.Point(583, 11);
            this.button_LoadSetAllOn.Margin = new System.Windows.Forms.Padding(2);
            this.button_LoadSetAllOn.Name = "button_LoadSetAllOn";
            this.button_LoadSetAllOn.Size = new System.Drawing.Size(82, 54);
            this.button_LoadSetAllOn.TabIndex = 26;
            this.button_LoadSetAllOn.Text = "Load Set ALL ON ";
            this.button_LoadSetAllOn.UseVisualStyleBackColor = true;
            this.button_LoadSetAllOn.Click += new System.EventHandler(this.button_LoadSetAllOn_Click);
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.button_OFF_CH1);
            this.groupBox14.Controls.Add(this.button_ON_CH1);
            this.groupBox14.Controls.Add(this.label_enable_CH1);
            this.groupBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox14.Location = new System.Drawing.Point(25, 26);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(181, 63);
            this.groupBox14.TabIndex = 10;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Enable:";
            // 
            // button_OFF_CH1
            // 
            this.button_OFF_CH1.Location = new System.Drawing.Point(119, 20);
            this.button_OFF_CH1.Name = "button_OFF_CH1";
            this.button_OFF_CH1.Size = new System.Drawing.Size(55, 36);
            this.button_OFF_CH1.TabIndex = 11;
            this.button_OFF_CH1.Text = "OFF";
            this.button_OFF_CH1.UseVisualStyleBackColor = true;
            this.button_OFF_CH1.Click += new System.EventHandler(this.button_OFF_CH1_Click);
            // 
            // button_ON_CH1
            // 
            this.button_ON_CH1.Location = new System.Drawing.Point(7, 20);
            this.button_ON_CH1.Name = "button_ON_CH1";
            this.button_ON_CH1.Size = new System.Drawing.Size(55, 36);
            this.button_ON_CH1.TabIndex = 9;
            this.button_ON_CH1.Text = "ON";
            this.button_ON_CH1.UseVisualStyleBackColor = true;
            this.button_ON_CH1.Click += new System.EventHandler(this.button_ON_CH1_Click);
            // 
            // label_enable_CH1
            // 
            this.label_enable_CH1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_enable_CH1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_enable_CH1.Location = new System.Drawing.Point(68, 29);
            this.label_enable_CH1.Name = "label_enable_CH1";
            this.label_enable_CH1.Size = new System.Drawing.Size(45, 20);
            this.label_enable_CH1.TabIndex = 10;
            this.label_enable_CH1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bar_current_CH3
            // 
            this.bar_current_CH3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bar_current_CH3.ForeColor = System.Drawing.Color.Blue;
            this.bar_current_CH3.Location = new System.Drawing.Point(6, 67);
            this.bar_current_CH3.Max = 50;
            this.bar_current_CH3.Name = "bar_current_CH3";
            this.bar_current_CH3.Size = new System.Drawing.Size(194, 18);
            this.bar_current_CH3.TabIndex = 21;
            this.bar_current_CH3.Text = "bar6";
            this.bar_current_CH3.value = 5;
            // 
            // bar_voltage_CH3
            // 
            this.bar_voltage_CH3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bar_voltage_CH3.ForeColor = System.Drawing.Color.Blue;
            this.bar_voltage_CH3.Location = new System.Drawing.Point(6, 67);
            this.bar_voltage_CH3.Max = 500;
            this.bar_voltage_CH3.Name = "bar_voltage_CH3";
            this.bar_voltage_CH3.Size = new System.Drawing.Size(194, 18);
            this.bar_voltage_CH3.TabIndex = 21;
            this.bar_voltage_CH3.Text = "bar5";
            this.bar_voltage_CH3.value = 50;
            // 
            // bar_current_CH2
            // 
            this.bar_current_CH2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bar_current_CH2.ForeColor = System.Drawing.Color.Blue;
            this.bar_current_CH2.Location = new System.Drawing.Point(6, 67);
            this.bar_current_CH2.Max = 50;
            this.bar_current_CH2.Name = "bar_current_CH2";
            this.bar_current_CH2.Size = new System.Drawing.Size(194, 18);
            this.bar_current_CH2.TabIndex = 21;
            this.bar_current_CH2.Text = "bar4";
            this.bar_current_CH2.value = 5;
            // 
            // bar_voltage_CH2
            // 
            this.bar_voltage_CH2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bar_voltage_CH2.ForeColor = System.Drawing.Color.Blue;
            this.bar_voltage_CH2.Location = new System.Drawing.Point(6, 67);
            this.bar_voltage_CH2.Max = 500;
            this.bar_voltage_CH2.Name = "bar_voltage_CH2";
            this.bar_voltage_CH2.Size = new System.Drawing.Size(194, 18);
            this.bar_voltage_CH2.TabIndex = 21;
            this.bar_voltage_CH2.Text = "bar3";
            this.bar_voltage_CH2.value = 50;
            // 
            // bar_current_CH1
            // 
            this.bar_current_CH1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bar_current_CH1.ForeColor = System.Drawing.Color.Blue;
            this.bar_current_CH1.Location = new System.Drawing.Point(6, 67);
            this.bar_current_CH1.Max = 50;
            this.bar_current_CH1.Name = "bar_current_CH1";
            this.bar_current_CH1.Size = new System.Drawing.Size(194, 18);
            this.bar_current_CH1.TabIndex = 20;
            this.bar_current_CH1.Text = "bar2";
            this.bar_current_CH1.value = 5;
            // 
            // bar_voltage_CH1
            // 
            this.bar_voltage_CH1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bar_voltage_CH1.ForeColor = System.Drawing.Color.Blue;
            this.bar_voltage_CH1.Location = new System.Drawing.Point(6, 67);
            this.bar_voltage_CH1.Max = 500;
            this.bar_voltage_CH1.Name = "bar_voltage_CH1";
            this.bar_voltage_CH1.Size = new System.Drawing.Size(194, 18);
            this.bar_voltage_CH1.TabIndex = 19;
            this.bar_voltage_CH1.Text = "bar1";
            this.bar_voltage_CH1.value = 50;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.button_OFF_CH2);
            this.groupBox15.Controls.Add(this.button_ON_CH2);
            this.groupBox15.Controls.Add(this.label_enable_CH2);
            this.groupBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox15.Location = new System.Drawing.Point(25, 26);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(181, 63);
            this.groupBox15.TabIndex = 12;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Enable:";
            // 
            // button_OFF_CH2
            // 
            this.button_OFF_CH2.Location = new System.Drawing.Point(119, 20);
            this.button_OFF_CH2.Name = "button_OFF_CH2";
            this.button_OFF_CH2.Size = new System.Drawing.Size(55, 36);
            this.button_OFF_CH2.TabIndex = 11;
            this.button_OFF_CH2.Text = "OFF";
            this.button_OFF_CH2.UseVisualStyleBackColor = true;
            this.button_OFF_CH2.Click += new System.EventHandler(this.button_OFF_CH2_Click);
            // 
            // button_ON_CH2
            // 
            this.button_ON_CH2.Location = new System.Drawing.Point(7, 20);
            this.button_ON_CH2.Name = "button_ON_CH2";
            this.button_ON_CH2.Size = new System.Drawing.Size(55, 36);
            this.button_ON_CH2.TabIndex = 9;
            this.button_ON_CH2.Text = "ON";
            this.button_ON_CH2.UseVisualStyleBackColor = true;
            this.button_ON_CH2.Click += new System.EventHandler(this.button_ON_CH2_Click);
            // 
            // label_enable_CH2
            // 
            this.label_enable_CH2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_enable_CH2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_enable_CH2.Location = new System.Drawing.Point(68, 29);
            this.label_enable_CH2.Name = "label_enable_CH2";
            this.label_enable_CH2.Size = new System.Drawing.Size(45, 20);
            this.label_enable_CH2.TabIndex = 10;
            this.label_enable_CH2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.button_OFF_CH3);
            this.groupBox16.Controls.Add(this.button_ON_CH3);
            this.groupBox16.Controls.Add(this.label_enable_CH3);
            this.groupBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox16.Location = new System.Drawing.Point(25, 26);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(181, 63);
            this.groupBox16.TabIndex = 14;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Enable:";
            // 
            // button_OFF_CH3
            // 
            this.button_OFF_CH3.Location = new System.Drawing.Point(119, 20);
            this.button_OFF_CH3.Name = "button_OFF_CH3";
            this.button_OFF_CH3.Size = new System.Drawing.Size(55, 36);
            this.button_OFF_CH3.TabIndex = 11;
            this.button_OFF_CH3.Text = "OFF";
            this.button_OFF_CH3.UseVisualStyleBackColor = true;
            this.button_OFF_CH3.Click += new System.EventHandler(this.button_OFF_CH3_Click);
            // 
            // button_ON_CH3
            // 
            this.button_ON_CH3.Location = new System.Drawing.Point(7, 20);
            this.button_ON_CH3.Name = "button_ON_CH3";
            this.button_ON_CH3.Size = new System.Drawing.Size(55, 36);
            this.button_ON_CH3.TabIndex = 9;
            this.button_ON_CH3.Text = "ON";
            this.button_ON_CH3.UseVisualStyleBackColor = true;
            this.button_ON_CH3.Click += new System.EventHandler(this.button_ON_CH3_Click);
            // 
            // label_enable_CH3
            // 
            this.label_enable_CH3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_enable_CH3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_enable_CH3.Location = new System.Drawing.Point(68, 29);
            this.label_enable_CH3.Name = "label_enable_CH3";
            this.label_enable_CH3.Size = new System.Drawing.Size(45, 20);
            this.label_enable_CH3.TabIndex = 10;
            this.label_enable_CH3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 637);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(840, 676);
            this.MinimumSize = new System.Drawing.Size(840, 676);
            this.Name = "Form1";
            this.Text = "High Voltage Power Supply";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_voltage_CH3)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_voltage_CH2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.panel_Channel1.ResumeLayout(false);
            this.panel_Channel1.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_voltage_CH1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.groupBox16.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_OpenClose;
        private System.Windows.Forms.Button button_PortScan;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel_Channel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_voltage_CH1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton_negative_CH1;
        private System.Windows.Forms.RadioButton radioButton_positive_CH1;
        private System.Windows.Forms.Label label_info_voltage_CH1;
        private System.Windows.Forms.NumericUpDown numericUpDown_voltage_CH1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label_current_CH1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RadioButton radioButton_negative_CH3;
        private System.Windows.Forms.RadioButton radioButton_positive_CH3;
        private System.Windows.Forms.Label label_info_voltage_CH3;
        private System.Windows.Forms.NumericUpDown numericUpDown_voltage_CH3;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label_current_CH3;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label_voltage_CH3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButton_negative_CH2;
        private System.Windows.Forms.RadioButton radioButton_positive_CH2;
        private System.Windows.Forms.Label label_info_voltage_CH2;
        private System.Windows.Forms.NumericUpDown numericUpDown_voltage_CH2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label_current_CH2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label_voltage_CH2;
        private System.Windows.Forms.Label label7;
        private Seriak.Bar bar_current_CH3;
        private Seriak.Bar bar_voltage_CH3;
        private Seriak.Bar bar_current_CH2;
        private Seriak.Bar bar_voltage_CH2;
        private Seriak.Bar bar_current_CH1;
        private Seriak.Bar bar_voltage_CH1;
        private System.IO.Ports.SerialPort XserialPort;
        private System.Windows.Forms.Label label_SerialStatus;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Button button_outputOFF_CH3;
        private System.Windows.Forms.Button button_outputON_CH3;
        private System.Windows.Forms.Label label_output_CH3;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Button button_outputOFF_CH2;
        private System.Windows.Forms.Button button_outputON_CH2;
        private System.Windows.Forms.Label label_output_CH2;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Button button_outputOFF_CH1;
        private System.Windows.Forms.Button button_outputON_CH1;
        private System.Windows.Forms.Label label_output_CH1;
        private System.Windows.Forms.Label label_debug;
        private System.Windows.Forms.Button button_ModulSetting;
        private System.Windows.Forms.Label label_pg_CH3;
        private System.Windows.Forms.Label label_oc_CH3;
        private System.Windows.Forms.Label label_pg_CH2;
        private System.Windows.Forms.Label label_oc_CH2;
        private System.Windows.Forms.Label label_pg_CH1;
        private System.Windows.Forms.Label label_oc_CH1;
        private System.Windows.Forms.TextBox textBox_IP;
        private System.Windows.Forms.RadioButton radioButton_UDP;
        private System.Windows.Forms.RadioButton radioButton_Serial;
        private System.Windows.Forms.Timer timer_req;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_AllOff;
        private System.Windows.Forms.Button button_AllOn;
        private System.Windows.Forms.Button button_LoadSetAllOn;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Button button_OFF_CH1;
        private System.Windows.Forms.Button button_ON_CH1;
        private System.Windows.Forms.Label label_enable_CH1;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.Button button_OFF_CH3;
        private System.Windows.Forms.Button button_ON_CH3;
        private System.Windows.Forms.Label label_enable_CH3;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.Button button_OFF_CH2;
        private System.Windows.Forms.Button button_ON_CH2;
        private System.Windows.Forms.Label label_enable_CH2;
    }
}

