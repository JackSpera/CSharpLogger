using System.Collections.Generic;

namespace Logger {
	class LogFile {
		public string FilePath = "";

		public char OpenBracket = '[';
		public char CloseBracket = ']';

		private SecureLevel Lock;

		public List<Log> Data {
			get{
				if (Lock == SecureLevel.SEE_ONLY || Lock == SecureLevel.ALL)
					return Data;	

				return null;
			}



			set{
				if (Lock == SecureLevel.SET_ONLY || Lock == SecureLevel.ALL)
					Data = value;

				return;
			}
		}

		public string Format = "{Parent.OpenBracket}{Date}{Parent.CloseBracket}{Parent.OpenBracket}{LogType}{Parent.CloseBracket}{Data}";


		public LogFile(string filePath, SecureLevel lockLevel=SecureLevel.SEE_ONLY){
			this.FilePath = filePath;
			this.Lock = lockLevel;

			this.Data = new List<Log>();
		}
	}
}
