using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Exercise3
{
    class Car : ICar
    {
        public void Accelerate()
        {
            Console.WriteLine("accelerate");
        }

        public void ShowGas()
        {
            Console.WriteLine("gas");
        }

        public void ShowLocation()
        {
            Console.WriteLine("location");
        }

        public void Slow()
        {
            Console.WriteLine("slow");
        }

        public void Start()
        {
            Console.WriteLine("start");
        }

        public void Stop()
        {
            Console.WriteLine("stop");
        }

        public void TurnLeft()
        {
            Console.WriteLine("left");
        }

        public void TurnRight()
        {
            Console.WriteLine("right");
        }
    }
}
