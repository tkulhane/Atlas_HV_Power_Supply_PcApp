using System;
using System.Collections.Generic;
using System.Drawing;
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

            ip_store_mac,
            ip_store_myip,
            ip_store_mymask,
            ip_store_mygatew,
            ip_store_UdpRecvPort,

            ip_get_mac,
            ip_get_myip,
            ip_get_mymask,
            ip_get_mygatew,
            ip_get_UdpRecvPort,

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

            ch1_get_err_state,
            ch2_get_err_state,
            ch3_get_err_state,
            errState_Get,

            CfgSet_EnableErrorExecute,
            CfgSet_DisableInConnLost,
            CfgSet_CtrlOutWithChEnable,
            CfgSet_ErrorExecuteAutoRestart,

            CfgGet_EnableErrorExecute,
            CfgGet_DisableInConnLost,
            CfgGet_CtrlOutWithChEnable,
            CfgGet_ErrorExecuteAutoRestart,
            Cfg_Get,

            params_store,
            params_default,

            Eth_ReInit,

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

    "ip_store_mac",

    "ip_store_myip",
    "ip_store_mymask",
    "ip_store_mygatew",
    "cmd_ip_store_UdpRecvPort",

    "ip_get_mac",

    "ip_get_myip",
    "ip_get_mymask",
    "ip_get_mygatew",
    "cmd_ip_get_UdpRecvPort",

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
    "dac_set_q0",
    "dac_set_q1",
    "dac_set_q2",
    "dac_get_k0",
    "dac_get_k1",
    "dac_get_k2",
    "dac_get_q0",
    "dac_get_q1",
    "dac_get_q2",
    "adc_getallcoef",
    "dac_getallcoef",
    "ch1_setprereg",
    "ch2_setprereg",
    "ch3_setprereg",
    "ch1_setoutreg",
    "ch2_setoutreg",
    "ch3_setoutreg",

    "ch1_get_err_state",
    "ch2_get_err_state",
    "ch3_get_err_state",
    "errState_Get",

    "CfgSet_EnableErrorExecute",
    "CfgSet_DisableInConnLost",
    "CfgSet_CtrlOutWithChEnable",
    "CfgSet_ErrorExecuteAutoRestart",

    "CfgGet_EnableErrorExecute",
    "CfgGet_DisableInConnLost",
    "CfgGet_CtrlOutWithChEnable",
    "CfgGet_ErrorExecuteAutoRestart",

    "Cfg_Get",

    "params_store",
    "params_default",

    "ETH_ReInit",

    "reset"
        };

        public enum eCommunicationType : byte
        {
            non,
            serial,
            udp
        };


        public ComboBox comboBox_SerialPorts;
        public TextBox textBox_ipAdress;
        public TextBox textBox_ethPorts;
        public RadioButton radioButton_Serial;
        public RadioButton radioButton_Udp;
        public Label label_Status;
        public Button button_PortScan;

        internal delegate void efunction_Timer();
        public efunction_Timer RequestTimerFunction;

        Timer read_timer = new Timer();

        public delegate void efunction();
        efunction ExecuteFunction;
        private SerialPort serialport;
        private UdpClient udp;
        
        private int udpPortSend;
        private int udpPortRecv;

        private IPAddress remoteIp;

        private IPEndPoint remoteIpEndPoint;
        private eCommunicationType CommunicationType = eCommunicationType.non;

        public string serialPortName;
        public string remoteIpAddress;
        public int remoteEthPort;

        Timer timer_req = new Timer();

        private bool device_connected;

        public Communication(SerialPort serialport, efunction f)
        {
            this.serialport = serialport;
            //this.udp = new UdpClient(UDPPort);
            
            CommunicationType = eCommunicationType.non;
            ExecuteFunction = f;

            read_timer.Tick += new System.EventHandler(SerialReadCommand);
            read_timer.Interval = 10;

            timer_req.Tick += new System.EventHandler(RequestTimerHandler);
            timer_req.Interval = 400;
        }



        public void OpenClose() 
        {
            Communication.eCommunicationType comm = GetCommunicationType();

            if (comm == Communication.eCommunicationType.serial)
            {
                Close_Serial();
                label_Status.Text = "Close";
                timer_req.Enabled = false;
                //timer_Read.Enabled = false;
                CommunicationControlEnable(true);
                return;
            }

            else if (comm == Communication.eCommunicationType.udp)
            {
                Close_UDP();
                label_Status.Text = "Close";
                timer_req.Enabled = false;
                CommunicationControlEnable(true);
                return;
            }


            if (radioButton_Serial.Checked == true)
            {
                if (comboBox_SerialPorts.SelectedIndex < 0)
                {
                    MessageBox.Show("Nevybran port", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Open_Serial(comboBox_SerialPorts.SelectedItem as String);
            }
            else if (radioButton_Udp.Checked == true)
            {
                int port;
                if (!int.TryParse(textBox_ethPorts.Text, out port)) return;
                Open_UDP(textBox_ipAdress.Text, 5005, port);
            }


            comm = GetCommunicationType();

            if (comm == Communication.eCommunicationType.serial)
            {
                label_Status.Text = "Open Serial";

                SendCommand(Communication.eCommandCode.getsetting, 0);
                SendCommand(Communication.eCommandCode.ip_getsetting, 0);

                timer_req.Interval = 400;
                timer_req.Enabled = true;

                CommunicationControlEnable(false);

            }
            else if (comm == Communication.eCommunicationType.udp)
            {
                label_Status.Text = "Open UDP";


                SendEndpoint();
                SendCommand(Communication.eCommandCode.getsetting, 0);
                SendCommand(Communication.eCommandCode.ip_getsetting, 0);

                timer_req.Interval = 200;
                timer_req.Enabled = true;

                CommunicationControlEnable(false);
            }
            else
            {
                label_Status.Text = "Close";
                label_Status.BackColor = SystemColors.ActiveCaption;
                CommunicationControlEnable(true);
            }
        }

        private void CommunicationControlEnable(bool Enable)
        {
            radioButton_Udp.Enabled = Enable;
            radioButton_Serial.Enabled = Enable;
            button_PortScan.Enabled = Enable;
            comboBox_SerialPorts.Enabled = Enable;
            textBox_ipAdress.Enabled = Enable;
            textBox_ethPorts.Enabled = Enable;
        }

        private void RequestTimerHandler(object sender, EventArgs e)
        {
            RequestTimerFunction();

            if (device_connected)
            {
                label_Status.BackColor = Color.Green;
            }
            else
            {
                label_Status.BackColor = Color.Red;
            }

            SendCommand(Communication.eCommandCode.Connected, 1);

        }

        public void DeviceConnected() 
        {
            device_connected = true;
        }


        public void SendEndpoint() 
        {
            SendCommand(Communication.eCommandCode.ip_store_endpoint, (uint)udpPortRecv);
        }

        public bool Open_UDP(string ipadress, int portSend, int portRecv)
        {
            udpPortSend = portSend;
            udpPortRecv = portRecv;

            IPEndPoint localpt = new IPEndPoint(IPAddress.Any, udpPortRecv);

            udp = new UdpClient();
            udp.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            udp.Client.Bind(localpt);
            

            IPAddress ip;
            if (IPAddress.TryParse(ipadress, out ip))
            {
                remoteIp = ip;

                remoteIpAddress = ipadress;
                remoteEthPort = portRecv;

                remoteIpEndPoint = new IPEndPoint(remoteIp, udpPortSend);
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

        public void scanSerialPorts() 
        {
            comboBox_SerialPorts.Items.Clear();

            foreach (String s in SerialPort.GetPortNames())
            {
                comboBox_SerialPorts.Items.Add(s);
            }


            if (comboBox_SerialPorts.Items.Count > 0)
            {
                comboBox_SerialPorts.SelectedIndex = 0;
            }

            /*
            if (comboBox_SerialPorts.IsOpen())
            {
                label_SerialStatus.Text = "Open";
            }
            else
            {
                comboBox_SerialPorts.Text = "Close";
            }
            */
        }

        public bool Open_Serial(string name)
        {
            serialport.PortName = name;

            try
            {
                serialport.Open();
                CommunicationType = eCommunicationType.serial;
                serialPortName = name;
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

        public void OpenSerialSetting(string portSerial)
        {

            radioButton_Serial.Checked = true;
            radioButton_Udp.Checked = false;

            scanSerialPorts();

            int Selected = -1;
            int count = comboBox_SerialPorts.Items.Count;
            for (int i = 0; (i <= (count - 1)); i++)
            {
                comboBox_SerialPorts.SelectedIndex = i;
                string port = comboBox_SerialPorts.SelectedItem as String;

                if (portSerial.Equals(port))
                {
                    Selected = i;
                    
                }

            }

            if (Selected >= 0)
            {
                comboBox_SerialPorts.SelectedIndex = Selected;
                OpenClose();
                return;
            }

            comboBox_SerialPorts.SelectedIndex = Selected = -1;

            
        }

        public void OpenUdpSetting(string ip, string port) 
        {
            radioButton_Serial.Checked = false;
            radioButton_Udp.Checked = true;

            textBox_ipAdress.Text = ip;
            textBox_ethPorts.Text = port;

            OpenClose();
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
                //udp.Send(data, data.Length, new IPEndPoint(remoteIp, udpport));
                udp.Send(data, data.Length, remoteIpEndPoint);

            }

        }

        public void SendCommand_Float(eCommandCode Command, float Data)
        {

            //string s = command_strings[(int)Command] + "=" + Data.ToString() + "\n\r";

            string s = "/" + ((int)Command).ToString() + "=" + Data.ToString() + "\n\r";
            s = s.Replace(',', '.');


            if (CommunicationType == eCommunicationType.serial)
            {
                if (!serialport.IsOpen) return;
                serialport.Write(s);
            }

            else if (CommunicationType == eCommunicationType.udp)
            {
                byte[] data = Encoding.ASCII.GetBytes(s);
                //udp.Send(data, data.Length, new IPEndPoint(remoteIp, udpport));
                udp.Send(data, data.Length, remoteIpEndPoint);

            }

        }




        public eCommandCode ReadCommand_Code;
        public UInt32 ReadCommand_Data;
        public float ReadCommand_Data_float;



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

        [Obsolete]
        private void UdpReceive(IAsyncResult ar) 
        {

            UdpClient uu = ar.AsyncState as UdpClient;
            if (uu == null)
            {
                return;
            }

            IPEndPoint ipe = new IPEndPoint(IPAddress.Any, 0); //port 0 je pro vsechny

            try 
            {

                byte[] data = uu.EndReceive(ar, ref ipe);

               

                if (ipe.Address.Equals(remoteIpEndPoint.Address))
                {

                    string s = Encoding.ASCII.GetString(data);
                    s = s.Replace('\n', ' ');
                    s = s.Replace('\r', ' ');
                    s = s.Trim();

                    ProcessLine(s);
                    ExecuteFunction();
                }

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
