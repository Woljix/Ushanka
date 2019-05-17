using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ushanka
{
    public class Settings
    {
        public static Settings Loaded { get; internal set; } = new Settings();

        public static void Save(string Filename)
        {
            string json = JsonConvert.SerializeObject(Loaded, Formatting.Indented);

            File.WriteAllText(Filename, json);
        }

        public static void Load(string Filename)
        {
            Settings _settings = null;

            _settings = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(Filename));

            if (_settings != null)
                Loaded = _settings;
        }

        public string DownloadLocation { get; set; } = "Downloads";
        public string LogLocation { get; set; } = "Logs"; // Not implemented yet

        public List<string> Usernames { get; set; } = new List<string>();

        public bool SpecialMode { get; set; } = false; // Made for my friend.
        public bool DebugMode { get; set; } = false;
    }
}
