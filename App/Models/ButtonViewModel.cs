using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoSwitch.Models
{
    public class ButtonViewModel : ICommandModel
    {
        public string Title { get; set; }
        public string[] Commands { get; set; }
        public System.Windows.Input.ICommand Command {get;set;}        
    }
}
