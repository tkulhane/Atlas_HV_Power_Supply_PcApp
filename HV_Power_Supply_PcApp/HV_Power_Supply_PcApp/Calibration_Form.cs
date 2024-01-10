using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace HV_Power_Supply_GUI_ver._1
{
    public partial class Calibration_Form : Form
    {

        //internal delegate void efunction();
        //efunction _FunctionReqData;

        //internal delegate void efunction(UInt16 voltage);
        //efunction _FunctionSetVoltage;

        internal delegate void efunction1(Communication.eCommandCode Command, UInt32 Data);
        efunction1 _FunctionSendData;

        internal delegate void efunction2(Communication.eCommandCode Command, float Data);
        efunction2 _FunctionSendData_Float;

        internal efunction1 FunctionSendData { get => _FunctionSendData; set => _FunctionSendData = value; }
        internal efunction2 FunctionSendData_Float { get => _FunctionSendData_Float; set => _FunctionSendData_Float = value; }

        public float[] MeasVoltage; 

        BindingList<Calibration_ListData> Calib_Data = new BindingList<Calibration_ListData>();

        uint Channel = 0;

        BindingList<float> Measurement_Data = new BindingList<float>();

        UInt16[] SetVolt = { 50, 100, 200, 300, 400, 450 };


        System.Timers.Timer TimerMain = new System.Timers.Timer();

        int Measurement_Step = 0;
        int Set_Step = 0;

        public Calibration_Form()
        {
            InitializeComponent();

            TimerMain.Elapsed += new ElapsedEventHandler(TimerMainEvent);

            TimerMain.Interval = 1000;

            dataGridView_CalibData.DataSource = Calib_Data;
        }

        public void Savevalues(float SetVoltage, float DacVoltage, float OutVoltage) 
        {
            Calibration_ListData data = new Calibration_ListData(SetVoltage, DacVoltage, OutVoltage);
            

            //Measurement_Data.Add(data);
        }


        private void Start() 
        {
            Measurement_Step = 0;
            Set_Step = 0;

            _FunctionSendData(Communication.eCommandCode.enable_CH1, 1);

            SetVoltage(SetVolt[Set_Step]);
            TimerMain.Enabled = true;
            
        }

        private void SetVoltage(UInt16 voltage) 
        {
            _FunctionSendData(Communication.eCommandCode.set_voltage_CH1, (uint)voltage);
        }

        private void ProcessMeasurementData() 
        {
            int size = Measurement_Data.Count;

            float Out_Voltage = 0;

            for (int i = 0; i < size; i++) 
            {
                Out_Voltage += Measurement_Data[i];
            }
            Out_Voltage /= size;

            Calibration_ListData data = new Calibration_ListData(SetVolt[Set_Step], 0, Out_Voltage);
            Calib_Data.Add(data);
        }


        private void TimerMainEvent(object sender, ElapsedEventArgs e)
        {
            Measurement_Data.Add(MeasVoltage[0]);


            if (Measurement_Step >= 5) 
            {
                Measurement_Step = 0;


                
                if(Set_Step >= SetVolt.Length) 
                {
                    SetVoltage(SetVolt[0]);
                    _FunctionSendData(Communication.eCommandCode.enable_CH1, 0);
                    TimerMain.Enabled = false;
                    //výpočet koeficientů
                }
                else 
                {
                    ProcessMeasurementData(); //průměrovat a uložit
                    Set_Step++;
                    SetVoltage(SetVolt[Set_Step]);
                }

            }
            else 
            {
                //_FunctionReqData();
                Measurement_Step++;
            }

   



        }

        private void button_StartCalib_Click(object sender, EventArgs e)
        {
            Start();
        }
    }
}
