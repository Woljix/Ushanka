﻿using Newtonsoft.Json;
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
        public static Settings LoadedSettings { get; internal set; } = new Settings();

        public static void Save(string Filename)
        {
            string json = JsonConvert.SerializeObject(LoadedSettings, Formatting.Indented);

            File.WriteAllText(Filename, json);
        }

        public static void Load(string Filename)
        {
            Settings _settings = null;

            _settings = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(Filename));

            if (_settings != null)
                LoadedSettings = _settings;
        }

        public string DownloadLocation { get; set; } = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Downloads");
        public string LogLocation { get; set; } = System.IO.Path.Combine( AppDomain.CurrentDomain.BaseDirectory, "Logs");

        public List<string> Usernames { get; set; } = new List<string>();

        public bool SpecialMode { get; set; } = false;
    }
}
