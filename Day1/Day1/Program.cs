using Day1.Factory;
using Day1.Singleton;
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
            // ################## Singleton ###################
            Day1.Singleton.Program.Singleton(args);
            // ################## Factory #####################
            Day1.Factory.Program.Factory(args);
        }
    }
}
