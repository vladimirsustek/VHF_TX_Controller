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
        private const string cmd_setAudioSource = "AU_SR_";
        private const string cmd_getSystemTick = "TC_GT_";

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
        public string cmdFM_TX_setAudioSource(int arg)
        {
            string result;
            string hexArg = arg.ToString("X").PadLeft(8, '0');

            try
            {
                result = this.WriteAndReadLine(cmd_setAudioSource + hexArg, ONE_LINE_RESPONSE);
                result = cmd_setAudioSource + hexArg + " = RX: " + result;

            }
            catch (Exception e)
            {
                result = e.ToString();
            }

            return result;
        }
        public string cmdFM_TX_getSystemTick()
        {
            int arg = 0;
            string result;
            string hexArg = arg.ToString("X").PadLeft(8, '0');
            string hexRes;

            try
            {
                result = this.WriteAndReadLine(cmd_getSystemTick + hexArg, ONE_LINE_RESPONSE);
                string[] retval = result.Split(':');
                byte[] bytes = Encoding.ASCII.GetBytes(retval[1]);
                Array.Reverse(bytes, 0, bytes.Length);
                UInt32 tick = BitConverter.ToUInt32(bytes, 0);
                hexRes = tick.ToString("X").PadLeft(8, '0');
                result = cmd_getSystemTick + hexArg + " = RX: " + retval[0] + ':' + hexRes;

            }
            catch (Exception e)
            {
                //result = e.ToString();
                result = "Exception";
            }

            return result;
        }
    }
}
