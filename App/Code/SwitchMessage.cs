﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace VideoSwitch
{
    public static class SwitchMessage
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
                RtsEnable = true,
                DtrEnable = true,
                Handshake = Handshake.None
            };
        }

        public static void SendMessage(string message)
        {
            using (var port = CreatePort())
            {
                port.Open();
                port.Write(message);
            }
        }
    }
}
