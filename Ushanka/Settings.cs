using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ushanka
{
    public class Settings
    {
        public static Settings Loaded { get; internal set; } = new Settings();

        public static string Save(string Filename)
        {
            string json = JsonConvert.SerializeObject(Loaded, Formatting.Indented);

            string _hash = GetMD5Hash(json);

            File.WriteAllText(Filename, json);

            return _hash;
        }

        private static string GetMD5Hash(string input)
        {
            using (MD5 crypt = MD5.Create())
            {
                byte[] _data = crypt.ComputeHash(Encoding.UTF8.GetBytes(input));

                StringBuilder _sb = new StringBuilder();

                for (int i = 0; i < _data.Length; i++)
                {
                    _sb.Append(_data[i].ToString("x2"));
                }

                return _sb.ToString();
            }
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

        public bool SpecialMode { get; set; } = false; // Made for my friend, so don't @ me.
        public bool DebugMode { get; set; } = false;
        public bool CheckForUpdates { get; set; } = true;

        public string DefaultProfilePicture { get; set; } = string.Empty;
        public string DefaultSingleID { get; set; } = string.Empty;
    }
}
