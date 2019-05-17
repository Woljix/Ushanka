using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Timer = System.Windows.Forms.Timer;

namespace Ushanka
{
    public partial class aboutForm : Form
    {
        public KonamiSequence konami;

        public aboutForm()
        {
            InitializeComponent();

            konami = new KonamiSequence();
        }

        private int clickAmount = 0;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            clickAmount++;

            if (clickAmount > 7)
            {
                clickAmount = 0;

                MessageBox.Show("Konami code");
            }
        }

        private void aboutForm_Load(object sender, EventArgs e) { }

        private void aboutForm_KeyUp(object sender, KeyEventArgs e)
        {
            Invoke(new Action(() => 
            {
                if (konami.IsCompletedBy(e.KeyCode))
                {
                    try
                    {
                        Random rdm = new Random();

                        InitiateEasterEgg(rdm.Next(0, 2));

                    }
                    catch
                    {
                        MessageBox.Show("Something cool was supposed to happen right now.\nI guess i fucked something up.\nSorry About That!");
                    }

                }
            }));            
        }

        #region Easter egg?s

        private bool MarioRunning = false;
        private PictureBox pb;
        private Timer timer;

        public void InitiateEasterEgg(int sel)
        {
            if (MarioRunning) return;

            MarioRunning = true;

            if (pb == null)
            {
                pb = new PictureBox();
                pb.SizeMode = PictureBoxSizeMode.Zoom;

                pb.Click += delegate
                {
                    Debug.WriteLine(pb.Location.ToString());
                };

                panel1.Controls.Add(pb);
            }

            int speed = 0;

            switch (sel)
            {
                case 0: // Mario
                    pb.Image = Properties.Resources.mario;
                    pb.Size = new Size(48, 48);

                    speed = 1;
                    break;

                case 1: // Sonoc
                    pb.Image = Properties.Resources.sonic;
                    pb.Size = new Size(58, 58);

                    speed = 3;
                    break;
            }

            pb.Location = new Point(-50, 203); // Go to slightly offscreen

            timer = new Timer();
            timer.Interval = 16;
            timer.Tick += delegate
            {
                pb.Location = new Point(pb.Location.X + speed, pb.Location.Y);

                if (pb.Location.X > 450)
                {
                    timer.Stop();
                    MarioRunning = false;
                }
            };

            timer.Start();
        }

        #endregion
    }


    // Not mine, i stole it from stackoverflow a long time ago.
    public class KonamiSequence
    {
        readonly Keys[] _code = { Keys.Up, Keys.Up, Keys.Down, Keys.Down, Keys.Left, Keys.Right, Keys.Left, Keys.Right, Keys.B, Keys.A };
        private int _sequenceIndex;

        private readonly int _codeLength;
        private readonly int _sequenceMax;

        private readonly System.Timers.Timer _quantum = new System.Timers.Timer();

        public KonamiSequence()
        {
            _codeLength = _code.Length - 1;
            _sequenceMax = _code.Length;

            _quantum.Interval = 3000; //ms before reset
            _quantum.Elapsed += timeout;
        }

        public bool IsCompletedBy(Keys key)
        {
            _quantum.Start();

            _sequenceIndex %= _sequenceMax;
            _sequenceIndex = (_code[_sequenceIndex] == key) ? ++_sequenceIndex : 0;

            return _sequenceIndex > _codeLength;
        }

        private void timeout(object o, EventArgs e)
        {
            _quantum.Stop();
            _sequenceIndex = 0;
        }
    }
}
