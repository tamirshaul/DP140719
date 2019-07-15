using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            // ###################### Chain Of Responsibility #######################
            Day2.ChainOfResponsibility.Program.ChainOfResponsibility(args);

            Day2.ChainOfResponsibility.LogLevel.Program.LogLevel(args);

            Console.ReadLine();

        }
    }
}
