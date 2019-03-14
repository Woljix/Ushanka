using Glastroika.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ushanka
{
    // Production began on 26.02.2019
    // Made for Snowjix

    public partial class Form1 : Form
    {
        public WebClient webClient;

        public Form1()
        {
            InitializeComponent();

            webClient = new WebClient();
        }

        private Media media;
        private int Index = 0;

        private void single_loadButton_Click(object sender, EventArgs e)
        {
            Index = 0;
            single_prevButton.Enabled = false;
            single_nextButton.Enabled = false;
            single_saveAllButton.Enabled = false;
            single_saveButton.Enabled = false;
            single_pictureBox.ImageLocation = string.Empty;

            media = Instagram.GetMedia(single_textBox.Text);

            if (media != null)
            {
                ChangeIndex(Direction.Stay);
                single_saveButton.Enabled = true;

                single_saveAllButton.Enabled = (media.URL.Count > 1);
            }
            else
            {
                MessageBox.Show("Media ID was invalid or some other error happened!\nPro Tip: IDs should look like this: 'BuWp_d3F9Ab'", "Oh damn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangeIndex(Direction direction)
        {
            int _dir = 0;

            switch (direction)
            {
                case Direction.Next: _dir = 1; break;
                case Direction.Previous: _dir = -1; break;
                default: case Direction.Stay: _dir = 0; break;
            }

            int potentionIndex = Index + _dir;

            if (potentionIndex >= 0 && potentionIndex <= media.URL.Count)
            {
                Index = potentionIndex;
                string url = media.URL[Index];

                Debug.WriteLine(url);

                string ext = Path.GetExtension(new Uri(url).LocalPath);

                if (ext == ".mp4")
                    single_pictureBox.Image = Properties.Resources.pug_placeholder;
                else
                    single_pictureBox.ImageLocation = url;
            }

            single_prevButton.Enabled = (Index > 0);
            single_nextButton.Enabled = (Index < media.URL.Count - 1);
        }

        private enum Direction
        {
            Previous,
            Next,
            Stay
        }

        private void single_prevButton_Click(object sender, EventArgs e) { ChangeIndex(Direction.Previous); }
        private void single_nextButton_Click(object sender, EventArgs e) { ChangeIndex(Direction.Next); }

        private void single_saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            string url = media.URL[Index];
            string fileName = Path.GetFileName(new Uri(url).LocalPath);

            switch (Path.GetExtension(fileName))
            {
                case ".jpg": sfd.Filter = "JPEG File (*.jpg)|*.jpg"; break;
                case ".mp4": sfd.Filter = "MP4 File (*.mp4)|*.mp4"; break;
            }

            sfd.FileName = fileName;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                webClient.DownloadFile(url, sfd.FileName);
            }
        }

        private void single_saveAllButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            //fbd.RootFolder = Environment.SpecialFolder.CommonPictures;

            fbd.Description = "Please select a folder where i should download all of the files to!";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                foreach(string url in media.URL)
                {
                    string fileName = Path.GetFileName(new Uri(url).LocalPath);

                    webClient.DownloadFile(url, Path.Combine(fbd.SelectedPath, fileName));
                }

                MessageBox.Show("All Done!", "Voila!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rdm = new Random();

            List<string> _titles = new List<string>();

            _titles.AddRange(new string[] 
            {
                "Now with more Vitamin C",
                "Subscribe to PewDiePie",
                "Approved by Snowjix",
                "🎵 Hit or Miss 🎵",
                "1v1 me on rust",
                "C# > Java",
                "Now slightly less radioactive",
                "Sponsored by North Korea",
                "Removed Herobrine",
                "500% More User Friendly Than The Alternative",
                "May conntain speling erorrs!",
                //"⬆️⬆️⬇️⬇️⬅️➡️⬅️➡️🅱️🅰️"
                "Up Up Down Down Left Right Left Right B A Start",
                "EST 2019",
                "May contain easter eggs!",
                "Also check out my christian Minecraft server!"
            });

            single_randomText.Text = _titles[rdm.Next(0, _titles.Count)];
        }
    }
}
