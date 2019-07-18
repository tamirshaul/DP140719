using System;
namespace Test.Exercise12
{
    public class GamerComputerBuilder : ComputerBuilder
    {
        protected override void BuildMaaraz()
        {
            Console.WriteLine("Maaraz: Regular");
        }

        protected override void AddMotherBoard()
        {
            Console.WriteLine("Mother Board: Regular");
        }

        protected override void AddCPU()
        {
            Console.WriteLine("CPU: High end");
        }

        protected override void AddGPU()
        {
            Console.WriteLine("GPU: High end");
        }

        protected override void AddRAM()
        {
            Console.WriteLine("RAM: Alot");
        }
    }
}
