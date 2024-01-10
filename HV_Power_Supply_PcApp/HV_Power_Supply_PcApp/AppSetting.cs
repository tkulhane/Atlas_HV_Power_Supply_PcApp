using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HV_Power_Supply_GUI_ver._1
{
    class AppSetting
    {
        static string SettingFileName = "AppSetting.txt";

        public Communication communication;


        public string sCommunication;
        public string sComPort;
        public string sIpAddress;
        public string sEthPort;

        public NumericUpDown[] NumericUpDown_setVoltages = new NumericUpDown[3];
        public RadioButton[] RadioButton_polarityPositive = new RadioButton[3];
        public RadioButton[] RadioButton_polarityNegative = new RadioButton[3];



        public enum eSettingCode : int
        {
            Non,
            Communiaction,
            COM_Port,
            IP_Address,
            ETH_Port,
            ch1_set,
            ch2_set,
            ch3_set,
            ch1_polarity,
            ch2_polarity,
            ch3_polarity
        }

        string[] SettingStrings =
        {
            "Non",
            "Communiaction",
            "COM_Port",
            "IP_Address",
            "ETH_Port",
            "ch1_set",
            "ch2_set",
            "ch3_set",
            "ch1_polarity",
            "ch2_polarity",
            "ch3_polarity",
        };



        public void SettingLoad() 
        {
            if (!File.Exists(SettingFileName))
            {
                //MessageBox.Show("The setting file does not exist.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            String[] lines = File.ReadAllLines(SettingFileName, Encoding.GetEncoding("Windows-1250"));

            if (lines.Length == 0) return;

            sCommunication = string.Empty;
            sComPort = string.Empty;
            sIpAddress = string.Empty;
            sEthPort = string.Empty;

            foreach (String s in lines)
            {
                SettingLoad_ProcessLine(s);
            }

            openCommunication();
        }

        static char[] caSplit = new char[] { '=' };
        private void SettingLoad_ProcessLine(string line)
        {
            if (line == string.Empty) return;

            String[] lineParts = line.Split(caSplit);
            if (lineParts.Length < 2) return;

            eSettingCode SettingCode = eSettingCode.Non;

            for (int i = 0;i< SettingStrings.Length; i++) 
            {
                if (lineParts[0].Equals(SettingStrings[i])) 
                {
                    SettingCode = (eSettingCode)i;
                }
            }

            if (SettingCode == eSettingCode.Non) return;

            switch (SettingCode) 
            {
                case eSettingCode.Communiaction:
                    sCommunication = lineParts[1];
                    break;

                case eSettingCode.COM_Port:
                    sComPort = lineParts[1];
                    break;

                case eSettingCode.IP_Address:
                    sIpAddress = lineParts[1];
                    break;

                case eSettingCode.ETH_Port:
                    sEthPort = lineParts[1];
                    break;

                case eSettingCode.ch1_set:
                    setVoltage(0, lineParts[1]);
                    break;

                case eSettingCode.ch2_set:
                    setVoltage(1, lineParts[1]);
                    break;

                case eSettingCode.ch3_set:
                    setVoltage(2, lineParts[1]);
                    break;

                case eSettingCode.ch1_polarity:
                    setPolarity(0, lineParts[1]);
                    break;

                case eSettingCode.ch2_polarity:
                    setPolarity(1, lineParts[1]);
                    break;

                case eSettingCode.ch3_polarity:
                    setPolarity(2, lineParts[1]);
                    break;

                default: 
                    break;
            }

        }

        public void openCommunication() 
        {
            if (sCommunication.Equals("Serial"))
            {
                communication.OpenSerialSetting(sComPort);
            }
            else if (sCommunication.Equals("Ethernet"))
            {
                communication.OpenUdpSetting(sIpAddress, sEthPort);
            }
        }

        public void setVoltage(int channel, string s)
        {
            UInt16 value;
            if(UInt16.TryParse(s, out value)) 
            {
                NumericUpDown_setVoltages[channel].Value = value;
            }
        }

        public void setPolarity(int channel, string s) 
        {
            if (s.Equals("Positive")) 
            {
                RadioButton_polarityPositive[channel].Checked = true;
            }
            else if (s.Equals("Negative"))
            {
                RadioButton_polarityNegative[channel].Checked = true;
            }
        }
        public void SettingSave() 
        {
            System.IO.File.WriteAllText(SettingFileName, string.Empty);

            using (StreamWriter writer = new StreamWriter(SettingFileName))
            {

                if(communication.GetCommunicationType() == Communication.eCommunicationType.serial) 
                {
                    writer.WriteLine(SettingStrings[(int)eSettingCode.Communiaction] + "=" + "Serial");
                    writer.WriteLine(SettingStrings[(int)eSettingCode.COM_Port] + "=" + communication.serialPortName);
                }
                else if(communication.GetCommunicationType() == Communication.eCommunicationType.udp) 
                {
                    writer.WriteLine(SettingStrings[(int)eSettingCode.Communiaction] + "=" + "Ethernet");
                    writer.WriteLine(SettingStrings[(int)eSettingCode.IP_Address] + "=" + communication.remoteIpAddress);
                    writer.WriteLine(SettingStrings[(int)eSettingCode.ETH_Port] + "=" + communication.remoteEthPort);
                }
                else 
                {
                    writer.WriteLine(SettingStrings[(int)eSettingCode.Communiaction] + "=" + "Non");
                }


                writer.WriteLine(SettingStrings[(int)eSettingCode.ch1_set] + "=" + NumericUpDown_setVoltages[0].Value.ToString());
                writer.WriteLine(SettingStrings[(int)eSettingCode.ch2_set] + "=" + NumericUpDown_setVoltages[1].Value.ToString());
                writer.WriteLine(SettingStrings[(int)eSettingCode.ch3_set] + "=" + NumericUpDown_setVoltages[2].Value.ToString());


                for(int i = 0; i < 3; i++) 
                {
                    if(RadioButton_polarityPositive[i].Checked && RadioButton_polarityNegative[i].Checked) 
                    {
                        writer.WriteLine(SettingStrings[(int)eSettingCode.ch1_polarity + i] + "=" + "x");
                    }
                    else if (RadioButton_polarityPositive[i].Checked)
                    {
                        writer.WriteLine(SettingStrings[(int)eSettingCode.ch1_polarity + i] + "=" + "Positive");
                    }
                    else if (RadioButton_polarityNegative[i].Checked)
                    {
                        writer.WriteLine(SettingStrings[(int)eSettingCode.ch1_polarity + i] + "=" + "Negative");
                    }
                    else
                    {
                        writer.WriteLine(SettingStrings[(int)eSettingCode.ch1_polarity + i] + "=" + "x");
                    }
                
                }




            }

        }

    }
}
