using System.Collections.Generic;
using System.IO;

namespace Logging {
    public class LogFile {
        public string FilePath = "";

        public char OpenBracket = '[';
        public char CloseBracket = ']';

        private SecureLevel Lock;

        private bool UseExtension = true;



        private List<Log> _Data;
        public List<Log> Data {
            get {
                if (Lock == SecureLevel.SEE_ONLY || Lock == SecureLevel.ALL)
                    return _Data;   

                return null;
            }


            set {
                if (Lock == SecureLevel.SET_ONLY || Lock == SecureLevel.ALL)
                    _Data = value;

                return;
            }

        }
        // "{Parent.OpenBracket}{Date}{Parent.CloseBracket}{Parent.OpenBracket}{LogType}{Parent.CloseBracket}{Data}";
        // ||
        // \/
        // "{0}{2}{1}{0}{3}{1}{4}"
        public string Format = "{0}{2}{1}{0}{3}{1} {4}";


        public LogFile(string filePath, SecureLevel lockLevel, bool useExtension){
        this.FilePath = filePath;     this.Lock = lockLevel;
        this.UseExtension = useExtension;

            this._Data = new List<Log>();

        }


        public void Write(LogType type, string data) {
            Log log = new Log(this, type, data);

            using(StreamWriter stream = new StreamWriter(FilePath + (UseExtension ? ".log" : ""), true)) {
                stream.WriteLine(log.ToString());
            }


            _Data.Add(log);
        }
    }
}
