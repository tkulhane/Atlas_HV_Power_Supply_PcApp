using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HV_Power_Supply_GUI_ver._1
{
    class Communication
    {

        public enum eCommandCode : byte
        {
            NON,
            Connected,
            enable_CH1,
            enable_CH2,
            enable_CH3,
            output_CH1,
            output_CH2,
            output_CH3,
            set_voltage_CH1,
            set_voltage_CH2,
            set_voltage_CH3,
            polarity_CH1,
            polarity_CH2,
            polarity_CH3,
            get_voltage_CH1,
            get_voltage_CH2,
            get_voltage_CH3,
            get_current_CH1,
            get_current_CH2,
            get_current_CH3,
            error_signals,
            getallvalues,
            getsetting,
            thats_all,
            LED,
            ip_store_endpoint,
            ip_store_myip,
            ip_store_mymask,
            ip_store_mygatew,
            ip_get_myip,
            ip_get_mymask,
            ip_get_mygatew,
            ip_getsetting,
            adc_set_k0,
            adc_set_k1,
            adc_set_k2,
            adc_set_k3,
            adc_set_k4,
            adc_set_k5,
            adc_set_q0,
            adc_set_q1,
            adc_set_q2,
            adc_set_q3,
            adc_set_q4,
            adc_set_q5,
            adc_get_k0,
            adc_get_k1,
            adc_get_k2,
            adc_get_k3,
            adc_get_k4,
            adc_get_k5,
            adc_get_q0,
            adc_get_q1,
            adc_get_q2,
            adc_get_q3,
            adc_get_q4,
            adc_get_q5,
            dac_set_k0,
            dac_set_k1,
            dac_set_k2,
            dac_set_q0,
            dac_set_q1,
            dac_set_q2,
            dac_get_k0,
            dac_get_k1,
            dac_get_k2,
            dac_get_q0,
            dac_get_q1,
            dac_get_q2,
            adc_getallcoef,
            dac_getallcoef,
            set_pre_reg_CH1,
            set_pre_reg_CH2,
            set_pre_reg_CH3,
            set_out_reg_CH1,
            set_out_reg_CH2,
            set_out_reg_CH3,
            reset
        }

        string[] command_strings =
        {
    "NON",
    "Connected",
    "ch1_enable",
    "ch2_enable",
    "ch3_enable",
    "ch1_output",
    "ch2_output",
    "ch3_output",
    "ch1_setvoltage",
    "ch2_setvoltage",
    "ch3_setvoltage",
    "ch1_polarity",
    "ch2_polarity",
    "ch3_polarity",
    "ch1_getvoltage",
    "ch2_getvoltage",
    "ch3_getvoltage",
    "ch1_getcurrent",
    "ch2_getcurrent",
    "ch3_getcurrent",
    "error_signals",
    "getallvalues",
    "getsetting",
    "thatsall",
    "LED",
    "ip_store_endpoint",
    "ip_store_myip",
    "ip_store_mymask",
    "ip_store_mygatew",
    "ip_get_myip",
    "ip_get_mymask",
    "ip_get_mygatew",
    "ip_getsetting",
    "adc_set_k0",
    "adc_set_k1",
    "adc_set_k2",
    "adc_set_k3",
    "adc_set_k4",
    "adc_set_k5",
    "adc_set_q0",
    "adc_set_q1",
    "adc_set_q2",
    "adc_set_q3",
    "adc_set_q4",
    "adc_set_q5",
    "adc_get_k0",
    "adc_get_k1",
    "adc_get_k2",
    "adc_get_k3",
    "adc_get_k4",
    "adc_get_k5",
    "adc_get_q0",
    "adc_get_q1",
    "adc_get_q2",
    "adc_get_q3",
    "adc_get_q4",
    "adc_get_q5",
    "dac_set_k0",
    "dac_set_k1",
    "dac_set_k2",
    "dac_set_q1",
    "dac_set_q2",
    "dac_set_q3",
    "dac_get_k0",
    "dac_get_k1",
    "dac_get_k2",
    "dac_get_q1",
    "dac_get_q2",
    "dac_get_q3",
    "adc_getallcoef",
    "dac_getallcoef",
    "ch1_setprereg",
    "ch2_setprereg",
    "ch3_setprereg",
    "ch1_setoutreg",
    "ch2_setoutreg",
    "ch3_setoutreg",
    "reset"
        };

        public enum eCommunicationType : byte
        {
            non,
            serial,
            udp
        };


        Timer read_timer = new Timer();

        public delegate void efunction();
        efunction ExecuteFunction;
        private SerialPort serialport;
        private UdpClient udp;
        private int udpport;
        private IPAddress ip_enpoint;
        private eCommunicationType CommunicationType = eCommunicationType.non;




        public Communication(SerialPort serialport, int UDPPort, efunction f)
        {
            this.serialport = serialport;
            //this.udp = new UdpClient(UDPPort);
            udpport = UDPPort;
            CommunicationType = eCommunicationType.non;
            ExecuteFunction = f;

            read_timer.Tick += new System.EventHandler(SerialReadCommand);
            read_timer.Interval = 10;
        }

        public bool Open_UDP(string ipadress)
        {
            udp = new UdpClient(udpport);

            IPAddress ip;
            if (IPAddress.TryParse(ipadress, out ip))
            {
                ip_enpoint = ip;
                //udp.Connect(ip, udpport);
                udp.BeginReceive(new AsyncCallback(UdpReceive), udp);
                CommunicationType = eCommunicationType.udp;
                return true;
            }
            CommunicationType = eCommunicationType.non;

            return false;
        }

        public void Close_UDP()
        {
            if (!(CommunicationType == eCommunicationType.udp)) return;

            udp.Close();

            CommunicationType = eCommunicationType.non;
        }

        public string[] GetPortNames()
        {
            return SerialPort.GetPortNames();
        }

        public bool Open_Serial(string name)
        {
            serialport.PortName = name;

            try
            {
                serialport.Open();
                CommunicationType = eCommunicationType.serial;
                read_timer.Enabled = true;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CommunicationType = eCommunicationType.non;
                return false;
            }
        }

        public void Close_Serial()
        {
            if (!(CommunicationType == eCommunicationType.serial)) return;

            read_timer.Enabled = false;
            serialport.Close();
            CommunicationType = eCommunicationType.non;
        }

        public bool IsOpen()
        {
            return serialport.IsOpen;
        }

        public eCommunicationType GetCommunicationType()
        {
            return CommunicationType;
        }

        public void SendCommand(eCommandCode Command, UInt32 Data)
        {

            //string s = command_strings[(int)Command] + "=" + Data.ToString() + "\n\r";

            string s = "/" + ((int)Command).ToString() + "=" + Data.ToString() + "\n\r";

            if (CommunicationType == eCommunicationType.serial)
            {
                if (!serialport.IsOpen) return;
                serialport.Write(s);
            }

            else if (CommunicationType == eCommunicationType.udp)
            {
                byte[] data = Encoding.ASCII.GetBytes(s);
                udp.Send(data, data.Length, new IPEndPoint(ip_enpoint, udpport));
            }

        }




        public eCommandCode ReadCommand_Code;
        public UInt32 ReadCommand_Data;
        public float ReadCommand_Data_float;

        public string lineXXX;

        byte[] lineBuffer = new byte[128];
        int LineBuf_pos = 0;

        private void SerialReadCommand(object sender, EventArgs e)
        {
            if (!serialport.IsOpen)
            {
                ReadCommand_Code = eCommandCode.NON;
                return;
            }


            while (serialport.BytesToRead > 0)
            {
                byte b = (byte)serialport.ReadByte();

                if ((b == '\n') || (b == '\r'))
                {
                    if (LineBuf_pos == 0) //zatim nic v bufferu
                        continue; // pokracuj

                    //cmd_string = Encoding.UTF8.GetString(lineBuffer, 0, LineBuf_pos);
                    ProcessLine(Encoding.UTF8.GetString(lineBuffer, 0, LineBuf_pos));
                    ExecuteFunction();

                    LineBuf_pos = 0;
                    return;
                }
                lineBuffer[LineBuf_pos] = b;
                LineBuf_pos++;

                if (LineBuf_pos >= lineBuffer.Length) //preteka
                {
                    LineBuf_pos = lineBuffer.Length - 1;
                }//TODO vypis overflow
            }

            ReadCommand_Code = eCommandCode.NON;
            return;
        }

        private void ProcessLine(string line)
        {
            if (String.IsNullOrEmpty(line))
            {
                ReadCommand_Code = eCommandCode.NON;
                return;
            }

            
            string[] polozky = line.Split('=');
            

            if (polozky.Length >= 2)
            {
                if (polozky[0].StartsWith("/"))
                {
                    string s = polozky[0].Remove(0, 1);
                    uint x = 0;

                    if (!UInt32.TryParse(s, out x))
                    {
                        ReadCommand_Code = 0;
                    }
                    else
                    {
                        ReadCommand_Code = (eCommandCode)x;
                    }

                }

                else
                {
                    for (int i = 0; i < command_strings.Length; i++)
                    {
                        if (String.Compare(polozky[0], command_strings[i]) == 0)
                        {
                            ReadCommand_Code = (eCommandCode)i;
                            break;
                        }
                        else
                        {
                            ReadCommand_Code = eCommandCode.NON;
                        }
                    }
                }

                if (!UInt32.TryParse(polozky[1], out ReadCommand_Data))
                {
                    
                    ReadCommand_Data = 0;
                }



                if (!float.TryParse(polozky[1], System.Globalization.NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out ReadCommand_Data_float))
                {
                    ReadCommand_Data_float = 0;
                }
                
            }
        }

        private void UdpReceive(IAsyncResult ar) 
        {

            UdpClient uu = ar.AsyncState as UdpClient;
            if (uu == null)
            {

                return;
            }

            IPEndPoint ipe = new IPEndPoint(ip_enpoint, 0);
            //IPEndPoint ipe = new IPEndPoint(IPAddress.Any, 0); //port 0 je pro vsechny

            try 
            {
                byte[] data = uu.EndReceive(ar, ref ipe);
                string s = Encoding.ASCII.GetString(data);
                s = s.Replace('\n', ' ');
                s = s.Replace('\r', ' ');
                s = s.Trim();
                //s = s + 0;


                ProcessLine(s);
                ExecuteFunction();

                uu.BeginReceive(new AsyncCallback(UdpReceive), uu);
            }
            catch 
            {
                Close_UDP();
                return;
            }
            
        }
    
    }
}
