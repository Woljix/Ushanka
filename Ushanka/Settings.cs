using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ushanka
{
    public class Settings
    {
        public string DownloadLocation { get; set; } = AppDomain.CurrentDomain.BaseDirectory;
        public string LogLocation { get; set; } = System.IO.Path.Combine( AppDomain.CurrentDomain.BaseDirectory, "Log.txt");

        public List<string> Usernames { get; set; } = new List<string>();
    }
}
