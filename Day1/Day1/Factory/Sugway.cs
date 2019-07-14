using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Factory
{
    public class Sugway : Vehicle
    {
        protected string sugwayParam;

        public Sugway(string model, float cylinder, string color, int numberOfWheels, string sugwayParam) : base(model, cylinder, color, numberOfWheels)
        {
            this.sugwayParam = sugwayParam;
        }

        public override string ToString()
        {
            return $"Sugway " + base.ToString() + $" {sugwayParam}";
        }
    }
}
