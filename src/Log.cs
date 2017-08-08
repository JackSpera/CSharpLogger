using System;

namespace Logging{
    public class Log{
        private LogFile Parent;

        public LogType Type;

        public string Data;

        public DateTime Time;

        public Log(LogFile parent, LogType type, string data){
            this.Parent = parent;
            this.Type = type;
            this.Data = data;
            this.Time = DateTime.Now;
        }

        public override string ToString() {
            // "{Parent.OpenBracket}{Date}{Parent.CloseBracket}{Parent.OpenBracket}{LogType}{Parent.CloseBracket}{Data}";
            // ||
            // \/
            // "{0}{2}{1}{0}{3}{1}{4}"
            return String.Format(Parent.Format,
                Parent.OpenBracket, Parent.CloseBracket,
                Time, Type, Data);
        }
    }
}