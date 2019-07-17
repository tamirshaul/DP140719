using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            // ###################### Decorator ############################

            Day4.Decorator.Program.Decorator(args);

            Day4.Decorator.Formula.Program.Calculator(args);
        }
    }
}
