using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ushanka
{
    public class Log
    {
        public Log() { }

        public void WriteLine(string Text) => WriteLine(Text, LogType.Info);

        public void WriteLine(string Text, LogType logType)
        {
            if (LogOutput != null)
            {
                LogOutputEventArgs args = new LogOutputEventArgs();
                args.Text = Text;
                args.LogType = logType;
                OnLogOuput(args);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine(string.Format("<{0}> {1}", logType.ToString(), Text));
            }
        }

        protected virtual void OnLogOuput(LogOutputEventArgs e)
        {
            LogOutput?.Invoke(this, e);
        }

        public event EventHandler<LogOutputEventArgs> LogOutput;
    }

    public class LogOutputEventArgs : EventArgs
    {
        public string Text { get; set; }
        public LogType LogType { get; set; }
    }

    public enum LogType
    {
        Info,
        Warning,
        Error,
    }
}
