using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VideoSwitch.Models;

namespace VideoSwitch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var port = SwitchMessage.CreatePort();
            var portSvc = new Services.SerialPortWrapper(port);
            var viewModel = new ButtonsViewModel(portSvc);
            var presets = Data.PresetData.GetPresets();

                       
            foreach (var p in presets)
            {
                p.Command = new PresetClickCommand(portSvc);
                viewModel.Buttons.Add(p);
            }            
            
            this.DataContext = viewModel;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            VideoSwitch.Properties.Settings.Default.LastWindowWidth = this.Width;
            VideoSwitch.Properties.Settings.Default.LastWindowHeight = this.Height;
            VideoSwitch.Properties.Settings.Default.Save();
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            this.Width = VideoSwitch.Properties.Settings.Default.LastWindowWidth;
            this.Height = VideoSwitch.Properties.Settings.Default.LastWindowHeight;
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }
    }
}
