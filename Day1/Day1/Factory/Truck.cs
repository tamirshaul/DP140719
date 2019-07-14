using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Factory
{
    public class Truck : Vehicle
    {
        protected string truckParam;

        public Truck(string model, float cylinder, string color, int numberOfWheels, string truckParam) : base(model, cylinder, color, numberOfWheels)
        {
            this.truckParam = truckParam;
        }

        public override string ToString()
        {
            return $"Truck " + base.ToString() + $" {truckParam}";
        }
    }
}
