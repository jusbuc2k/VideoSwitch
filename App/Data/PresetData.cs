using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoSwitch.Models;

namespace VideoSwitch.Data
{
    public static class PresetData
    {
        public static IEnumerable<Preset> GetPresets()
        {
            var result = new List<Preset>();
            var file = new FileInfo(Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "presets.dat"));            
            
            string line;
            string[] parts;            

            if (file.Exists)
            {
                using (var reader = new StreamReader(file.OpenRead()))
                {
                    while(true)
                    {
                        line = reader.ReadLine();
                        if (line == null)
                            break;
                        parts = line.Split(new char[]{'\t'}, StringSplitOptions.RemoveEmptyEntries);
                        result.Add(new Preset(){
                            Title = parts[0],
                            Commands = parts.Skip(1).ToArray()
                        });
                    }                   
                }
            }
                      
            return result;
        }
    }
}
