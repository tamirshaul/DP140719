using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Exercise12
{
    public class OfficeComputerBuilder : ComputerBuilder
    {
        protected override void BuildMaaraz()
        {
            Console.WriteLine("Maaraz: Mid range");
        }

        protected override void AddMotherBoard()
        {
            Console.WriteLine("Mother Board: Mid range");
        }

        protected override void AddCPU()
        {
            Console.WriteLine("CPU: Mid range");
        }

        protected override void AddGPU()
        {
            Console.WriteLine("GPU: Mid range");
        }

        protected override void AddRAM()
        {
            Console.WriteLine("RAM: Mid range");
        }
    }
}
