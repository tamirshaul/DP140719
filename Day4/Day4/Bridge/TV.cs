using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Bridge
{
    public class TV : EntertainmentDevice
    {
        public TV(int state, int max) : base(state, max)
        {
        }

        public override void PrintStatus()
        {
            Console.WriteLine($"I Am TV and On is : {this.isOn} State is : {this.State}");
        }

        public override void PressNext()
        {
            Console.WriteLine("I Am TV");
            base.PressNext();
        }

        public override void PressPrev()
        {
            Console.WriteLine("I Am TV");
            base.PressPrev();
        }
    }
}
