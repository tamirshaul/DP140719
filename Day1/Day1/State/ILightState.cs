using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.State
{
    public interface ILightState
    {
        ILightState TurnOn();

        ILightState TurnOff();
    }
}
