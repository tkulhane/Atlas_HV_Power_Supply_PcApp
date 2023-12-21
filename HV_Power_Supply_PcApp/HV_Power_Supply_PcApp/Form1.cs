using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HV_Power_Supply_GUI_ver._1
{
    public partial class Form1 : Form
    {
        Communication communication;

        private uint device_ip_address;
        private uint device_net_mask;
        private uint device_gateway;
        private bool device_connected;

        public Form1()
        {
            InitializeComponent();
            communication = new Communication(XserialPort,5005, ExecuteCommand);
        }

        
       

        private void Channel_1_Enable(bool Enable)
        {
            
            //button_output_CH1.Enabled = Enable;
            numericUpDown_voltage_CH1.Enabled = Enable;
            radioButton_positive_CH1.Enabled = Enable;
            radioButton_negative_CH1.Enabled = Enable;
            label_info_voltage_CH1.Enabled = Enable;

            label_voltage_CH1.Enabled = Enable;
            label_current_CH1.Enabled = Enable;

            bar_voltage_CH1.Enabled = Enable;
            bar_current_CH1.Enabled = Enable;

            label_output_CH1.Enabled = Enable;

            if (Enable)
            {
                communication.SendCommand(Communication.eCommandCode.enable_CH1, 1);
                
                label_voltage_CH1.Text = "V";
                label_current_CH1.Text = "uA";
            }
            else
            {
                communication.SendCommand(Communication.eCommandCode.enable_CH1, 0);

                label_voltage_CH1.Text = "---";
                label_current_CH1.Text = "---";
                bar_voltage_CH1.value = 0;
                bar_current_CH1.value = 0;

            }
        }

        //scan serial ports
        private void button_PortScan_Click(object sender, EventArgs e)
        {
            comboBoxPorts.Items.Clear();

            foreach (String s in communication.GetPortNames())
            {
                comboBoxPorts.Items.Add(s);
            }


            if (comboBoxPorts.Items.Count > 0)
            {
                comboBoxPorts.SelectedIndex = 0;
            }

            if (communication.IsOpen())
            {
                label_SerialStatus.Text = "Open";
            }
            else
            {
                label_SerialStatus.Text = "Close";
            }

        }

        //open/close serial port
        private void button_OpenClose_Click(object sender, EventArgs e)
        {
            Communication.eCommunicationType comm = communication.GetCommunicationType();

            if(comm == Communication.eCommunicationType.serial) 
            {
                communication.Close_Serial();
                label_SerialStatus.Text = "Close";
                timer_req.Enabled = false;
                //timer_Read.Enabled = false;
                CommunicationControlEnable(true);
                return;
            }

            else if(comm == Communication.eCommunicationType.udp) 
            {
                communication.Close_UDP();
                label_SerialStatus.Text = "Close";
                timer_req.Enabled = false;
                CommunicationControlEnable(true);
                return;
            }
            

            if (radioButton_Serial.Checked == true) 
            {
                if (comboBoxPorts.SelectedIndex < 0)
                {
                    MessageBox.Show("Nevybran port", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                communication.Open_Serial(comboBoxPorts.SelectedItem as String);
            }         
            else if(radioButton_UDP.Checked == true) 
            {
                communication.Open_UDP(textBox_IP.Text);
            }


            comm = communication.GetCommunicationType();

            if (comm == Communication.eCommunicationType.serial)
            {
                label_SerialStatus.Text = "Open Serial";

                communication.SendCommand(Communication.eCommandCode.getsetting, 0);
                communication.SendCommand(Communication.eCommandCode.ip_getsetting, 0);

                timer_req.Interval = 400;
                timer_req.Enabled = true;

                CommunicationControlEnable(false);

            }
            else if (comm == Communication.eCommunicationType.udp)
            {
                label_SerialStatus.Text = "Open UDP";


                communication.SendCommand(Communication.eCommandCode.ip_store_endpoint, 0);
                communication.SendCommand(Communication.eCommandCode.getsetting, 0);           
                communication.SendCommand(Communication.eCommandCode.ip_getsetting, 0);

                timer_req.Interval = 200;
                timer_req.Enabled = true;

                CommunicationControlEnable(false);
            }
            else 
            {
                label_SerialStatus.Text = "Close";
                CommunicationControlEnable(true);
            }
        }

        private void CommunicationControlEnable(bool Enable) 
        {
            radioButton_UDP.Enabled = Enable;
            radioButton_Serial.Enabled = Enable;
            button_PortScan.Enabled = Enable;
            comboBoxPorts.Enabled = Enable;
            textBox_IP.Enabled = Enable;
        }

        private void button_set_Click(object sender, EventArgs e)
        {
            communication.SendCommand(Communication.eCommandCode.ip_getsetting, 0);
            Form_Setting form = new Form_Setting();

            form.xip_address = device_ip_address;
            form.xnet_mask = device_net_mask;
            form.xgateway = device_gateway;
            form.xserial = communication;
            
            form.ShowDialog();
            DialogResult fdr= form.DialogResult;

            if (fdr == DialogResult.OK)
            {
                device_ip_address = form.xip_address;
                device_net_mask = form.xnet_mask;
                device_gateway = form.xgateway;

                
                textBox_IP.Text = form.string_from_ip(device_ip_address);
            }
        }


        //channels enable checkBoxes-------------------------------------------------------------------------------------
        private void checkBox_Enable_CH1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Enable_CH1.Checked)
            {
                //Channel_1_Enable(true);
                communication.SendCommand(Communication.eCommandCode.enable_CH1, 1);
            }
            else
            {
                //Channel_1_Enable(false);
                communication.SendCommand(Communication.eCommandCode.enable_CH1, 0);
            }
        }

        private void checkBox_Enable_CH2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Enable_CH2.Checked)
            {
                //Channel_1_Enable(true);
                communication.SendCommand(Communication.eCommandCode.enable_CH2, 1);
            }
            else
            {
                //Channel_1_Enable(false);
                communication.SendCommand(Communication.eCommandCode.enable_CH2, 0);
            }
        }

        private void checkBox_Enable_CH3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Enable_CH3.Checked)
            {
                //Channel_1_Enable(true);
                communication.SendCommand(Communication.eCommandCode.enable_CH3, 1);
            }
            else
            {
                //Channel_1_Enable(false);
                communication.SendCommand(Communication.eCommandCode.enable_CH3, 0);
            }
        }

        //voltage setting numericUpDowns---------------------------------------------------------------------------------
        private void numericUpDown_voltage_CH1_ValueChanged(object sender, EventArgs e)
        {
            communication.SendCommand(Communication.eCommandCode.set_voltage_CH1, (uint)numericUpDown_voltage_CH1.Value);
        }

        private void numericUpDown_voltage_CH2_ValueChanged(object sender, EventArgs e)
        {
            communication.SendCommand(Communication.eCommandCode.set_voltage_CH2, (uint)numericUpDown_voltage_CH2.Value);
        }

        private void numericUpDown_voltage_CH3_ValueChanged(object sender, EventArgs e)
        {
            communication.SendCommand(Communication.eCommandCode.set_voltage_CH3, (uint)numericUpDown_voltage_CH3.Value);
        }

        //channels positive radioButtons---------------------------------------------------------------------------------
        private void radioButton_positive_CH1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton_positive_CH1.Checked)
                communication.SendCommand(Communication.eCommandCode.polarity_CH1, 1);
        }

        private void radioButton_positive_CH2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_positive_CH2.Checked)
                communication.SendCommand(Communication.eCommandCode.polarity_CH2, 1);
        }

        private void radioButton_positive_CH3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_positive_CH3.Checked)
                communication.SendCommand(Communication.eCommandCode.polarity_CH3, 1);
        }

        //channels negative radioButtons---------------------------------------------------------------------------------
        private void radioButton_negative_CH1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_negative_CH1.Checked)
                communication.SendCommand(Communication.eCommandCode.polarity_CH1, 2);
        }

        private void radioButton_negative_CH2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_negative_CH2.Checked)
                communication.SendCommand(Communication.eCommandCode.polarity_CH2, 2);
        }

        private void radioButton_negative_CH3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_negative_CH3.Checked)
                communication.SendCommand(Communication.eCommandCode.polarity_CH3, 2);
        }

        //channels output ON---------------------------------------------------------------------------------
        private void button_outputON_CH1_Click(object sender, EventArgs e)
        {
            communication.SendCommand(Communication.eCommandCode.output_CH1, 1);
        }

        private void button_outputON_CH2_Click(object sender, EventArgs e)
        {
            communication.SendCommand(Communication.eCommandCode.output_CH2, 1);
        }

        private void button_outputON_CH3_Click(object sender, EventArgs e)
        {
            communication.SendCommand(Communication.eCommandCode.output_CH3, 1);
        }

        //channels output OFF---------------------------------------------------------------------------------
        private void button_outputOFF_CH1_Click(object sender, EventArgs e)
        {
            communication.SendCommand(Communication.eCommandCode.output_CH1, 0);
        }

        private void button_outputOFF_CH2_Click(object sender, EventArgs e)
        {
            communication.SendCommand(Communication.eCommandCode.output_CH2, 0);
        }

        private void button_outputOFF_CH3_Click(object sender, EventArgs e)
        {
            communication.SendCommand(Communication.eCommandCode.output_CH3, 0);
        }


        //receive from serial
        private void timer_Read_Tick(object sender, EventArgs e)
        {
            //communication.SerialReadCommand();
        }

        private void ExecuteCommand() 
        {
            switch (communication.ReadCommand_Code)
            {
                case Communication.eCommandCode.NON:
                    break;
               
                case Communication.eCommandCode.Connected:
                    if (communication.ReadCommand_Data == 1) device_connected = true;
                    break;


                case Communication.eCommandCode.enable_CH1:
                    if (communication.ReadCommand_Data > 0) checkBox_Enable_CH1.Checked = true;
                    else checkBox_Enable_CH1.Checked = false;
                    break;

                case Communication.eCommandCode.enable_CH2:
                    if (communication.ReadCommand_Data > 0) checkBox_Enable_CH2.Checked = true;
                    else checkBox_Enable_CH2.Checked = false;
                    break;

                case Communication.eCommandCode.enable_CH3:
                    if (communication.ReadCommand_Data > 0) checkBox_Enable_CH3.Checked = true;
                    else checkBox_Enable_CH3.Checked = false;
                    break;


                case Communication.eCommandCode.output_CH1:
                    if (communication.ReadCommand_Data > 0) label_output_CH1.Text = "ON";
                    else label_output_CH1.Text = "OFF";
                    break;

                case Communication.eCommandCode.output_CH2:
                    if (communication.ReadCommand_Data > 0) label_output_CH2.Text = "ON";
                    else label_output_CH2.Text = "OFF";
                    break;

                case Communication.eCommandCode.output_CH3:
                    if (communication.ReadCommand_Data > 0) label_output_CH3.Text = "ON";
                    else label_output_CH3.Text = "OFF";
                    break;

                case Communication.eCommandCode.polarity_CH1:
                    radioButton_positive_CH1.Checked = false;
                    radioButton_negative_CH1.Checked = false;

                    if (communication.ReadCommand_Data == 1) radioButton_positive_CH1.Checked = true;
                    else if (communication.ReadCommand_Data == 2) radioButton_negative_CH1.Checked = true;

                    break;

                case Communication.eCommandCode.polarity_CH2:
                    radioButton_positive_CH2.Checked = false;
                    radioButton_negative_CH2.Checked = false;

                    if (communication.ReadCommand_Data == 1) radioButton_positive_CH2.Checked = true;
                    else if (communication.ReadCommand_Data == 2) radioButton_negative_CH2.Checked = true;

                    break;


                case Communication.eCommandCode.polarity_CH3:
                    radioButton_positive_CH3.Checked = false;
                    radioButton_negative_CH3.Checked = false;

                    if (communication.ReadCommand_Data == 1) radioButton_positive_CH3.Checked = true;
                    else if (communication.ReadCommand_Data == 2) radioButton_negative_CH3.Checked = true;

                    break;

                case Communication.eCommandCode.get_voltage_CH1:
                    //label_voltage_CH1.Text = (communication.ReadCommand_Data / (float)100).ToString() + " V";
                    //bar_voltage_CH1.value = (int)(communication.ReadCommand_Data / (float)100);
                    label_voltage_CH1.Text = communication.ReadCommand_Data_float.ToString(".0") + " V";
                    bar_voltage_CH1.value = (int)communication.ReadCommand_Data_float;
                    bar_voltage_CH1.Invalidate();

                    label_debug.Text = communication.lineXXX;
                    break;

                case Communication.eCommandCode.get_voltage_CH2:
                    label_voltage_CH2.Text = communication.ReadCommand_Data_float.ToString(".0") + " V";
                    bar_voltage_CH2.value = (int)communication.ReadCommand_Data_float;
                    bar_voltage_CH2.Invalidate();
                    break;

                case Communication.eCommandCode.get_voltage_CH3:
                    label_voltage_CH3.Text = communication.ReadCommand_Data_float.ToString(".0") + " V";
                    bar_voltage_CH3.value = (int)communication.ReadCommand_Data_float;
                    bar_voltage_CH3.Invalidate();
                    break;


                case Communication.eCommandCode.get_current_CH1:
                    //label_current_CH1.Text = (communication.ReadCommand_Data / (float)1000).ToString() + " uA";
                    //bar_current_CH1.value = (int)(communication.ReadCommand_Data / (float)1000);
                    label_current_CH1.Text = communication.ReadCommand_Data_float.ToString(".00") + " uA";
                    bar_current_CH1.value = (int)communication.ReadCommand_Data_float;
                    bar_current_CH1.Invalidate();
                    break;

                case Communication.eCommandCode.get_current_CH2:
                    label_current_CH2.Text = communication.ReadCommand_Data_float.ToString(".00") + " uA";
                    bar_current_CH2.value = (int)communication.ReadCommand_Data_float;
                    bar_current_CH2.Invalidate();
                    break;

                case Communication.eCommandCode.get_current_CH3:
                    label_current_CH3.Text = communication.ReadCommand_Data_float.ToString(".00") + " uA";
                    bar_current_CH3.value = (int)communication.ReadCommand_Data_float;
                    bar_current_CH3.Invalidate();
                    break;


                case Communication.eCommandCode.set_voltage_CH1:
                    numericUpDown_voltage_CH1.Value = communication.ReadCommand_Data;
                    break;

                case Communication.eCommandCode.set_voltage_CH2:
                    numericUpDown_voltage_CH2.Value = communication.ReadCommand_Data;
                    break;

                case Communication.eCommandCode.set_voltage_CH3:
                    numericUpDown_voltage_CH3.Value = communication.ReadCommand_Data;
                    break;

                case Communication.eCommandCode.error_signals:
                    error_label(communication.ReadCommand_Data);
                    break;


                case Communication.eCommandCode.ip_get_myip:
                    device_ip_address = communication.ReadCommand_Data;
                    break;

                case Communication.eCommandCode.ip_get_mymask:
                   device_net_mask = communication.ReadCommand_Data;
                    break;

                case Communication.eCommandCode.ip_get_mygatew:
                    device_gateway = communication.ReadCommand_Data;
                    break;
            }

        }
        

        private void error_label(uint value) 
        {
            if ((value & (1 << 0)) > 0) label_pg_CH1.BackColor = Color.Red;
            else label_pg_CH1.BackColor = Color.Green;

            if ((value & (1 << 1)) > 0) label_pg_CH2.BackColor = Color.Red;
            else label_pg_CH2.BackColor = Color.Green;

            if ((value & (1 << 2)) > 0) label_pg_CH3.BackColor = Color.Red;
            else label_pg_CH3.BackColor = Color.Green;


            if ((value & (1 << 3)) > 0) label_oc_CH1.BackColor = Color.Red;
            else label_oc_CH1.BackColor = Color.Green;

            if ((value & (1 << 4)) > 0) label_oc_CH2.BackColor = Color.Red;
            else label_oc_CH2.BackColor = Color.Green;

            if ((value & (1 << 5)) > 0) label_oc_CH3.BackColor = Color.Red;
            else label_oc_CH3.BackColor = Color.Green;

        }

        int timer_setting = 0;
        private void timer_req_Tick(object sender, EventArgs e)
        {
            if (device_connected) 
            {
                label_SerialStatus.BackColor = Color.Green;
            }
            else 
            {
                label_SerialStatus.BackColor = Color.Red;
            }
            

            communication.SendCommand(Communication.eCommandCode.Connected, 1);
            device_connected = false;


            communication.SendCommand(Communication.eCommandCode.getallvalues, 0);
            
            if(timer_setting >= 5) 
            {
                communication.SendCommand(Communication.eCommandCode.getsetting, 0);
                timer_setting = 0;
            }
            timer_setting++;
        }




        private void numericUpDown_prevolt_CH1_ValueChanged(object sender, EventArgs e)
        {
            communication.SendCommand(Communication.eCommandCode.set_pre_reg_CH1, (uint)numericUpDown_prevolt_CH1.Value);
        }

        private void numericUpDown_prevolt_CH2_ValueChanged(object sender, EventArgs e)
        {
            communication.SendCommand(Communication.eCommandCode.set_pre_reg_CH2, (uint)numericUpDown_prevolt_CH2.Value);
        }

        private void numericUpDown_prevolt_CH3_ValueChanged(object sender, EventArgs e)
        {
            communication.SendCommand(Communication.eCommandCode.set_pre_reg_CH3, (uint)numericUpDown_prevolt_CH3.Value);
        }

        private void numericUpDown_outvolt_CH1_ValueChanged(object sender, EventArgs e)
        {
            communication.SendCommand(Communication.eCommandCode.set_out_reg_CH1, (uint)numericUpDown_outvolt_CH1.Value);
        }

        private void numericUpDown_outvolt_CH2_ValueChanged(object sender, EventArgs e)
        {
            communication.SendCommand(Communication.eCommandCode.set_out_reg_CH2, (uint)numericUpDown_outvolt_CH2.Value);
        }

        private void numericUpDown_outvolt_CH3_ValueChanged(object sender, EventArgs e)
        {
            communication.SendCommand(Communication.eCommandCode.set_out_reg_CH3, (uint)numericUpDown_outvolt_CH3.Value);
        }





      

    }
}
