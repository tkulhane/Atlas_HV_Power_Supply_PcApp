using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HV_Power_Supply_GUI_ver._1
{
    class Calibration_ListData
    {

        float SET_voltage;
        [DisplayName("DAC Voltage")]
        public float xSET_voltage { get { return SET_voltage; } }

        float DAC_voltage;
        [DisplayName("DAC Voltage")]
        public float xDAC_voltage { get { return DAC_voltage; } }

        float OUT_voltage;
        [DisplayName("Output Voltage")]
        public float xOUT_voltage { get { return OUT_voltage; } }

        //public String p_value { get { return _value; } set { _value = value; } }

        public Calibration_ListData(float SetVoltage, float DacVoltage, float OutVoltage) 
        {
            SET_voltage = SetVoltage;
            DAC_voltage = DacVoltage;
            OUT_voltage = OutVoltage;
        }

    }
}
