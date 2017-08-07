namespace Logger {
	public class Logger {
		private LogFile File;

		public Logger(string path) {
			this.File = new LogFile(path);
		}

		public void Info(string data) => File.Write(new LogType(LogTypeEnum.INFO), data);

		public void Warn(string data) => File.Write(new LogType(LogTypeEnum.WARN), data);
		public void Warning(string data) => File.Write(new LogType(LogTypeEnum.WARN), data);

		public void Error(string data) => File.Write(new LogType(LogTypeEnum.Error), data);

		public void Severe(string data) => File.Write(new LogType(LogTypeEnum.Severe), data);

		public void Custom(string tag, string data) => File.Write(new LogType(tag), data);


	}
}
