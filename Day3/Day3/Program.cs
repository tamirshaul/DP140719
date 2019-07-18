using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            // ####################### Visitor ############################

            Day3.Visitor.Program.VisitorQuestion(args);

            // ####################### Adapter ############################
            
            Day3.Adapter.Program.AdapterQuestion(args);

            // ################### Template Method ########################

            Day3.TemplateMethod.Program.TemplateMethod(args);

            Console.ReadLine();
        }
    }
}
