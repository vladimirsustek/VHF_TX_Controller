using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace VHF_TX_Controller
{
    class FM_TX_DEV : COMDevice
    {
        private const string cmd_setDAC0phIncrement = "D0_SI_";
        private const string cmd_setDAC1Voltage = "D1_SV_";
        private const string cmd_setRFMode = "RF_MD_";
        private const string cmd_getSystemTick = "TC_GT_00000000";

        private const int TWO_LINES_RESPONSE = 2;
        private const int ONE_LINE_RESPONSE = 1;

        public string cmdFM_TX_setDAC0phIncrement(int arg)
        {
            string result;
            string hexArg = arg.ToString("X").PadLeft(8, '0');

            try
            {
                result = this.WriteAndReadLine(cmd_setDAC0phIncrement + hexArg, ONE_LINE_RESPONSE);
                result = cmd_setDAC0phIncrement + hexArg + " = RX: " + result;
            }
            catch (Exception e)
            {
                result = e.ToString();
            }

            return result;
        }
        public string cmdFM_TX_setDAC1Voltage(int arg)
        {
            string result;
            string hexArg = arg.ToString("X").PadLeft(8, '0');

            try
            {
                result = this.WriteAndReadLine(cmd_setDAC1Voltage + hexArg, ONE_LINE_RESPONSE);
                result = cmd_setDAC1Voltage + hexArg + " = RX: " + result;

            }
            catch (Exception e)
            {
                result = e.ToString();
            }

            return result;
        }
        public string cmdFM_TX_setRFMode(int arg)
        {
            string result;
            string hexArg = arg.ToString("X").PadLeft(8, '0');

            try
            {
                result = this.WriteAndReadLine(cmd_setRFMode + hexArg, ONE_LINE_RESPONSE);
                result = cmd_setRFMode+ hexArg + " = RX: " + result;

            }
            catch (Exception e)
            {
                result = e.ToString();
            }

            return result;
        }
        public UInt32 cmdFM_TX_getSystemTick()
        {
            int[] intarr;
            UInt32 tick = 0;

            try
            {
                intarr = this.WriteAndReadBytes(cmd_getSystemTick, 10);

                if ((intarr[0] == (int)'S') && 
                    (intarr[1] == (int)'T') && 
                    (intarr[2] == (int)'C') && 
                    (intarr[3] == (int)'K') &&
                    (intarr[4] == (int)':') &&
                    (intarr[9] == (int)'\n'))
                {
                    tick += (UInt32)intarr[5] << 24;
                    tick += (UInt32)intarr[6] << 16;
                    tick += (UInt32)intarr[7] << 8;
                    tick += (UInt32)intarr[8] << 0;
                }

            }
            catch (Exception e)
            {
                tick = 0;
            }

            return tick;
        }
    }
}
