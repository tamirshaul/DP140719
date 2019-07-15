using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.ChainOfResponsibility.LogLevel
{
    public class Program
    {
        public static void LogLevel(string[] args)
        {
            LogHandlerBase fatal = new HandleFatal();
            LogHandlerBase error = new HandleError();
            LogHandlerBase info = new HandleInfo();
            LogHandlerBase debug= new HandleDebug();

            LogHandlerBase chainRoot = fatal;

            fatal.SetNext(error);
            error.SetNext(info);
            info.SetNext(debug);

            chainRoot.Handle($"debug message ",4);
            chainRoot.Handle($"info message ",3);
            chainRoot.Handle($"error message ",2);
            chainRoot.Handle($"fatal message ", 1);

            // ###### Oposite order
            Console.WriteLine("================== Oposite order now: ================");
            LogHandlerBase chainRootOp = debug;

            debug.SetNext(info);
            info.SetNext(error);
            error.SetNext(fatal);

            chainRootOp.Handle($"debug message ", 4);
            chainRootOp.Handle($"info message ", 3);
            chainRootOp.Handle($"error message ", 2);
            chainRootOp.Handle($"fatal message ", 1);

        }
    }
}
