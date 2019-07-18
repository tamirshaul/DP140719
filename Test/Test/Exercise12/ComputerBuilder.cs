using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Exercise12
{
    public abstract class ComputerBuilder
    {
        protected Computer computer;

        public Computer GetComputer()
        {
            if (computer == null)
                throw new ComputerNotReadyException("First prepare the computer!");

            return computer;
        }

        public void Buildcomputer()
        {
            this.computer = new Computer();
            BuildMaaraz();
            AddMotherBoard();
            AddCPU();
            AddGPU();
            AddRAM();
            RunTests();
        }

        protected abstract void BuildMaaraz();

        protected abstract void AddMotherBoard();

        protected abstract void AddCPU();

        protected abstract void AddGPU();

        protected abstract void AddRAM();
        protected void RunTests()
        {
            Console.WriteLine("Run tests");
        }
    }
}
