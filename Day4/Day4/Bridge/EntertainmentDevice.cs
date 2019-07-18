using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Bridge
{
    public abstract class EntertainmentDevice
    {
        public int State { get; set; } 
        public int Max { get; set; }
        protected bool isOn = false;

        protected EntertainmentDevice(int state, int max)
        {
            State = state;
            Max = max;
        }

        public abstract void PrintStatus();

        public virtual void PressNext()
        {
            this.State = ++this.State % this.Max;
        }
        public virtual void PressPrev()
        {
            if (this.State == 1)
            {
                this.State = this.Max;
            }
            else
            {
                --this.State;
            }
        }
        public void TurnOn()
        {
            this.isOn = true;
        }

        public void TurnOff()
        {
            this.isOn = false;
        }


    }
}
