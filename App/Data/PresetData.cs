using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoSwitch.Models;

namespace VideoSwitch.Data
{
    public static class PresetData
    {
        public static IEnumerable<SwitchPreset> GetPresets()
        {
            var result = new List<SwitchPreset>();
            var config = VideoSwitch.Properties.Settings.Default.Presets;
            string[] parts;

            foreach (var item in config)
            {
                parts = item.Split('=');
                result.Add(new SwitchPreset()
                {
                    Title = parts[0],
                    Commands = parts[1].Split(';')
                });
            }

            return result;
        }
    }
}
