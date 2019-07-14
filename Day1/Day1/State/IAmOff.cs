using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.State
{
    class IAmOff : ILightState
    {
        public ILightState Fix()
        {
            Console.WriteLine("Already working");
            return this;
        }

        public ILightState TurnOff()
        {
            Console.WriteLine("Light is already off...");
            return this;
        }

        public ILightState TurnOn()
        {
            Console.WriteLine("Turning on the light...");
            return new IAmOn();
        }
    }
}
