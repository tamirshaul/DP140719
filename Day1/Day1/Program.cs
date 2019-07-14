using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Time t1 = Time.GetInstance();
            Time t2 = Time.GetInstance();
            Time t3 = Time.GetInstance();

            t1.PrintTime();
            t2.PrintTime();
            t3.PrintTime();
        }
    }
}
