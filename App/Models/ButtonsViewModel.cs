using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoSwitch.Services;

namespace VideoSwitch.Models
{
    public class ButtonsViewModel 
    {
        public ButtonsViewModel()
        {
            this.Buttons = new List<ButtonViewModel>();            
        }

        public IList<ButtonViewModel> Buttons { get; set; }
    }
}
