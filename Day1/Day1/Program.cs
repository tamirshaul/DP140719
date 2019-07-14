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
            Console.WriteLine("Welcome to Singleton");
            Console.WriteLine();

            Time t1 = Time.GetInstance();
            Time t2 = Time.GetInstance();
            Time t3 = Time.GetInstance();

            t1.PrintTime();
            t2.PrintTime();
            t3.PrintTime();

            // ################## Factory #####################
            Console.WriteLine();
            Console.WriteLine("Welcome to Factory");
            Console.WriteLine();

            VehicleFactory factory = new VehicleFactory();

            int numberOfWheels = 0;
            Console.Write("Enter number of wheels: ");
            numberOfWheels = Convert.ToInt32(Console.ReadLine());

            
            while (numberOfWheels != -1)
            {
                Vehicle newVehicle = factory.CreateVehicle("Honda", 2000, "red", numberOfWheels, "General");
                Console.WriteLine(newVehicle);

                Console.Write("Enter number of wheels: ");
                numberOfWheels = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Good bye!");

            Console.ReadLine();

        }
    }
}
