using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoSwitch.Services
{
    public class SerialPortClient : ISerialPortService
    {
        public SerialPortClient(System.IO.Ports.SerialPort serialPort)
        {
            _port = serialPort;
        }

        private System.IO.Ports.SerialPort _port;

        public void SendMessage(string message)
        {
            try
            {
                _port.Open();
                _port.Write(message);
                _port.Write("\r\n");
            }
            finally
            {
                _port.Close();
            }
        }
    }
}
