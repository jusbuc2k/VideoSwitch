using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace VideoSwitch
{
    public static class SerialPortFactory
    {
        public static SerialPort CreatePort()
        {
            return new SerialPort()
            {
                PortName = VideoSwitch.Properties.Settings.Default.Port,
                BaudRate = VideoSwitch.Properties.Settings.Default.BaudRate,
                Parity = VideoSwitch.Properties.Settings.Default.Parity,
                StopBits = VideoSwitch.Properties.Settings.Default.StopBits,
                DataBits = VideoSwitch.Properties.Settings.Default.DataBits,
                WriteTimeout = (VideoSwitch.Properties.Settings.Default.Timeout * 1000),
                RtsEnable = VideoSwitch.Properties.Settings.Default.RtsEnable,
                DtrEnable = VideoSwitch.Properties.Settings.Default.DtrEnable,
                Handshake = VideoSwitch.Properties.Settings.Default.Handshake,
                Encoding = Encoding.ASCII
            };
        }
    }
}
