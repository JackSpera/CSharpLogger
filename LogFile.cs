using System.Collections.Generic;

namespace Logger {
	class LogFile {
		public string FilePath = "";

		public char OpenBracket = '[';
		public char CloseBracket = ']';

		//TODO
		private SecureLevel Lock = SecureLevel.PUBLIC;

		public List<Log> Data = new List<Log>();

		public LogFile(string filePath, SecureLevel lockLevel=SecureLevel.SEE_ONLY){
			this.FilePath = filePath;
			this.Lock = lockLevel;
		}
	}
}
