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
            //Day1.Singleton.Program.Singleton(args);
            // ################## Factory #####################
            //Day1.Factory.Program.Factory(args);
            // ################## State #######################
            //Day1.State.Program.State(args);
            // ################## State : Login ###############
            Day1.State.Login.Program.LoginExercise(args);
            Console.ReadLine();
        }
    }
}
