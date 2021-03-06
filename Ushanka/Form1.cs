﻿using Glastroika.API;
using InstaDump;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ushanka.GitHubUpdate;

namespace Ushanka
{
    // Production began on 26.02.2019
    // Made for Snowjix

    // Eternal todo: Clean up code.

    public partial class Form1 : Form
    {
        private UpdateChecker updateChecker;

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

                Settings.Save(SettingsFile); // Creates a new settings file and populates already existing files with new properties.
            }
            catch (Exception ex)
            {
                Log.WriteLine(ex.ToString());
            }
            
            webClient = new WebClient();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateChecker = new UpdateChecker("Woljix", "Ushanka");

            bool _isLatest = updateChecker.IsLatestRelease();

            Console.WriteLine("Is Latest Release: " + _isLatest);

            if (!_isLatest)
            {
                Label _label = new Label();
                _label.Font = new Font(_label.Font, FontStyle.Bold);
                _label.Dock = DockStyle.Top;
                _label.AutoSize = false;
                _label.TextAlign = ContentAlignment.MiddleCenter;
                _label.Text = "NEW UPDATE AVAILABLE! CLICK HERE TO GO TO GITHUB!";

                _label.Click += delegate
                {
                    Process.Start("https://github.com/Woljix/Ushanka/releases");
                };

                settingsPage.Controls.Add(_label);
            }

            if (Settings.Loaded.DebugMode)
            {
                if (logBox == null) return; // Just in case.

                Log.LogOutput += delegate (object s, LogOutputEventArgs lo)
                {
                    tabControl1.Invoke(new Action(() =>
                    {
                        Color _color;

                        switch (lo.LogType)
                        {
                            default:
                            case LogType.Info: _color = Color.Black; break;
                            case LogType.Warning: _color = Color.Goldenrod; break;
                            case LogType.Error: _color = Color.DarkRed; break;
                        }

                        logBox.SelectionColor = _color;
                        logBox.AppendText(lo.Text + "\n");
                    }));
                };
            }
            else
            {
               // tabControl1.TabPages.RemoveAt(4);
                foreach(TabPage tb in tabControl1.TabPages)
                {
                    if (tb.Name == "logPage")
                    {
                        tabControl1.TabPages.Remove(tb);
                    }
                }
            }

            CheckForIllegalCrossThreadCalls = false;

            single_textBox.Text = (!string.IsNullOrEmpty(Settings.Loaded.DefaultSingleID)) ? Settings.Loaded.DefaultSingleID : single_textBox.Text;
            pp_tb_username.Text = (!string.IsNullOrEmpty(Settings.Loaded.DefaultProfilePicture)) ? Settings.Loaded.DefaultProfilePicture : pp_tb_username.Text;

            settings_downloadTextBox.Text = Settings.Loaded.DownloadLocation;
            settings_logTextBox.Text = Settings.Loaded.LogLocation;

            multiple_usernameBox.Text = string.Join(Environment.NewLine, Settings.Loaded.Usernames);

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
                //"⬆️⬆️⬇️⬇️⬅️➡️⬅️➡️🅱️🅰️",
                "Up Up Down Down Left Right Left Right B A Start",
                "EST 2019",
                "May contain easter eggs!",
                "Also check out my christian Minecraft server!",
                "Instagram please don't nerf plz",
                "Thank you fow using my pwogwam senpai OwO",
                "Stop! You have violated the law!",
                "*Pulls Out Meat Scepter*",
                "The hat is hiding something. Maybe you should punch it!",
                "Fork me on GitHub",
                "RTX On",
                "Rise and Shine, Mr. Freeman.",
                "Do you actually read these?",
                "Don't tell Instagram about this, ok?",
                "A lil rusty around the edges!",
                "Pointless Updates Around The Clock!",
                "Contains a few bu- I MEAN FEATURES!",
                "ONE TAKE!",
                "Bodging Works!",
                "So.. ehm.. seen any good movies lately?",
                "I'll be back.",
                "Achievment Unlocked: Questionable Decisions.",
                "sudo shutdown now",
                "Look, sir! Droids!",
            });

            single_randomText.Text = _titles[rdm.Next(0, _titles.Count)];
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (Settings.Loaded.CheckForUpdates)
            {
                UpdateChecker updateChecker = new UpdateChecker("Woljix", "Ushanka");

                if (!updateChecker.IsLatestRelease())
                {
                    if (new UpdateForm(updateChecker).ShowDialog() == DialogResult.OK)
                    {
                        Console.WriteLine("AGREED");
                    }
                }
            }
        }

        #region Single

        private Media media;
        private int Index = 0;

        private void single_loadButton_Click(object sender, EventArgs e)
        {
            Invoke(new Action(() => 
            {
                Log.WriteLine("Single load button pressed!");

                string med_id = single_textBox.Text; // Should be 11 characters long

                if (media?.Shortcode != med_id)
                {
                    Index = 0;
                    single_prevButton.Enabled = false;
                    single_nextButton.Enabled = false;
                    single_saveAllButton.Enabled = false;
                    single_saveButton.Enabled = false;
                    single_pictureBox.ImageLocation = string.Empty;

                    if (med_id.Length == 11)
                    {
                        media = Instagram.GetMedia(med_id);

                        if (media != null)
                        {
                            ChangeIndex(Direction.Stay);
                            single_saveButton.Enabled = true;

                            single_saveAllButton.Enabled = (media.URL.Count > 1);
                        }
                        else
                        {
                            MessageBox.Show("Media ID was invalid or some other error happened!\nPro Tip: IDs should look like this: 'BuWp_d3F9Ab'", "Oh damn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Media ID should be 11 characters long!", "Oh oh", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }));   
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
                    if (!Settings.Loaded.SpecialMode)
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

            switch (Path.GetExtension(fileName)) // There might be a better way to do this, but this works for now.
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

        private void Single_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                single_loadButton.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        #endregion

        #region Settings

        private string meme_lastSaveHash = string.Empty;
        private int meme_saveStreak = -1;

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                string _hash = Save();

                if (string.IsNullOrEmpty(meme_lastSaveHash))
                    meme_lastSaveHash = _hash;

                if (_hash == meme_lastSaveHash)
                    meme_saveStreak++;
                else
                    meme_saveStreak = 0;

                switch (meme_saveStreak)
                {

                    case 0: MessageBox.Show("Settings Saved!", "TADA!", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                    case 1: MessageBox.Show("Double Save!", "TADA!", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                    case 2: MessageBox.Show("Triple Save!", "TADA!", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                    case 3: MessageBox.Show("Ultra Save!", "TADA!", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                    case 4: MessageBox.Show("MONSTER SAVE!!!", "TADA!", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                    case 5: MessageBox.Show("SAVING SPREE!", "TADA!", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                    case 6: MessageBox.Show("RAMPAGE!", "TADA!", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                    case 7: MessageBox.Show("DOMINATING!", "TADA!", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                    case 8: MessageBox.Show("UNSTOPPABLE!", "TADA!", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                    case 9: MessageBox.Show("GODLIKE!", "TADA!", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                    default: case 10: MessageBox.Show("HOOOOOOOOLY SHIIIT!!!", ":O", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                    case 20: MessageBox.Show("HOOOOOOOOLY SHIIIT!!!", ":O", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                    case 21: MessageBox.Show("HOOOOOOLY SHIIT!!", ":O", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                    case 22: MessageBox.Show("HOOOLY SHIT!!", ":o", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                    case 23: MessageBox.Show("HOLY SHIT!", ":o", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                    case 24: MessageBox.Show("H-HOLY.. SHIT", ":o", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                    case 25: MessageBox.Show("Ehm..", ":I", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                    case 26: MessageBox.Show("You still not tired of pressing Save, ey?", ":I", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                    case 27: MessageBox.Show("Well, you do you, bro! I'll go back to saying holy shit now.", ":I", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                }

                meme_lastSaveHash = _hash;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unhandled Error!", "OH NOES!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log.WriteLine("Unhandled error: " + ex.Message, LogType.Error);
            }  
            
            //try
            //{
            //     Save();

            //     MessageBox.Show("Settings Saved!", "TADA!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        
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

        private void button1_Click(object sender, EventArgs e)
        {
            new aboutForm().ShowDialog();
        }

        #endregion

        #region Multiple

        private async void multiple_goButton_Click(object sender, EventArgs e)
        {
            Save(); // Save the new settings, if this function fails we'll get problem.

            await Task.Run(() => 
            {
                try
                {
                    multiple_goButton.Enabled = false;

                    foreach (string _user in Settings.Loaded.Usernames)
                    {
                        User user = Instagram.GetUser(_user, multiple_getEverything.Checked);

                        if (user != null)
                        {
                            label_log_username.Text = _user;

                            string userDownloadFolder = Directory.CreateDirectory(Path.Combine(Settings.Loaded.DownloadLocation, _user)).FullName;

                            if (!user.IsPrivate && user.Media.Count > 0)
                            {
                                multiple_progressBar.Maximum = user.Media.Count - 1;

                                tabControl2.Invoke(new Action(() =>
                                {
                                    for (int i = 0; i < user.Media.Count; i++)
                                    {
                                        multiple_progressBar.Value = i;

                                        foreach(string url in user.Media[i].URL)
                                        {
                                            string fileName = Path.GetFileName(new Uri(url).LocalPath);

                                            label_log_filename.Text = fileName;

                                            Echo(string.Format("Downloading: '{0}'", fileName), _user);
                                            Log.WriteLine(string.Format("<{0}> Downloading: '{1}'", _user, fileName));

                                            string fileToBe = Path.Combine(userDownloadFolder, fileName);

                                            if (!File.Exists(fileToBe))
                                                webClient.DownloadFile(url, fileToBe);
                                        }
                                    }
                                }));
                            }
                        }  
                    }

                    multiple_goButton.Enabled = true;

                    MessageBox.Show("Finished Downloading!", "WOHO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(JsonSerializationException ex)
                {
                    string errorMsg = "Some error happened while processing the backend JSON\n" +
                                      "This is sadly out of my control, so i just recommend restarting the program and/or..\n" +
                                      "waiting a few seconds before retrying!";

                    Log.WriteLine(errorMsg);
                    MessageBox.Show(errorMsg, "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    Log.WriteLine("Unhandled error while scraping: " + ex.ToString());
                }             
            });
        }

        #endregion

        public string Save()
        {
            Settings.Loaded.DownloadLocation = settings_downloadTextBox.Text;
            Settings.Loaded.LogLocation = settings_logTextBox.Text;

            Settings.Loaded.Usernames = multiple_usernameBox.Text.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string _hash =Settings.Save(SettingsFile);

            Log.WriteLine("Settings Saved!");

            return _hash;
        }

        private void Echo(string Text, string Username)
        {
            if (!multiple_logBox.IsDisposed)
            {
                tabControl2.Invoke(new Action(() => 
                {
                    multiple_logBox.AppendText(string.Format("[{0}][{1}] {2}", DateTime.Now.ToString(), Username, Text) + "\n");
                }));
            }       
        }

        #region Profile Picture

        private string currentPP = string.Empty;

        private void Pp_loadButton_Click(object sender, EventArgs e)
        {
            string _url = string.Empty;

            this.Invoke(new Action(() =>
            {
                pp_save.Enabled = false;
                currentPP = string.Empty;
                pp_pictureBox.ImageLocation = string.Empty;

                try
                {
                    _url = Instagram.GetProfilePicture(pp_tb_username.Text) ?? Instagram.GetUser(pp_tb_username.Text).ProfilePicture;
                }
                catch (Exception ex)
                {
                    _url = string.Empty; // Kinda redundant, i know :)
                    Log.WriteLine("PP Load Error: " + ex.ToString(), LogType.Error);
                   // Debug.WriteLine(ex.ToString());
                }

                if (!string.IsNullOrEmpty(_url))
                {
                    currentPP = _url;

                    pp_pictureBox.ImageLocation = currentPP;
                    pp_save.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Could not load their profile picture for some reason!", "Sorry about that!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }));           
        }

        private void Pp_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            string url = currentPP;
            string fileName = Path.GetFileName(new Uri(url).LocalPath);

            sfd.Filter = "JPEG File (*.jpg)|*.jpg";
            sfd.FileName = fileName;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                webClient.DownloadFile(url, sfd.FileName);
            }
        }

        

        private void Pp_tb_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pp_loadButton.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        #endregion

        private void SettingsPage_Enter(object sender, EventArgs e)
        {
            Debug.WriteLine("SETTINGS FOCUSED!" );
        }

        private void button_openDownloads_Click(object sender, EventArgs e)
        {
            string _dir = settings_downloadTextBox.Text;

            if (Directory.Exists(_dir))
            {
                Process.Start("explorer.exe", _dir);
            }
            else
            {
                MessageBox.Show("Download location is not valid!", "Sowwy!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
