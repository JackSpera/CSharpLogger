using Logging;

class TestSecurePrivate {
    public static void Main(string[] argv) {
        Logger logger = new Logger("Test.Secure.Private", SecureLevel.NONE);
        logger.Debug("Debugghiamo");
        logger.Info("Testiamo");
        logger.Warn("Warniamo");
        logger.Error("Oh Noes");
        logger.Severe("Non Siamo troppo Severi");
        logger.Custom("TAG", "Custom Tag");

        logger.Info("Can we see Logs??");
        if(logger.Data != null){
            logger.Custom("SUCCESS", "Yeah, We can");
            logger.Info(string.Join("\r\n\t", logger.Data));
        } else {
            logger.Error("No, we can't");
        }
    }
}