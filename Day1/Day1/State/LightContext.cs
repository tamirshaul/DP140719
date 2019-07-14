using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.State
{
    class LightContext
    {
        ILightState state;

        public LightContext(ILightState state)
        {
            this.state = state;
        }

        public void PressedOn()
        {
            this.state = state.TurnOn();
        }

        public void PressedOff()
        {
            this.state = state.TurnOff();
        }

        public void Fix()
        {
            this.state = state.Fix();
        }
    }
}
