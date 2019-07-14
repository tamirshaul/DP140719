using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.State
{
    public class IAmOn : ILightState
    {
        public ILightState Fix()
        {
            Console.WriteLine("Already working");
            return this;
        }
        public ILightState TurnOff()
        {
            Console.WriteLine("Turning off the light...");
            return new IAmOff();
        }

        public ILightState TurnOn()
        {
            Console.WriteLine("You broke it!!");
            return new IAmBroken();
        }
    }
}
