using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.State
{
    class Program
    {
        public static void State(string[] args)
        {
            LightContext context = new LightContext(new IAmOn());

            context.PressedOff();
            context.PressedOn();
            context.PressedOn();
            context.PressedOff();
            context.PressedOn();

            context.Fix();
            context.PressedOff();
            context.PressedOn();
        }
    }
}
