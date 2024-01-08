using System;
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

        private void btn_Save_Click(object sender, EventArgs e)
        {
            /*
            ip_address = ip_from_string(textBox_ip.Text);
            net_mask = ip_from_string(textBox_nm.Text);
            gateway = ip_from_string(textBox_gw.Text);

            serial.SendCommand(Communication.eCommandCode.ip_store_myip, ip_from_string(textBox_ip.Text));
            serial.SendCommand(Communication.eCommandCode.ip_store_mymask, ip_from_string(textBox_nm.Text));
            serial.SendCommand(Communication.eCommandCode.ip_store_mygatew, ip_from_string(textBox_gw.Text));

            DialogResult = DialogResult.OK;
            */
            this.Close();
        }



        private void button_exit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button_save_reset_Click(object sender, EventArgs e)
        {
            /*
            ip_address = ip_from_string(textBox_ip.Text);
            net_mask = ip_from_string(textBox_nm.Text);
            gateway = ip_from_string(textBox_gw.Text);

            serial.SendCommand(Communication.eCommandCode.ip_store_myip, ip_from_string(textBox_ip.Text));
            serial.SendCommand(Communication.eCommandCode.ip_store_mymask, ip_from_string(textBox_nm.Text));
            serial.SendCommand(Communication.eCommandCode.ip_store_mygatew, ip_from_string(textBox_gw.Text));
            serial.SendCommand(Communication.eCommandCode.reset,0);

            DialogResult = DialogResult.OK;
            */
            this.Close();
        }
    }
}
