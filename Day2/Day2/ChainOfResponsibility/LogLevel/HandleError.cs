using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.ChainOfResponsibility.LogLevel
{
    class HandleError : LogHandlerBase
    {
        private int currLevel = 2;
        public override void Handle(string msg, int level)
        {
            if (level != currLevel)
            {
                Console.WriteLine("Not an error message. continueing...");
                if (next != null)
                {
                    next.Handle(msg, level);
                }
            }
            else
            {
                Console.WriteLine($"Error log message: { msg }, Level is: { level }");
            }
        }
    }
}
