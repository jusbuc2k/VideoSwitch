using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoSwitch.Services;

namespace VideoSwitch.Models
{
    public class ButtonsViewModel
    {
        public ButtonsViewModel(ISerialPortService serialPort)
        {
            _serialPort = serialPort;
            this.Buttons = new List<SwitchPreset>();
        }

        private ISerialPortService _serialPort;

        public IList<SwitchPreset> Buttons { get; set; }        
    }
}
