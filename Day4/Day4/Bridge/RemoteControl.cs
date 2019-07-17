using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Bridge
{
    public class RemoteControl
    {
        public EntertainmentDevice Device { get; set; }

        public RemoteControl(EntertainmentDevice device)
        {
            Device = device;
        }

        public void TurnOn()
        {
            this.Device.TurnOn();
        }

        public void TurnOff()
        {
            this.Device.TurnOff();
        }

        public void Next()
        {
            this.Device.PressNext();
        }

        public void Prev()
        {
            this.Device.PressPrev();
        }
    }
}
