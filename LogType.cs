namespace Logger {
	public class LogType {
		public LogTypeEnum Type;

		public string CustomName;

		public LogType(LogTypeEnum type) {
			this.Type = type;
		}

		public LogType(string custonName) {
			this.Type = LogTypeEnum.CUSTOM;
			this.CustomName = custonName;
		}

		public override string ToString() {
			if(Type == LogTypeEnum.CUSTOM)
				return CustomName;

			return Type.ToString();
		}
	}
}
