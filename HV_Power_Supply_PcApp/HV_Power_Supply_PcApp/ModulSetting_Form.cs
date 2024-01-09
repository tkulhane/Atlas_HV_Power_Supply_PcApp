﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HV_Power_Supply_GUI_ver._1
{
    public partial class ModulSetting_Form : Form
    {


        internal delegate void efunction1(Communication.eCommandCode Command, UInt32 Data);
        efunction1 _FunctionSendData;

        internal delegate void efunction2(Communication.eCommandCode Command, float Data);
        efunction2 _FunctionSendData_Float;


        internal efunction1 FunctionSendData { get => _FunctionSendData; set => _FunctionSendData = value; }
        internal efunction2 FunctionSendData_Float { get => _FunctionSendData_Float; set => _FunctionSendData_Float = value; }

        ModulSetting_Data _ModulSettingData;

        internal ModulSetting_Data ModulSettingData { get => _ModulSettingData; set => _ModulSettingData = value; }

        public ModulSetting_Form()
        {
            InitializeComponent();

        }

        private void Form_Setting_Load(object sender, EventArgs e)
        {

            UpdateValues();
        }

        public void UpdateValues() 
        {
            textBox_ip.Text = string_from_ip(_ModulSettingData.ipAddress);
            textBox_nm.Text = string_from_ip(_ModulSettingData.netMask);
            textBox_gw.Text = string_from_ip(_ModulSettingData.gateWay);

            textBox_ch1_adc_voltage_k.Text = _ModulSettingData.ch1_adc_voltage_k.ToString();
            textBox_ch2_adc_voltage_k.Text = _ModulSettingData.ch2_adc_voltage_k.ToString();
            textBox_ch3_adc_voltage_k.Text = _ModulSettingData.ch3_adc_voltage_k.ToString();
            textBox_ch1_adc_current_k.Text = _ModulSettingData.ch1_adc_current_k.ToString();
            textBox_ch2_adc_current_k.Text = _ModulSettingData.ch2_adc_current_k.ToString();
            textBox_ch3_adc_current_k.Text = _ModulSettingData.ch3_adc_current_k.ToString();

            textBox_ch1_adc_voltage_q.Text = _ModulSettingData.ch1_adc_voltage_q.ToString();
            textBox_ch2_adc_voltage_q.Text = _ModulSettingData.ch2_adc_voltage_q.ToString();
            textBox_ch3_adc_voltage_q.Text = _ModulSettingData.ch3_adc_voltage_q.ToString();
            textBox_ch1_adc_current_q.Text = _ModulSettingData.ch1_adc_current_q.ToString();
            textBox_ch2_adc_current_q.Text = _ModulSettingData.ch2_adc_current_q.ToString();
            textBox_ch3_adc_current_q.Text = _ModulSettingData.ch3_adc_current_q.ToString();

            textBox_ch1_dac_k.Text = _ModulSettingData.ch2_dac_k.ToString();
            textBox_ch2_dac_k.Text = _ModulSettingData.ch2_dac_k.ToString();
            textBox_ch3_dac_k.Text = _ModulSettingData.ch3_dac_k.ToString();

            textBox_ch1_dac_q.Text = _ModulSettingData.ch2_dac_q.ToString();
            textBox_ch2_dac_q.Text = _ModulSettingData.ch2_dac_q.ToString();
            textBox_ch3_dac_q.Text = _ModulSettingData.ch3_dac_q.ToString();

            checkBox_EnableErrorExecute.Checked = GetBoolFromUint32(_ModulSettingData.EnableErrorExecute);
            checkBox_DisableInConnLost.Checked = GetBoolFromUint32(_ModulSettingData.DisableInConnLost);
            checkBox_CtrlOutWithEnable.Checked = GetBoolFromUint32(_ModulSettingData.CtrlOutWithEnable);
            checkBox_ErrorExecuteAutoRestart.Checked = GetBoolFromUint32(_ModulSettingData.ErrorExecuteAutoRestart);


        }

        private void SendAll()
        {
            _FunctionSendData(Communication.eCommandCode.ip_store_myip, ip_from_string(textBox_ip.Text));
            _FunctionSendData(Communication.eCommandCode.ip_store_mymask, ip_from_string(textBox_nm.Text));
            _FunctionSendData(Communication.eCommandCode.ip_store_mygatew, ip_from_string(textBox_gw.Text));

            SendFloat(Communication.eCommandCode.adc_set_k0, textBox_ch1_adc_voltage_k);
            SendFloat(Communication.eCommandCode.adc_set_k1, textBox_ch2_adc_voltage_k);
            SendFloat(Communication.eCommandCode.adc_set_k2, textBox_ch3_adc_voltage_k);
            SendFloat(Communication.eCommandCode.adc_set_k3, textBox_ch1_adc_current_k);
            SendFloat(Communication.eCommandCode.adc_set_k4, textBox_ch2_adc_current_k);
            SendFloat(Communication.eCommandCode.adc_set_k5, textBox_ch3_adc_current_k);

            SendFloat(Communication.eCommandCode.adc_set_q0, textBox_ch1_adc_voltage_q);
            SendFloat(Communication.eCommandCode.adc_set_q1, textBox_ch2_adc_voltage_q);
            SendFloat(Communication.eCommandCode.adc_set_q2, textBox_ch3_adc_voltage_q);
            SendFloat(Communication.eCommandCode.adc_set_q3, textBox_ch1_adc_current_q);
            SendFloat(Communication.eCommandCode.adc_set_q4, textBox_ch2_adc_current_q);
            SendFloat(Communication.eCommandCode.adc_set_q5, textBox_ch3_adc_current_q);

            SendFloat(Communication.eCommandCode.dac_set_k0, textBox_ch1_dac_k);
            SendFloat(Communication.eCommandCode.dac_set_k1, textBox_ch2_dac_k);
            SendFloat(Communication.eCommandCode.dac_set_k2, textBox_ch3_dac_k);
            SendFloat(Communication.eCommandCode.dac_set_q0, textBox_ch1_dac_q);
            SendFloat(Communication.eCommandCode.dac_set_q1, textBox_ch2_dac_q);
            SendFloat(Communication.eCommandCode.dac_set_q2, textBox_ch3_dac_q);

            SendBool(Communication.eCommandCode.CfgSet_EnableErrorExecute, checkBox_EnableErrorExecute.Checked);
            SendBool(Communication.eCommandCode.CfgSet_DisableInConnLost, checkBox_DisableInConnLost.Checked);
            SendBool(Communication.eCommandCode.CfgSet_CtrlOutWithChEnable, checkBox_CtrlOutWithEnable.Checked);
            SendBool(Communication.eCommandCode.CfgSet_ErrorExecuteAutoRestart, checkBox_ErrorExecuteAutoRestart.Checked);


        }

        private void SendFloat(Communication.eCommandCode cmd, TextBox textBox) 
        {
            float value;

            if(!float.TryParse(textBox.Text, out value)) 
            {
                return;
            }

            _FunctionSendData_Float(cmd, value);
        }

        private void SendBool(Communication.eCommandCode cmd, bool value) 
        {
            UInt32 value32;

            if (value) 
            {
                value32 = 1;
            }
            else 
            {
                value32 = 0;
            }

            _FunctionSendData(cmd, value32);
        }

        public bool GetBoolFromUint32(UInt32 data) 
        {
            if (data > 0) return true;
            else return false;
        }

        public uint ip_from_string(string s) 
        {
            string[] ip_bytes = s.Split('.');

            if(ip_bytes.Length != 4) 
            {
                MessageBox.Show("Chyba zadání", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            uint addr = 0;
            uint x;

            for(int i = 0; i < 4; i++) 
            {
                if (!uint.TryParse(ip_bytes[i], out x))
                {
                    MessageBox.Show("Chyba zadání", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }

                addr = addr | ((x & 0xff) << (3-i)*8);
            }

            MessageBox.Show(addr.ToString(),"", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return addr;

            
        }

        public string string_from_ip(uint ip) 
        {
            string s = string.Empty;
            byte[] ip_bytes = new byte[4];

            for(int i = 0; i < 4; i++) 
            {
                ip_bytes[i] = (byte)(ip >> (i * 8));
            }

            s = ip_bytes[3].ToString() + "." + ip_bytes[2].ToString() + "." + ip_bytes[1].ToString() + "." + ip_bytes[0].ToString();

            return s;
        }

        private void button_readFrom_Click(object sender, EventArgs e)
        {
            _FunctionSendData(Communication.eCommandCode.ip_getsetting, 0);
            _FunctionSendData(Communication.eCommandCode.adc_getallcoef, 0);
            _FunctionSendData(Communication.eCommandCode.dac_getallcoef, 0);
            _FunctionSendData(Communication.eCommandCode.Cfg_Get, 0);
        }

        private void button_DeviceReset_Click(object sender, EventArgs e)
        {
            _FunctionSendData(Communication.eCommandCode.reset, 0);
        }

        private void button_LoadDefault_Click(object sender, EventArgs e)
        {
            _FunctionSendData(Communication.eCommandCode.params_default, 0);
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            SendAll();
            _FunctionSendData(Communication.eCommandCode.params_default, 0);
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            SendAll();
        }


        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
