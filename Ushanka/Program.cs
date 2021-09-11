using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ushanka
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (Mutex mutex = new Mutex(false, @"Global\WoljixSoftware-Ushanka"))
            {
                GC.KeepAlive(mutex);

                bool createdNew = !mutex.WaitOne(TimeSpan.Zero);

                if (!createdNew)
                {
                    Environment.CurrentDirectory = AppContext.BaseDirectory; // Dirty fix.

                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Form1());
                }
                else
                {
                    MessageBox.Show("Only one instance allowed!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
