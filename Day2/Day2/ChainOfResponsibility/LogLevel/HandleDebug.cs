using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.ChainOfResponsibility.LogLevel
{
    class HandleDebug : LogHandlerBase
    {
        private int currLevel = 4;
        public override void Handle(string msg, int level)
        {
            if (level != currLevel)
            {
                Console.WriteLine("Not a debug message. continueing...");
                if (next != null)
                {
                    next.Handle(msg, level);
                }
            }
            else
            {
                Console.WriteLine($"Debug log message: { msg }, Level is: { level }");
            }
        }
    }
}
