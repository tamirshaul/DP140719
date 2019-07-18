using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Exercise12
{
    public class Program
    {
        public static void Exercise12(string[] args)
        {
            ComputerFactoryMethod factory = new ComputerFactoryMethod();

            factory.GetComputer("Gaming");
            Console.WriteLine();
            factory.GetComputer("Office");
            Console.WriteLine();
            factory.GetComputer("Salon");
        }
    }
}
