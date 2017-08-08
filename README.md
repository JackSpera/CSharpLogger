# A Simple C#/Mono Library for Logging
With this library you can easy write to log file

You can Log:

 * _Debug_
 * _Info_
 * _Warning_
 * _Error_
 * _Severe Error_
 * Anything you want with  _Custom Tag_


## How To Use

You can  look at examples in [Test Directory](test/)

```C#
using Logging; // You need to use Logging namespace to use this library.

class Test1 {
    public static void Main(string[] argv) {
    
        Logger logger = new Logger("Test.1"); // Create a logger, First Parameter is the file path without the extension
       
       
        //You can use those Methods for classic logging.
        logger.Debug("Debugghiamo");
        logger.Info("Testiamo");
        logger.Warn("Warniamo");
        logger.Error("Oh Noes");
        logger.Severe("Non Siamo troppo Severi");
        
        //Or use a custom Tag.
        logger.Custom("TAG", "Custom Tag");
    }
}   
```

## Log File
The default Log Format is:  
`[00/00/0000 00:00:00][TAG] Log Data`

There is an Example from Test1.cs Program:
```
[07/08/2017 22:22:43][DEBUG] Debugghiamo
[07/08/2017 22:22:43][INFO] Testiamo
[07/08/2017 22:22:43][WARN] Warniamo
[07/08/2017 22:22:43][ERROR] Oh Noes
[07/08/2017 22:22:43][SEVERE] Non Siamo troppo Severi
[07/08/2017 22:22:43][TAG] Custom Tag
```

You can personalize this format, in next version it'is going to be much simpler
but for now you may use:  
`logger.File.OpenBracket` (Default is `[`)  
`logger.File.CloseBracket` (Default is `]`)  

and for format:
`logger.File.Format` (Default is `{0}{2}{1}{0}{3}{1} {4}`)  
Parameters are:  
 * 0: OpenBracket  
 * 1: CloseBracket  
 * 2: Date And Time  
 * 3: Log Tag  
 * 4: The Text  

## Next Steps
Next Steps for this Project are:
 * Saving Logs to DataBase
 * Logs more Secure
 * Custom Format more Easily


## How To Compile
You may compile all .cs files in `/src` Directory with `-t` param to `library` and `-out` to `Logger.dll`

`$ mcs *.cs -t:library -out:Logger.dll`

#### Tested with `Mono C# compiler version 5.0.1.0`
