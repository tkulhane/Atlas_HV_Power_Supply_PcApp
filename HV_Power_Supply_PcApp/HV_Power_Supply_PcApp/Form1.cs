﻿using System;
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
        ModulSetting_Form ModulSettingForm;
        ModulSetting_Data ModulSettingData = new ModulSetting_Data();

        AppSetting appSetting = new AppSetting();

        Communication communication;


        float[] MeasVoltage = new float[3]; 

        public Form1()
        {
            InitializeComponent();
            communication = new Communication(XserialPort, ExecuteCommand);

            communication.comboBox_SerialPorts = comboBoxPorts;
            communication.textBox_ipAdress = textBox_IP;
            communication.textBox_ethPorts = textBox_EthPort;
            communication.radioButton_Serial = radioButton_Serial;
            communication.radioButton_Udp = radioButton_UDP;
            communication.label_Status = label_SerialStatus;
            communication.button_PortScan = button_PortScan;

            communication.RequestTimerFunction = timer_req_Tick;

            appSetting.communication = communication;
            
            appSetting.label_Name = label_Name;
            appSetting.label_nameCh1 = label_nameCh1;
            appSetting.label_nameCh2 = label_nameCh2;
            appSetting.label_nameCh3 = label_nameCh3;

            appSetting.NumericUpDown_setVoltages[0] = numericUpDown_voltage_CH1;
            appSetting.NumericUpDown_setVoltages[1] = numericUpDown_voltage_CH2;
            appSetting.NumericUpDown_setVoltages[2] = numericUpDown_voltage_CH3;
            appSetting.RadioButton_polarityPositive[0] = radioButton_positive_CH1;
            appSetting.RadioButton_polarityPositive[1] = radioButton_positive_CH2;
            appSetting.RadioButton_polarityPositive[2] = radioButton_positive_CH3;
            appSetting.RadioButton_polarityNegative[0] = radioButton_negative_CH1;
            appSetting.RadioButton_polarityNegative[1] = radioButton_negative_CH2;
            appSetting.RadioButton_polarityNegative[2] = radioButton_negative_CH3;


            appSetting.SettingLoad();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            appSetting.SettingSave();
        }

        //-------------------------------------------------------------------------------------------------------------------
        //app setting
        //-------------------------------------------------------------------------------------------------------------------
        private void button_LoadSetting_Click(object sender, EventArgs e)
        {
            appSetting.SettingLoad();
        }

        private void button_SaveSetting_Click(object sender, EventArgs e)
        {
            appSetting.SettingSave();
        }




        //-------------------------------------------------------------------------------------------------------------------
        //Reguest timer
        //-------------------------------------------------------------------------------------------------------------------
        int timer_setting = 0;
        private void timer_req_Tick()
        {

            communication.SendEndpoint();
            
          
            communication.SendCommand(Communication.eCommandCode.getallvalues, 0);

            if (timer_setting >= 5)
            {
                communication.SendCommand(Communication.eCommandCode.getsetting, 0);
                timer_setting = 0;
            }
            timer_setting++;

            

        }

        //-------------------------------------------------------------------------------------------------------------------
        //Execute command switch
        //-------------------------------------------------------------------------------------------------------------------
        private void ExecuteCommand()
        {
            switch (communication.ReadCommand_Code)
            {
                case Communication.eCommandCode.NON:
                    break;

                case Communication.eCommandCode.Connected:
                    if (communication.ReadCommand_Data == 1) communication.DeviceConnected();
                    break;


                case Communication.eCommandCode.enable_CH1:
                    if (communication.ReadCommand_Data > 0)
                    {
                        label_enable_CH1.Text = "ON";
                        label_enable_CH1.BackColor = Color.Green;
                    }
                    else
                    {
                        label_enable_CH1.Text = "OFF";
                        label_enable_CH1.BackColor = Color.Red;
                    }
                    break;

                case Communication.eCommandCode.enable_CH2:
                    if (communication.ReadCommand_Data > 0)
                    {
                        label_enable_CH2.Text = "ON";
                        label_enable_CH2.BackColor = Color.Green;
                    }
                    else
                    {
                        label_enable_CH2.Text = "OFF";
                        label_enable_CH2.BackColor = Color.Red;
                    }
                    break;

                case Communication.eCommandCode.enable_CH3:
                    if (communication.ReadCommand_Data > 0)
                    {
                        label_enable_CH3.Text = "ON";
                        label_enable_CH3.BackColor = Color.Green;
                    }
                    else
                    {
                        label_enable_CH3.Text = "OFF";
                        label_enable_CH3.BackColor = Color.Red;
                    }
                    break;


                case Communication.eCommandCode.output_CH1:
                    if (communication.ReadCommand_Data > 0)
                    {
                        label_output_CH1.Text = "ON";
                        label_output_CH1.BackColor = Color.Green;
                    }
                    else
                    {
                        label_output_CH1.Text = "OFF";
                        label_output_CH1.BackColor = Color.Red;
                    }
                    break;

                case Communication.eCommandCode.output_CH2:
                    if (communication.ReadCommand_Data > 0)
                    {
                        label_output_CH2.Text = "ON";
                        label_output_CH2.BackColor = Color.Green;
                    }
                    else
                    {
                        label_output_CH2.Text = "OFF";
                        label_output_CH2.BackColor = Color.Red;
                    }
                    break;

                case Communication.eCommandCode.output_CH3:
                    if (communication.ReadCommand_Data > 0)
                    {
                        label_output_CH3.Text = "ON";
                        label_output_CH3.BackColor = Color.Green;
                    }
                    else
                    {
                        label_output_CH3.Text = "OFF";
                        label_output_CH3.BackColor = Color.Red;
                    }
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
                    MeasVoltage[0] = communication.ReadCommand_Data_float;
                    label_voltage_CH1.Text = communication.ReadCommand_Data_float.ToString(".0") + " V";
                    bar_voltage_CH1.value = (int)communication.ReadCommand_Data_float;
                    bar_voltage_CH1.Invalidate();

                    break;

                case Communication.eCommandCode.get_voltage_CH2:
                    MeasVoltage[1] = communication.ReadCommand_Data_float;
                    label_voltage_CH2.Text = communication.ReadCommand_Data_float.ToString(".0") + " V";
                    bar_voltage_CH2.value = (int)communication.ReadCommand_Data_float;
                    bar_voltage_CH2.Invalidate();
                    break;

                case Communication.eCommandCode.get_voltage_CH3:
                    MeasVoltage[2] = communication.ReadCommand_Data_float;
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

                case Communication.eCommandCode.adc_get_k0:
                    ModulSettingData.ch1_adc_voltage_k = communication.ReadCommand_Data_float;
                    ModulSettingFormUpdate();
                    break;

                case Communication.eCommandCode.adc_get_k1:
                    ModulSettingData.ch2_adc_voltage_k = communication.ReadCommand_Data_float;
                    ModulSettingFormUpdate();
                    break;

                case Communication.eCommandCode.adc_get_k2:
                    ModulSettingData.ch3_adc_voltage_k = communication.ReadCommand_Data_float;
                    ModulSettingFormUpdate();
                    break;

                case Communication.eCommandCode.adc_get_k3:
                    ModulSettingData.ch1_adc_current_k = communication.ReadCommand_Data_float;
                    ModulSettingFormUpdate();
                    break;

                case Communication.eCommandCode.adc_get_k4:
                    ModulSettingData.ch2_adc_current_k = communication.ReadCommand_Data_float;
                    ModulSettingFormUpdate();
                    break;

                case Communication.eCommandCode.adc_get_k5:
                    ModulSettingData.ch3_adc_current_k = communication.ReadCommand_Data_float;
                    ModulSettingFormUpdate();
                    break;

                case Communication.eCommandCode.adc_get_q0:
                    ModulSettingData.ch1_adc_voltage_q = communication.ReadCommand_Data_float;
                    ModulSettingFormUpdate();
                    break;

                case Communication.eCommandCode.adc_get_q1:
                    ModulSettingData.ch2_adc_voltage_q = communication.ReadCommand_Data_float;
                    ModulSettingFormUpdate();
                    break;

                case Communication.eCommandCode.adc_get_q2:
                    ModulSettingData.ch3_adc_voltage_q = communication.ReadCommand_Data_float;
                    ModulSettingFormUpdate();
                    break;

                case Communication.eCommandCode.adc_get_q3:
                    ModulSettingData.ch1_adc_current_q = communication.ReadCommand_Data_float;
                    ModulSettingFormUpdate();
                    break;

                case Communication.eCommandCode.adc_get_q4:
                    ModulSettingData.ch2_adc_current_q = communication.ReadCommand_Data_float;
                    ModulSettingFormUpdate();
                    break;

                case Communication.eCommandCode.adc_get_q5:
                    ModulSettingData.ch3_adc_current_q = communication.ReadCommand_Data_float;
                    ModulSettingFormUpdate();
                    break;

                case Communication.eCommandCode.dac_get_k0:
                    ModulSettingData.ch1_dac_k = communication.ReadCommand_Data_float;
                    ModulSettingFormUpdate();
                    break;

                case Communication.eCommandCode.dac_get_k1:
                    ModulSettingData.ch2_dac_k = communication.ReadCommand_Data_float;
                    ModulSettingFormUpdate();
                    break;

                case Communication.eCommandCode.dac_get_k2:
                    ModulSettingData.ch3_dac_k = communication.ReadCommand_Data_float;
                    ModulSettingFormUpdate();
                    break;

                case Communication.eCommandCode.dac_get_q0:
                    ModulSettingData.ch1_dac_q = communication.ReadCommand_Data_float;
                    ModulSettingFormUpdate();
                    break;

                case Communication.eCommandCode.dac_get_q1:
                    ModulSettingData.ch2_dac_q = communication.ReadCommand_Data_float;
                    ModulSettingFormUpdate();
                    break;

                case Communication.eCommandCode.dac_get_q2:
                    ModulSettingData.ch3_dac_q = communication.ReadCommand_Data_float;
                    ModulSettingFormUpdate();
                    break;

                case Communication.eCommandCode.ip_get_mac_1:
                    ModulSettingData.macAddress_1 = communication.ReadCommand_Data;
                    break;

                case Communication.eCommandCode.ip_get_mac_2:
                    ModulSettingData.macAddress_2 = communication.ReadCommand_Data;
                    break;

                case Communication.eCommandCode.ip_get_UdpRecvPort:
                    ModulSettingData.udpRecvPort = communication.ReadCommand_Data;
                    break;

                case Communication.eCommandCode.ip_get_myip:
                        ModulSettingData.ipAddress = communication.ReadCommand_Data;
                        ModulSettingFormUpdate();
                    break;

                case Communication.eCommandCode.ip_get_mymask:
                    ModulSettingData.netMask = communication.ReadCommand_Data;
                    ModulSettingFormUpdate();
                    break;

                case Communication.eCommandCode.ip_get_mygatew:
                    ModulSettingData.gateWay = communication.ReadCommand_Data;
                    ModulSettingFormUpdate();
                    break;

                case Communication.eCommandCode.CfgGet_EnableErrorExecute:
                    ModulSettingData.EnableErrorExecute = communication.ReadCommand_Data;
                    ModulSettingFormUpdate();
                    break;

                case Communication.eCommandCode.CfgGet_DisableInConnLost:
                    ModulSettingData.DisableInConnLost = communication.ReadCommand_Data;
                    ModulSettingFormUpdate();
                    break;

                case Communication.eCommandCode.CfgGet_CtrlOutWithChEnable:
                    ModulSettingData.CtrlOutWithEnable = communication.ReadCommand_Data;
                    ModulSettingFormUpdate();
                    break;

                case Communication.eCommandCode.CfgGet_ErrorExecuteAutoRestart:
                    ModulSettingData.ErrorExecuteAutoRestart = communication.ReadCommand_Data;
                    ModulSettingFormUpdate();
                    break;

                case Communication.eCommandCode.CfgGet_EnableAdaptiveVoltTune:
                    ModulSettingData.EnableAdaptiveVoltageTune = communication.ReadCommand_Data;
                    ModulSettingFormUpdate();
                    break;

                case Communication.eCommandCode.voltRamp_get_volt:
                    ModulSettingData.VoltageRamp_VoltStep = communication.ReadCommand_Data;
                    ModulSettingFormUpdate();
                    break;

                case Communication.eCommandCode.voltRamp_get_time:
                    ModulSettingData.VoltageRamp_TimeStep = communication.ReadCommand_Data;
                    ModulSettingFormUpdate();
                    break;

                default: 
                    break;

            }

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

        //-------------------------------------------------------------------------------------------------------------------
        //Communication
        //-------------------------------------------------------------------------------------------------------------------
       //scan serial
        private void button_PortScan_Click(object sender, EventArgs e)
        {
            communication.scanSerialPorts();

        }

        //open/close serial port
        private void button_OpenClose_Click(object sender, EventArgs e)
        {
            communication.OpenClose();
        }





        

        //-------------------------------------------------------------------------------------------------------------------
        //Modul Setting form
        //-------------------------------------------------------------------------------------------------------------------
        private void button_set_Click(object sender, EventArgs e)
        {
            communication.SendCommand(Communication.eCommandCode.ip_getsetting, 0);
            communication.SendCommand(Communication.eCommandCode.adc_getallcoef, 0);
            communication.SendCommand(Communication.eCommandCode.dac_getallcoef, 0);
            communication.SendCommand(Communication.eCommandCode.Cfg_Get, 0);
            communication.SendCommand(Communication.eCommandCode.voltRamp_get_setting, 0);

            
            ModulSettingForm = new ModulSetting_Form();

            ModulSettingForm.FunctionSendData = communication.SendCommand;
            ModulSettingForm.FunctionSendData_Float = communication.SendCommand_Float;
            ModulSettingForm.ModulSettingData = ModulSettingData;
            ModulSettingForm.ShowDialog();
            DialogResult fdr= ModulSettingForm.DialogResult;

            if (fdr == DialogResult.OK)
            {


            }
        }

        private void button_Calibration_Click(object sender, EventArgs e)
        {
            communication.SendCommand(Communication.eCommandCode.adc_getallcoef, 0);
            communication.SendCommand(Communication.eCommandCode.dac_getallcoef, 0);

            
            Calibration_Form calibForm = new Calibration_Form();

            calibForm.FunctionSendData = communication.SendCommand;
            calibForm.FunctionSendData_Float = communication.SendCommand_Float;
            calibForm.MeasVoltage = MeasVoltage;

            calibForm.Show();

            DialogResult fdr = calibForm.DialogResult;
        }


        private void ModulSettingFormUpdate() 
        {
            if (ModulSettingForm == null) return;

            ModulSettingForm.ModulSettingData = ModulSettingData;
            ModulSettingForm.UpdateValues();
        }


        //-------------------------------------------------------------------------------------------------------------------
        //Channels setting elements
        //-------------------------------------------------------------------------------------------------------------------

        //channels enable buttons-------------------------------------------------------------------------------------
        private void button_ON_CH1_Click(object sender, EventArgs e)
        {
            communication.SendCommand(Communication.eCommandCode.enable_CH1, 1);
        }

        private void button_OFF_CH1_Click(object sender, EventArgs e)
        {
            communication.SendCommand(Communication.eCommandCode.enable_CH1, 0);
        }

        private void button_ON_CH2_Click(object sender, EventArgs e)
        {
            communication.SendCommand(Communication.eCommandCode.enable_CH2, 1);
        }

        private void button_OFF_CH2_Click(object sender, EventArgs e)
        {
            communication.SendCommand(Communication.eCommandCode.enable_CH2, 0);
        }

        private void button_ON_CH3_Click(object sender, EventArgs e)
        {
            communication.SendCommand(Communication.eCommandCode.enable_CH3, 1);
        }

        private void button_OFF_CH3_Click(object sender, EventArgs e)
        {
            communication.SendCommand(Communication.eCommandCode.enable_CH3, 0);
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




        private void button_LoadSetAllOn_Click(object sender, EventArgs e)
        {
            communication.SendCommand(Communication.eCommandCode.enable_CH1, 1);
            communication.SendCommand(Communication.eCommandCode.enable_CH2, 1);
            communication.SendCommand(Communication.eCommandCode.enable_CH3, 1);
        }

        private void button_AllOn_Click(object sender, EventArgs e)
        {
            communication.SendCommand(Communication.eCommandCode.enable_CH1, 1);
            communication.SendCommand(Communication.eCommandCode.enable_CH2, 1);
            communication.SendCommand(Communication.eCommandCode.enable_CH3, 1);
        }

        private void button_AllOff_Click(object sender, EventArgs e)
        {
            communication.SendCommand(Communication.eCommandCode.enable_CH1, 0);
            communication.SendCommand(Communication.eCommandCode.enable_CH2, 0);
            communication.SendCommand(Communication.eCommandCode.enable_CH3, 0);
        }
    }
}
