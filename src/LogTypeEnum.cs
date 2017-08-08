namespace Logging {
    public enum LogTypeEnum {

        DEBUG = 0x0,    //0b0000
        INFO = 0x1,     //0b0001
        WARN = 0x4,     //0b0100
        ERROR = 0x5,    //0b0101
        SEVERE = 0x6,   //0b0110
        
        CUSTOM = 0xF,   //0b1111
    }
}
