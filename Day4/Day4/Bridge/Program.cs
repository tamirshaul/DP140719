using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Bridge
{
    public class Program
    {
        public static void Bridge(string[] args)
        {
            EntertainmentDevice tv = new TV(14,15);
            EntertainmentDevice memir = new Memir(5,30);
            RemoteControl remote = new RemoteControl(tv);

            remote.TurnOn();
            remote.Next();
            remote.Next();
            remote.Next();
            remote.Device.PrintStatus();

            remote.Device = memir;

            remote.TurnOn();
            remote.Next();
            remote.Device.PrintStatus();
        }
    }
}
