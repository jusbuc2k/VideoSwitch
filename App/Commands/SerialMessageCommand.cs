using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using VideoSwitch.Services;

namespace VideoSwitch.Models
{
    public class PresetClickCommand : ICommand
    {
        public PresetClickCommand(ISerialPortService serialPort)
        {
            _serialPort = serialPort;
        }

        private ISerialPortService _serialPort;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            var msgs = parameter as string[];
            foreach (var msg in msgs)
            {
                _serialPort.SendMessage(msg);
            }
        }
    }
}
