using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MusicalChannels.Models.Services
{
    static class SettingsReader
    {
        public static string GetPicsURL()
        {
            return File.ReadAllText("settings.txt");
        }
    }
}
