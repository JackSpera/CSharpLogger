using Logging;

class TestCustomFormat {
    public static void Main(string[] argv) {
        Logger logger = new Logger("Test.CustomFormat");
        logger.Format = "{3}: {4}";

        logger.Debug("Debugghiamo");
        logger.Info("Testiamo");
        logger.Warn("Warniamo");
        logger.Error("Oh Noes");
        logger.Severe("Non Siamo troppo Severi");
        logger.Custom("TAG", "Custom Tag");
    }
}