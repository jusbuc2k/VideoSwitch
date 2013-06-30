using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace VideoSwitch.Models
{
    public class SwitchPreset : ICommandModel
    {
        public string Title { get; set; }
        public string[] Commands { get; set; }
        public ICommand Command { get; set; }
    }
}
