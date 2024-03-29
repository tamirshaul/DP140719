﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.State
{
    class IAmBroken : ILightState
    {
        public ILightState Fix()
        {
            Console.WriteLine("Fixing.. and turning off");
            return new IAmOff();
        }
        public ILightState TurnOff()
        {
            Console.WriteLine("Light is broken...");
            return this;
        }

        public ILightState TurnOn()
        {
            Console.WriteLine("Light is broken...");
            return this;
        }
    }
}
