using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ushanka.GitHubUpdate
{
    // https://developer.github.com/v3/#user-agent-required
    // https://developer.github.com/v3/repos/releases/#get-the-latest-release
    // Uses Application.ProductVersion
    public class UpdateChecker
    {
        private readonly string QueryURL = "https://api.github.com/repos/{0}/{1}/releases/latest"; // Owner, Repo
        private TimedWebClient client;

        public string Owner { get; private set; }
        public string Repo { get; private set; }

        private UpdateData _updateData;
        public UpdateData UpdateData
        {
            get
            {
                if (_updateData == null)
                {
                    GetLatestRelease();
                }

                return _updateData;
            }
        }

        public UpdateChecker(string Owner, string Repo)
        {
            this.Owner = Owner;
            this.Repo = Repo;
        }

        public void GetLatestRelease()
        {
            if (client == null)
            {
                client = new TimedWebClient(8000);
                client.Headers.Add("user-agent", "Ushanka"); // GitHub requires a User Agent to function
            }

            JObject ghData = JObject.Parse(client.DownloadString(string.Format(QueryURL, Owner, Repo)));

            UpdateData _ud = new UpdateData(
                (string)ghData["name"],
                (string)ghData["body"],
                DateTime.Parse((string)ghData["published_at"]),
                (string)ghData["tag_name"],
                (string)ghData["html_url"]);

            _updateData = _ud;
        }

        public bool IsLatestRelease()
        {
            int local_productVersion = Convert.ToInt32(Application.ProductVersion.Replace(".", ""));
            int remote_productVersion = Convert.ToInt32(UpdateData.Tag.Replace(".", ""));

            Console.WriteLine("Local Version: " + local_productVersion);
            Console.WriteLine("Remote Version: " + remote_productVersion);

            return local_productVersion >= remote_productVersion;
        }
    }

    public class UpdateData
    {
        public string Name { get; set; }
        public string Body { get; private set; }

        public DateTime PublishDate { get; private set; }

        public string Tag { get; private set; }
        public string URL { get; private set; }

        public UpdateData(string Name, string Body, DateTime PublishDate, string Tag, string URL)
        {
            this.Name = Name;
            this.Body = Body;

            this.PublishDate = PublishDate;

            this.Tag = Tag;
            this.URL = URL;
        }
    }

    public class TimedWebClient : WebClient
    {
        // Timeout in milliseconds, default = 600,000 msec
        public int Timeout { get; set; }

        public TimedWebClient()
        {
            this.Timeout = 600000;
        }

        public TimedWebClient(int TimeoutAmount)
        {
            this.Timeout = TimeoutAmount;
        }

        protected override WebRequest GetWebRequest(Uri address)
        {
            var objWebRequest = base.GetWebRequest(address);
            objWebRequest.Timeout = this.Timeout;
            return objWebRequest;
        }
    }
}
