
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
            this.button_LEDoff = new System.Windows.Forms.Button();
            this.button_LEDon = new System.Windows.Forms.Button();
            this.checkBox_test = new System.Windows.Forms.CheckBox();
            this.button_set = new System.Windows.Forms.Button();
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
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown_outvolt_CH3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_prevolt_CH3 = new System.Windows.Forms.NumericUpDown();
            this.radioButton_negative_CH3 = new System.Windows.Forms.RadioButton();
            this.radioButton_positive_CH3 = new System.Windows.Forms.RadioButton();
            this.label_info_voltage_CH3 = new System.Windows.Forms.Label();
            this.numericUpDown_voltage_CH3 = new System.Windows.Forms.NumericUpDown();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.bar_current_CH3 = new Seriak.Bar();
            this.label_current_CH3 = new System.Windows.Forms.Label();
            this.checkBox_Enable_CH3 = new System.Windows.Forms.CheckBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.bar_voltage_CH3 = new Seriak.Bar();
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_outvolt_CH2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_prevolt_CH2 = new System.Windows.Forms.NumericUpDown();
            this.radioButton_negative_CH2 = new System.Windows.Forms.RadioButton();
            this.radioButton_positive_CH2 = new System.Windows.Forms.RadioButton();
            this.label_info_voltage_CH2 = new System.Windows.Forms.Label();
            this.numericUpDown_voltage_CH2 = new System.Windows.Forms.NumericUpDown();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.bar_current_CH2 = new Seriak.Bar();
            this.label_current_CH2 = new System.Windows.Forms.Label();
            this.checkBox_Enable_CH2 = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.bar_voltage_CH2 = new Seriak.Bar();
            this.label_voltage_CH2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel_Channel1 = new System.Windows.Forms.Panel();
            this.label_pg_CH1 = new System.Windows.Forms.Label();
            this.label_oc_CH1 = new System.Windows.Forms.Label();
            this.checkBox_Enable_CH1 = new System.Windows.Forms.CheckBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.button_outputOFF_CH1 = new System.Windows.Forms.Button();
            this.button_outputON_CH1 = new System.Windows.Forms.Button();
            this.label_output_CH1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_outvolt_CH1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_prevolt_CH1 = new System.Windows.Forms.NumericUpDown();
            this.radioButton_negative_CH1 = new System.Windows.Forms.RadioButton();
            this.radioButton_positive_CH1 = new System.Windows.Forms.RadioButton();
            this.label_info_voltage_CH1 = new System.Windows.Forms.Label();
            this.numericUpDown_voltage_CH1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bar_current_CH1 = new Seriak.Bar();
            this.label_current_CH1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bar_voltage_CH1 = new Seriak.Bar();
            this.label_voltage_CH1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.XserialPort = new System.IO.Ports.SerialPort(this.components);
            this.timer_Read = new System.Windows.Forms.Timer(this.components);
            this.timer_req = new System.Windows.Forms.Timer(this.components);
            this.timer_test = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_outvolt_CH3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_prevolt_CH3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_voltage_CH3)).BeginInit();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_outvolt_CH2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_prevolt_CH2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_voltage_CH2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.panel_Channel1.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_outvolt_CH1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_prevolt_CH1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_voltage_CH1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button_LEDoff);
            this.panel1.Controls.Add(this.button_LEDon);
            this.panel1.Controls.Add(this.checkBox_test);
            this.panel1.Controls.Add(this.button_set);
            this.panel1.Controls.Add(this.label_debug);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 73);
            this.panel1.TabIndex = 0;
            // 
            // button_LEDoff
            // 
            this.button_LEDoff.Location = new System.Drawing.Point(374, 40);
            this.button_LEDoff.Margin = new System.Windows.Forms.Padding(2);
            this.button_LEDoff.Name = "button_LEDoff";
            this.button_LEDoff.Size = new System.Drawing.Size(66, 21);
            this.button_LEDoff.TabIndex = 23;
            this.button_LEDoff.Text = "LED OFF";
            this.button_LEDoff.UseVisualStyleBackColor = true;
            this.button_LEDoff.Click += new System.EventHandler(this.button_LEDoff_Click);
            // 
            // button_LEDon
            // 
            this.button_LEDon.Location = new System.Drawing.Point(374, 16);
            this.button_LEDon.Margin = new System.Windows.Forms.Padding(2);
            this.button_LEDon.Name = "button_LEDon";
            this.button_LEDon.Size = new System.Drawing.Size(66, 21);
            this.button_LEDon.TabIndex = 22;
            this.button_LEDon.Text = "LED ON";
            this.button_LEDon.UseVisualStyleBackColor = true;
            this.button_LEDon.Click += new System.EventHandler(this.button_LEDon_Click);
            // 
            // checkBox_test
            // 
            this.checkBox_test.AutoSize = true;
            this.checkBox_test.Location = new System.Drawing.Point(720, 32);
            this.checkBox_test.Name = "checkBox_test";
            this.checkBox_test.Size = new System.Drawing.Size(54, 17);
            this.checkBox_test.TabIndex = 21;
            this.checkBox_test.Text = "TEST";
            this.checkBox_test.UseVisualStyleBackColor = true;
            this.checkBox_test.CheckedChanged += new System.EventHandler(this.checkBox_test_CheckedChanged);
            // 
            // button_set
            // 
            this.button_set.Location = new System.Drawing.Point(463, 16);
            this.button_set.Margin = new System.Windows.Forms.Padding(2);
            this.button_set.Name = "button_set";
            this.button_set.Size = new System.Drawing.Size(56, 41);
            this.button_set.TabIndex = 20;
            this.button_set.Text = "Ethernet Setting ";
            this.button_set.UseVisualStyleBackColor = true;
            this.button_set.Click += new System.EventHandler(this.button_set_Click);
            // 
            // label_debug
            // 
            this.label_debug.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_debug.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_debug.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_debug.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_debug.Location = new System.Drawing.Point(523, 23);
            this.label_debug.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_debug.Name = "label_debug";
            this.label_debug.Size = new System.Drawing.Size(183, 31);
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
            this.groupBox2.Size = new System.Drawing.Size(356, 73);
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
            this.label_SerialStatus.Location = new System.Drawing.Point(241, 23);
            this.label_SerialStatus.Name = "label_SerialStatus";
            this.label_SerialStatus.Size = new System.Drawing.Size(43, 31);
            this.label_SerialStatus.TabIndex = 19;
            this.label_SerialStatus.Text = "Close";
            this.label_SerialStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_OpenClose
            // 
            this.button_OpenClose.Location = new System.Drawing.Point(289, 19);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 538);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label_pg_CH3);
            this.panel3.Controls.Add(this.label_oc_CH3);
            this.panel3.Controls.Add(this.groupBox13);
            this.panel3.Controls.Add(this.groupBox8);
            this.panel3.Controls.Add(this.groupBox9);
            this.panel3.Controls.Add(this.checkBox_Enable_CH3);
            this.panel3.Controls.Add(this.groupBox10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(532, 10);
            this.panel3.Margin = new System.Windows.Forms.Padding(10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(242, 518);
            this.panel3.TabIndex = 2;
            // 
            // label_pg_CH3
            // 
            this.label_pg_CH3.AutoSize = true;
            this.label_pg_CH3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_pg_CH3.Location = new System.Drawing.Point(168, 27);
            this.label_pg_CH3.Name = "label_pg_CH3";
            this.label_pg_CH3.Size = new System.Drawing.Size(24, 15);
            this.label_pg_CH3.TabIndex = 13;
            this.label_pg_CH3.Text = "PG";
            // 
            // label_oc_CH3
            // 
            this.label_oc_CH3.AutoSize = true;
            this.label_oc_CH3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_oc_CH3.Location = new System.Drawing.Point(198, 27);
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
            this.groupBox13.Location = new System.Drawing.Point(16, 424);
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
            this.label_output_CH3.Text = "Output ";
            this.label_output_CH3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label6);
            this.groupBox8.Controls.Add(this.label8);
            this.groupBox8.Controls.Add(this.numericUpDown_outvolt_CH3);
            this.groupBox8.Controls.Add(this.numericUpDown_prevolt_CH3);
            this.groupBox8.Controls.Add(this.radioButton_negative_CH3);
            this.groupBox8.Controls.Add(this.radioButton_positive_CH3);
            this.groupBox8.Controls.Add(this.label_info_voltage_CH3);
            this.groupBox8.Controls.Add(this.numericUpDown_voltage_CH3);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox8.Location = new System.Drawing.Point(16, 266);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(206, 146);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Setting:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(117, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Out Reg:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(19, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Pre Reg:";
            // 
            // numericUpDown_outvolt_CH3
            // 
            this.numericUpDown_outvolt_CH3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_outvolt_CH3.Location = new System.Drawing.Point(120, 112);
            this.numericUpDown_outvolt_CH3.Maximum = new decimal(new int[] {
            4095,
            0,
            0,
            0});
            this.numericUpDown_outvolt_CH3.Name = "numericUpDown_outvolt_CH3";
            this.numericUpDown_outvolt_CH3.Size = new System.Drawing.Size(63, 26);
            this.numericUpDown_outvolt_CH3.TabIndex = 9;
            this.numericUpDown_outvolt_CH3.ValueChanged += new System.EventHandler(this.numericUpDown_outvolt_CH3_ValueChanged);
            // 
            // numericUpDown_prevolt_CH3
            // 
            this.numericUpDown_prevolt_CH3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_prevolt_CH3.Location = new System.Drawing.Point(22, 112);
            this.numericUpDown_prevolt_CH3.Maximum = new decimal(new int[] {
            4095,
            0,
            0,
            0});
            this.numericUpDown_prevolt_CH3.Name = "numericUpDown_prevolt_CH3";
            this.numericUpDown_prevolt_CH3.Size = new System.Drawing.Size(63, 26);
            this.numericUpDown_prevolt_CH3.TabIndex = 8;
            this.numericUpDown_prevolt_CH3.ValueChanged += new System.EventHandler(this.numericUpDown_prevolt_CH3_ValueChanged);
            // 
            // radioButton_negative_CH3
            // 
            this.radioButton_negative_CH3.AutoSize = true;
            this.radioButton_negative_CH3.Location = new System.Drawing.Point(117, 70);
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
            this.radioButton_positive_CH3.Location = new System.Drawing.Point(12, 70);
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
            this.label_info_voltage_CH3.Location = new System.Drawing.Point(16, 37);
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
            this.numericUpDown_voltage_CH3.Location = new System.Drawing.Point(101, 20);
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
            this.groupBox9.Location = new System.Drawing.Point(16, 163);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(206, 97);
            this.groupBox9.TabIndex = 4;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Current:";
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
            // checkBox_Enable_CH3
            // 
            this.checkBox_Enable_CH3.AutoSize = true;
            this.checkBox_Enable_CH3.Location = new System.Drawing.Point(20, 25);
            this.checkBox_Enable_CH3.Name = "checkBox_Enable_CH3";
            this.checkBox_Enable_CH3.Size = new System.Drawing.Size(59, 17);
            this.checkBox_Enable_CH3.TabIndex = 3;
            this.checkBox_Enable_CH3.Text = "Enable";
            this.checkBox_Enable_CH3.UseVisualStyleBackColor = true;
            this.checkBox_Enable_CH3.CheckedChanged += new System.EventHandler(this.checkBox_Enable_CH3_CheckedChanged);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.bar_voltage_CH3);
            this.groupBox10.Controls.Add(this.label_voltage_CH3);
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox10.Location = new System.Drawing.Point(16, 61);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(206, 97);
            this.groupBox10.TabIndex = 1;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Voltage:";
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
            this.label11.Size = new System.Drawing.Size(240, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Channel 3";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label_pg_CH2);
            this.panel2.Controls.Add(this.label_oc_CH2);
            this.panel2.Controls.Add(this.groupBox12);
            this.panel2.Controls.Add(this.groupBox5);
            this.panel2.Controls.Add(this.groupBox6);
            this.panel2.Controls.Add(this.checkBox_Enable_CH2);
            this.panel2.Controls.Add(this.groupBox7);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(271, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 518);
            this.panel2.TabIndex = 1;
            // 
            // label_pg_CH2
            // 
            this.label_pg_CH2.AutoSize = true;
            this.label_pg_CH2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_pg_CH2.Location = new System.Drawing.Point(168, 28);
            this.label_pg_CH2.Name = "label_pg_CH2";
            this.label_pg_CH2.Size = new System.Drawing.Size(24, 15);
            this.label_pg_CH2.TabIndex = 11;
            this.label_pg_CH2.Text = "PG";
            // 
            // label_oc_CH2
            // 
            this.label_oc_CH2.AutoSize = true;
            this.label_oc_CH2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_oc_CH2.Location = new System.Drawing.Point(198, 28);
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
            this.groupBox12.Location = new System.Drawing.Point(16, 424);
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
            this.label_output_CH2.Text = "Output ";
            this.label_output_CH2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.numericUpDown_outvolt_CH2);
            this.groupBox5.Controls.Add(this.numericUpDown_prevolt_CH2);
            this.groupBox5.Controls.Add(this.radioButton_negative_CH2);
            this.groupBox5.Controls.Add(this.radioButton_positive_CH2);
            this.groupBox5.Controls.Add(this.label_info_voltage_CH2);
            this.groupBox5.Controls.Add(this.numericUpDown_voltage_CH2);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox5.Location = new System.Drawing.Point(16, 266);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(206, 146);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Setting:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(117, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Out Reg:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(19, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pre Reg:";
            // 
            // numericUpDown_outvolt_CH2
            // 
            this.numericUpDown_outvolt_CH2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_outvolt_CH2.Location = new System.Drawing.Point(120, 112);
            this.numericUpDown_outvolt_CH2.Maximum = new decimal(new int[] {
            4095,
            0,
            0,
            0});
            this.numericUpDown_outvolt_CH2.Name = "numericUpDown_outvolt_CH2";
            this.numericUpDown_outvolt_CH2.Size = new System.Drawing.Size(63, 26);
            this.numericUpDown_outvolt_CH2.TabIndex = 9;
            this.numericUpDown_outvolt_CH2.ValueChanged += new System.EventHandler(this.numericUpDown_outvolt_CH2_ValueChanged);
            // 
            // numericUpDown_prevolt_CH2
            // 
            this.numericUpDown_prevolt_CH2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_prevolt_CH2.Location = new System.Drawing.Point(22, 112);
            this.numericUpDown_prevolt_CH2.Maximum = new decimal(new int[] {
            4095,
            0,
            0,
            0});
            this.numericUpDown_prevolt_CH2.Name = "numericUpDown_prevolt_CH2";
            this.numericUpDown_prevolt_CH2.Size = new System.Drawing.Size(63, 26);
            this.numericUpDown_prevolt_CH2.TabIndex = 8;
            this.numericUpDown_prevolt_CH2.ValueChanged += new System.EventHandler(this.numericUpDown_prevolt_CH2_ValueChanged);
            // 
            // radioButton_negative_CH2
            // 
            this.radioButton_negative_CH2.AutoSize = true;
            this.radioButton_negative_CH2.Location = new System.Drawing.Point(117, 70);
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
            this.radioButton_positive_CH2.Location = new System.Drawing.Point(12, 70);
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
            this.label_info_voltage_CH2.Location = new System.Drawing.Point(16, 37);
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
            this.numericUpDown_voltage_CH2.Location = new System.Drawing.Point(101, 20);
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
            this.groupBox6.Location = new System.Drawing.Point(16, 163);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(206, 97);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Current:";
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
            // checkBox_Enable_CH2
            // 
            this.checkBox_Enable_CH2.AutoSize = true;
            this.checkBox_Enable_CH2.Location = new System.Drawing.Point(20, 25);
            this.checkBox_Enable_CH2.Name = "checkBox_Enable_CH2";
            this.checkBox_Enable_CH2.Size = new System.Drawing.Size(59, 17);
            this.checkBox_Enable_CH2.TabIndex = 3;
            this.checkBox_Enable_CH2.Text = "Enable";
            this.checkBox_Enable_CH2.UseVisualStyleBackColor = true;
            this.checkBox_Enable_CH2.CheckedChanged += new System.EventHandler(this.checkBox_Enable_CH2_CheckedChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.bar_voltage_CH2);
            this.groupBox7.Controls.Add(this.label_voltage_CH2);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox7.Location = new System.Drawing.Point(16, 61);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(206, 97);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Voltage:";
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
            this.label7.Size = new System.Drawing.Size(239, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Channel 2";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Channel1
            // 
            this.panel_Channel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Channel1.Controls.Add(this.label_pg_CH1);
            this.panel_Channel1.Controls.Add(this.label_oc_CH1);
            this.panel_Channel1.Controls.Add(this.checkBox_Enable_CH1);
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
            this.panel_Channel1.Size = new System.Drawing.Size(241, 518);
            this.panel_Channel1.TabIndex = 0;
            // 
            // label_pg_CH1
            // 
            this.label_pg_CH1.AutoSize = true;
            this.label_pg_CH1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_pg_CH1.Location = new System.Drawing.Point(168, 28);
            this.label_pg_CH1.Name = "label_pg_CH1";
            this.label_pg_CH1.Size = new System.Drawing.Size(24, 15);
            this.label_pg_CH1.TabIndex = 9;
            this.label_pg_CH1.Text = "PG";
            // 
            // label_oc_CH1
            // 
            this.label_oc_CH1.AutoSize = true;
            this.label_oc_CH1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_oc_CH1.Location = new System.Drawing.Point(198, 28);
            this.label_oc_CH1.Name = "label_oc_CH1";
            this.label_oc_CH1.Size = new System.Drawing.Size(24, 15);
            this.label_oc_CH1.TabIndex = 8;
            this.label_oc_CH1.Text = "OC";
            // 
            // checkBox_Enable_CH1
            // 
            this.checkBox_Enable_CH1.AutoSize = true;
            this.checkBox_Enable_CH1.Location = new System.Drawing.Point(17, 26);
            this.checkBox_Enable_CH1.Name = "checkBox_Enable_CH1";
            this.checkBox_Enable_CH1.Size = new System.Drawing.Size(59, 17);
            this.checkBox_Enable_CH1.TabIndex = 7;
            this.checkBox_Enable_CH1.Text = "Enable";
            this.checkBox_Enable_CH1.UseVisualStyleBackColor = true;
            this.checkBox_Enable_CH1.CheckedChanged += new System.EventHandler(this.checkBox_Enable_CH1_CheckedChanged);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.button_outputOFF_CH1);
            this.groupBox11.Controls.Add(this.button_outputON_CH1);
            this.groupBox11.Controls.Add(this.label_output_CH1);
            this.groupBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox11.Location = new System.Drawing.Point(17, 424);
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
            this.label_output_CH1.Text = "Output ";
            this.label_output_CH1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.numericUpDown_outvolt_CH1);
            this.groupBox4.Controls.Add(this.numericUpDown_prevolt_CH1);
            this.groupBox4.Controls.Add(this.radioButton_negative_CH1);
            this.groupBox4.Controls.Add(this.radioButton_positive_CH1);
            this.groupBox4.Controls.Add(this.label_info_voltage_CH1);
            this.groupBox4.Controls.Add(this.numericUpDown_voltage_CH1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox4.Location = new System.Drawing.Point(16, 266);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(206, 146);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Setting:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(117, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Out Reg:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(19, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pre Reg:";
            // 
            // numericUpDown_outvolt_CH1
            // 
            this.numericUpDown_outvolt_CH1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_outvolt_CH1.Location = new System.Drawing.Point(120, 112);
            this.numericUpDown_outvolt_CH1.Maximum = new decimal(new int[] {
            4095,
            0,
            0,
            0});
            this.numericUpDown_outvolt_CH1.Name = "numericUpDown_outvolt_CH1";
            this.numericUpDown_outvolt_CH1.Size = new System.Drawing.Size(63, 26);
            this.numericUpDown_outvolt_CH1.TabIndex = 7;
            this.numericUpDown_outvolt_CH1.ValueChanged += new System.EventHandler(this.numericUpDown_outvolt_CH1_ValueChanged);
            // 
            // numericUpDown_prevolt_CH1
            // 
            this.numericUpDown_prevolt_CH1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_prevolt_CH1.Location = new System.Drawing.Point(22, 112);
            this.numericUpDown_prevolt_CH1.Maximum = new decimal(new int[] {
            4095,
            0,
            0,
            0});
            this.numericUpDown_prevolt_CH1.Name = "numericUpDown_prevolt_CH1";
            this.numericUpDown_prevolt_CH1.Size = new System.Drawing.Size(63, 26);
            this.numericUpDown_prevolt_CH1.TabIndex = 6;
            this.numericUpDown_prevolt_CH1.ValueChanged += new System.EventHandler(this.numericUpDown_prevolt_CH1_ValueChanged);
            // 
            // radioButton_negative_CH1
            // 
            this.radioButton_negative_CH1.AutoSize = true;
            this.radioButton_negative_CH1.Location = new System.Drawing.Point(117, 70);
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
            this.radioButton_positive_CH1.Location = new System.Drawing.Point(12, 70);
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
            this.label_info_voltage_CH1.Location = new System.Drawing.Point(16, 37);
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
            this.numericUpDown_voltage_CH1.Location = new System.Drawing.Point(101, 20);
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
            this.groupBox3.Location = new System.Drawing.Point(16, 163);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(206, 97);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Current:";
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
            this.groupBox1.Location = new System.Drawing.Point(16, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 97);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Voltage:";
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
            this.label1.Size = new System.Drawing.Size(239, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Channel 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // XserialPort
            // 
            this.XserialPort.BaudRate = 115200;
            // 
            // timer_Read
            // 
            this.timer_Read.Enabled = true;
            this.timer_Read.Interval = 10;
            this.timer_Read.Tick += new System.EventHandler(this.timer_Read_Tick);
            // 
            // timer_req
            // 
            this.timer_req.Interval = 200;
            this.timer_req.Tick += new System.EventHandler(this.timer_req_Tick);
            // 
            // timer_test
            // 
            this.timer_test.Tick += new System.EventHandler(this.timer_test_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 650);
            this.MinimumSize = new System.Drawing.Size(800, 650);
            this.Name = "Form1";
            this.Text = "High Voltage Power Supply";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_outvolt_CH3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_prevolt_CH3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_voltage_CH3)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_outvolt_CH2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_prevolt_CH2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_voltage_CH2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.panel_Channel1.ResumeLayout(false);
            this.panel_Channel1.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_outvolt_CH1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_prevolt_CH1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_voltage_CH1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.CheckBox checkBox_Enable_CH3;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Button button_outputOFF_CH2;
        private System.Windows.Forms.Button button_outputON_CH2;
        private System.Windows.Forms.Label label_output_CH2;
        private System.Windows.Forms.CheckBox checkBox_Enable_CH2;
        private System.Windows.Forms.CheckBox checkBox_Enable_CH1;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Button button_outputOFF_CH1;
        private System.Windows.Forms.Button button_outputON_CH1;
        private System.Windows.Forms.Label label_output_CH1;
        private System.Windows.Forms.Timer timer_Read;
        private System.Windows.Forms.Label label_debug;
        private System.Windows.Forms.Button button_set;
        private System.Windows.Forms.Timer timer_req;
        private System.Windows.Forms.NumericUpDown numericUpDown_outvolt_CH3;
        private System.Windows.Forms.NumericUpDown numericUpDown_prevolt_CH3;
        private System.Windows.Forms.NumericUpDown numericUpDown_outvolt_CH2;
        private System.Windows.Forms.NumericUpDown numericUpDown_prevolt_CH2;
        private System.Windows.Forms.NumericUpDown numericUpDown_outvolt_CH1;
        private System.Windows.Forms.NumericUpDown numericUpDown_prevolt_CH1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_pg_CH3;
        private System.Windows.Forms.Label label_oc_CH3;
        private System.Windows.Forms.Label label_pg_CH2;
        private System.Windows.Forms.Label label_oc_CH2;
        private System.Windows.Forms.Label label_pg_CH1;
        private System.Windows.Forms.Label label_oc_CH1;
        private System.Windows.Forms.CheckBox checkBox_test;
        private System.Windows.Forms.Timer timer_test;
        private System.Windows.Forms.TextBox textBox_IP;
        private System.Windows.Forms.RadioButton radioButton_UDP;
        private System.Windows.Forms.RadioButton radioButton_Serial;
        private System.Windows.Forms.Button button_LEDoff;
        private System.Windows.Forms.Button button_LEDon;
    }
}

