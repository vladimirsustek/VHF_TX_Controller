using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;


namespace VHF_TX_Controller
{
    public class COMDevice : SerialPort
    {
        public Parity ParseParity(string strParity)
        {
            Parity nativeParity;
            switch(strParity)
            {
                case "None":
                    {
                        nativeParity = Parity.None;
                    }
                    break;
                case "Odd":
                    {
                        nativeParity = Parity.Odd;
                    }
                    break;
                case "Even":
                    {
                        nativeParity = Parity.Even;
                    }
                    break;
                default:
                    {
                        nativeParity = Parity.None;
                    }
                    break;
            }

            return nativeParity;
        }
        public StopBits ParseStopBits(string strStopBits)
        {
            StopBits nativeStopBits = StopBits.None;
            switch (strStopBits)
            {
                case "None":
                    {
                        nativeStopBits = StopBits.None;
                    }
                    break;
                case "One":
                    {
                        nativeStopBits = StopBits.One;
                    }
                    break;
                case "Two":
                    {
                        nativeStopBits = StopBits.Two;
                    }
                    break;
                case "OnePointFive":
                    {
                        nativeStopBits = StopBits.OnePointFive;
                    }
                    break;
                default:
                    {
                        nativeStopBits = StopBits.None;
                    }
                    break;
            }

            return nativeStopBits;
        }

        public string WriteAndReadLine(string line)
        {
            string response = "";

            if (!this.IsOpen)
                return "Port unavailable";

            Console.WriteLine(this.PortName);
            this.WriteLine(line);
            response = this.ReadLine();
            response += this.ReadLine();

            return response;
        }
        public string WriteAndReadLine(string line, int lines)
        {
            string response = "";

            if (!this.IsOpen)
                return "Port unavailable";


            this.WriteLine(line);

            while(lines > 0)
            {
                response += this.ReadLine();
                lines--;
            }

            return response;
        }

        public int[] WriteAndReadBytes(string line, int bytes)
        {

            int[] response = new int[10];

            if (!this.IsOpen)
                return response;

            this.WriteLine(line);

            int idx = 0;
            while (bytes > 0)
            {
                response[idx] = (int)this.ReadByte();
                bytes--;
                idx++;
            }

            return response;
        }
    }
}
