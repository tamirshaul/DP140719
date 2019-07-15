using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.ChainOfResponsibility.LogLevel
{
    class HandleInfo : LogHandlerBase
    {
        private int currLevel = 3;
        public override void Handle(string msg, int level)
        {
            if (level != currLevel)
            {
                Console.WriteLine("Not an info message. continueing...");
                if (next != null)
                {
                    next.Handle(msg, level);
                }
            }
            else
            {
                Console.WriteLine($"Info log message: { msg }, Level is: { level }");
            }
        }
    }
}
