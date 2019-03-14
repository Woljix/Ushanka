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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ushanka
{
    // Production began on 26.02.2019
    // Made for Snowjix

    public partial class Form1 : Form
    {
        public WebClient webClient;

        public readonly string SettingsFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Settings.json");

        public Form1()
        {
            InitializeComponent();

            try
            {
                if (File.Exists(SettingsFile))
                {
                    Settings.Load(SettingsFile);
                }
            }
            catch
            {
                // Catch error here
            }
            

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
                {
                    if (!Settings.LoadedSettings.SpecialMode)
                        single_pictureBox.Image = Properties.Resources.pug_placeholder;
                    else
                        single_pictureBox.Image = Properties.Resources.daisy_placeholder;
                }
                    
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
            CheckForIllegalCrossThreadCalls = false;

            settings_downloadTextBox.Text = Settings.LoadedSettings.DownloadLocation;
            settings_logTextBox.Text = Settings.LoadedSettings.LogLocation;

            multiple_usernameBox.Text = String.Join(Environment.NewLine, Settings.LoadedSettings.Usernames);

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

            //if (Settings.LoadedSettings.SpecialMode)
            //    _titles.AddRange(new string[]
            //        {
            //            "",
            //        });

            single_randomText.Text = _titles[rdm.Next(0, _titles.Count)];
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                Save();

                MessageBox.Show("Settings Saved!", "TADA!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Unhandled Error!", "OH NOES!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Catch error plz
            }          
        }

        private void button_downloadLocation_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                settings_downloadTextBox.Text = fbd.SelectedPath;
            }
        }

        private void button_logLocation_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                settings_logTextBox.Text = fbd.SelectedPath;
            }
        }

        private bool IsBusy = false;

        private void multiple_goButton_Click(object sender, EventArgs e)
        {
            if (IsBusy) return;

            Save(); // Save the new settings, if this function fails we'll get program.

            // I don't really like to use threads, but they just work the best.
            // And for some reason after this function runs the logbox just cease to exist. (Sometimes, it's weird.)

            new Thread(() => 
            {
                IsBusy = true; // bad solution, but hey it works.

                foreach(string _user in Settings.LoadedSettings.Usernames)
                {
                    User user = Instagram.GetUser(_user);

                    label_log_username.Text = user.Username;

                    if (user != null)
                    {
                        string userDownloadFolder = Directory.CreateDirectory(Path.Combine(Settings.LoadedSettings.DownloadLocation, _user)).FullName;

                        List<Media> _media = user.Media;

                        multiple_progressBar.Maximum = _media.Count - 1;

                        for (int i = 0; i < _media.Count; i++)
                        {
                            multiple_progressBar.Value = i;

                            Media media = _media[i];

                            foreach (string url in media.URL)
                            {      
                                string fileName = Path.GetFileName(new Uri(url).LocalPath);

                                label_log_filename.Text = fileName;
                                Echo(string.Format("Downloading: '{0}'", fileName), _user);

                                webClient.DownloadFile(url, Path.Combine( userDownloadFolder, fileName));
                            }
                        }
                    }
                    else
                    {
                        Echo("Username is invalid! Ignoring!", _user);
                    }
                }

                IsBusy = false;
                MessageBox.Show("Finished Downloading!", "WOHO!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }).Start();
        }

        public void Save()
        {
            Settings.LoadedSettings.DownloadLocation = settings_downloadTextBox.Text;
            Settings.LoadedSettings.LogLocation = settings_logTextBox.Text;

            Settings.LoadedSettings.Usernames = multiple_usernameBox.Text.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();

            Settings.Save(SettingsFile);
        }

        private void Echo(string Text, string Username)
        {
            multiple_logBox.AppendText(string.Format("[{0}][{1}] {2}", DateTime.Now.ToString(), Username, Text) + "\n");
        }
    }
}
