namespace Logger{
	class Log{
		private LogFile Parent;

		public LogType Type;

		public string Data;

		public Log(LogFile parent, LogType type, string data){
			this.Parent = parent;
			this.Type = type;
			this.Data = data;
		}
	}
}