using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Time
    {
        private static Time INSTANCE;
        private static object key = new object();
        private Time()
        {

        }

        public static Time GetInstance()
        {
            if (INSTANCE != null)
            {
                return INSTANCE;
            }
            lock (key)
            {
                if (INSTANCE == null)
                {
                    INSTANCE = new Time();
                }
            }
            return INSTANCE;
        }

        public void PrintTime()
        {
            Console.WriteLine("The time is:" + DateTime.Now.ToString());
        }
    }
}
