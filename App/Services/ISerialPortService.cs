using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoSwitch.Services
{
    public interface ISerialPortService
    {
        void SendMessage(string message);        
    }
}
