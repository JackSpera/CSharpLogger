using Logging;

class TestExtension {
    public static void Main(string[] argv) {
        Logger logger = new Logger("Test.Extension.dat", useExtension: false);
        
        logger.Debug("Debugghiamo");
        logger.Info("Testiamo");
        logger.Warn("Warniamo");
        logger.Error("Oh Noes");
        logger.Severe("Non Siamo troppo Severi");
        logger.Custom("TAG", "Custom Tag");
    }
}