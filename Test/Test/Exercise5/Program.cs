using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Exercise5
{
    public class Program
    {
        public static void Exercise5(string[] args)
        {
            LogHandlerBase fatal = new HandleFatal();
            LogHandlerBase error = new HandleError();
            LogHandlerBase info = new HandleInfo();

            LogHandlerBase chainRoot = fatal;

            fatal.SetNext(error);
            error.SetNext(info);

            chainRoot.Handle($"info message ",3);
            chainRoot.Handle($"error message ",2);
            chainRoot.Handle($"fatal message ", 1);

            // ###### Oposite order
            Console.WriteLine("================== Oposite order now: ================");
            LogHandlerBase chainRootOp = info;

            info.SetNext(error);
            error.SetNext(fatal);

            chainRootOp.Handle($"info message ", 3);
            chainRootOp.Handle($"error message ", 2);
            chainRootOp.Handle($"fatal message ", 1);

        }
    }
}
