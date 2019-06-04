using Glastroika.API;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace InstaDump
{
    public class Scraper
    {
        private readonly string query_hash = "f2405b236d85e8296cf30347c9f08c2a"; // If the software should suddently not work, this might be the issue.
        private WebClient client;

        public string Username { get; private set; }
        public bool GetEverything { get; private set; } // This will get everything, and not just the first 12 items

        private string ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Username">Instagram username of the target</param>
        /// <param name="GetEverything">Should we get more than the first 12 medias</param>
        public Scraper(string Username, bool GetEverything)
        {
            this.Username = Username;
            this.GetEverything = GetEverything;

            client = new WebClient();
        }

        /// <summary>
        /// This will start the scraping process.
        /// </summary>
        /// <returns>An array of URLs</returns>
        public List<string> DoWork()
        {
            List<string> _mediaList = new List<string>();

            JObject homeObj = JObject.Parse(client.DownloadString(string.Format("https://www.instagram.com/{0}/?__a=1", Username)));

            ID = (string)homeObj["graphql"]["user"]["id"];

            bool IsPrivate = (bool)homeObj["graphql"]["user"]["is_private"];

            if (IsPrivate) return null;

            string endcursor = string.Empty;
            bool has_next_page = true;

            while (has_next_page)
            {
                JObject _ql = JObject.Parse(client.DownloadString(GetQueryString(query_hash, ID, endcursor)));

                JArray _media = (JArray)_ql["data"]["user"]["edge_owner_to_timeline_media"]["edges"];

                for (int i = 0; i < _media.Count; i++)
                {
                    _mediaList.AddRange(ProcessNode((JObject)_media[i]));
                }

                has_next_page = (bool)_ql["data"]["user"]["edge_owner_to_timeline_media"]["page_info"]["has_next_page"];

                if (has_next_page)
                {
                    endcursor = (string)_ql["data"]["user"]["edge_owner_to_timeline_media"]["page_info"]["end_cursor"];
                }

                if (!GetEverything) has_next_page = false;
            }

            return _mediaList;
        }

        private List<string> ProcessNode(JObject node)
        {
            List<string> _output = new List<string>();

            switch ((string)node["node"]["__typename"])
            {
                default:
                case "GraphImage":
                    _output.Add(((string)node["node"]["display_url"]));
                    break;

                case "GraphVideo":
                    _output.Add(((string)node["node"]["video_url"]));
                    break;
                case "GraphSidecar":
                    JArray edges = (JArray)node["node"]["edge_sidecar_to_children"]["edges"];

                    for (int x = 0; x < edges.Count; x++)
                    {
                        _output.AddRange(ProcessNode((JObject)edges[x]));
                    }
                    break;
            }

            return _output;
        }

        private string GetQueryString(string query_hash, string id, string end_cursor)
        {
            string _url = string.Empty;

            Uri _uri = new Uri("https://www.instagram.com/graphql/query/?query_hash=" + query_hash + "&variables={\"id\":\"" + id + "\",\"first\":12,\"after\":\"" + end_cursor + "\"}");

            return _uri.AbsoluteUri; // This gets an encoded string, which is probably better than uncoded.
        }
    }

    public class MediaAquiredEventArgs : EventArgs
    {
        public string URL { get; set; }
        public string Owner { get; set; }
        public DateTime Time { get; set; }
    }
}
