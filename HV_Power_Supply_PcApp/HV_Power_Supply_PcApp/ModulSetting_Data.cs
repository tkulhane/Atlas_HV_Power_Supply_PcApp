using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HV_Power_Supply_GUI_ver._1
{
    class ModulSetting_Data
    {
        public UInt32 macAddress_1;
        public UInt32 macAddress_2;
        public UInt32 ipAddress;
        public UInt32 netMask;
        public UInt32 gateWay;
        public UInt32 udpRecvPort;

        public float ch1_adc_voltage_k;
        public float ch2_adc_voltage_k;
        public float ch3_adc_voltage_k;
        public float ch1_adc_current_k;
        public float ch2_adc_current_k;
        public float ch3_adc_current_k;

        public float ch1_adc_voltage_q;
        public float ch2_adc_voltage_q;
        public float ch3_adc_voltage_q;
        public float ch1_adc_current_q;
        public float ch2_adc_current_q;
        public float ch3_adc_current_q;

        public float ch1_dac_k;
        public float ch2_dac_k;
        public float ch3_dac_k;

        public float ch1_dac_q;
        public float ch2_dac_q;
        public float ch3_dac_q;

        public bool valid;

        public UInt32 EnableErrorExecute;
        public UInt32 DisableInConnLost;
        public UInt32 CtrlOutWithEnable;
        public UInt32 ErrorExecuteAutoRestart;
        public UInt32 EnableAdaptiveVoltageTune;

        public UInt32 VoltageRamp_VoltStep;
        public UInt32 VoltageRamp_TimeStep;

        public ModulSetting_Data()
        {
            valid = false;
        }


    }
}
