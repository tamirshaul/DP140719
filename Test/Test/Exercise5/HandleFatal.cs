using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Exercise5
{
    class HandleFatal : LogHandlerBase
    {
        private int currLevel = 1;
        private SendSMS sms = new SendSMS();
        public override void Handle(string msg, int level)
        {
            if (level != currLevel)
            {
                Console.WriteLine("Not a fatal message. continueing...");
                if (next != null)
                {
                    next.Handle(msg, level);
                }
            }
            else
            {
                Console.WriteLine($"Fatal log message: { msg }, Level is: { level } writing to array...");
                Console.WriteLine("Writing to file...");
                sms.Send();
            }
        }
    }
}
