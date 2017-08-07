namespace Logging {
	public class Logger {
		private LogFile File;

		public Logger(string filePath, SecureLevel lockLevel=SecureLevel.SEE_ONLY, bool useExtension=true) {
			this.File = new LogFile(filePath, lockLevel, useExtension);
		}

		public void Debug(string data) => File.Write(new LogType(LogTypeEnum.DEBUG), data);
		public void Info(string data) => File.Write(new LogType(LogTypeEnum.INFO), data);

		public void Warn(string data) => File.Write(new LogType(LogTypeEnum.WARN), data);
		public void Warning(string data) => File.Write(new LogType(LogTypeEnum.WARN), data);

		public void Error(string data) => File.Write(new LogType(LogTypeEnum.ERROR), data);

		public void Severe(string data) => File.Write(new LogType(LogTypeEnum.SEVERE), data);

		public void Custom(string tag, string data) => File.Write(new LogType(tag), data);


	}
}
