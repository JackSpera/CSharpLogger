using Logging;

class Test1 {
	public static void Main(string[] argv) {
		Logger logger = new Logger("Test.1");
		logger.Debug("Debugghiamo");
		logger.Info("Testiamo");
		logger.Warn("Warniamo");
		logger.Error("Oh Noes");
		logger.Severe("Non Siamo troppo Severi");
		logger.Custom("TAG", "Custom Tag");
	}
}