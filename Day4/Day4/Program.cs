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

            // #################### Proxy, Facade ##########################

            Day4.Facade.Program.Flight(args);

            // ###################### Bridge ###############################

            Day4.Bridge.Program.Bridge(args);

            // ###################### FlyWeight ############################

            Day4.FlyWeight.Program.FlyWeight(args);
        }
    }
}
