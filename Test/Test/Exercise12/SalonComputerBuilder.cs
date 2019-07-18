using System;
namespace Test.Exercise12
{
    public class SalonComputerBuilder : ComputerBuilder
    {
        protected override void AddCPU()
        {
            Console.WriteLine("CPU: Regular");
        }

        protected override void AddGPU()
        {
            Console.WriteLine("GPU: High end");
        }

        protected override void AddMotherBoard()
        {
            Console.WriteLine("Mother Board: Very thin");
        }

        protected override void AddRAM()
        {
            Console.WriteLine("RAM: regular");
        }

        protected override void BuildMaaraz()
        {
            Console.WriteLine("Maaraz: Very thin");
        }
    }
}
