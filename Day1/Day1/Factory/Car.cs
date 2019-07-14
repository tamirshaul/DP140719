using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Factory
{
    public class Car : Vehicle
    {
        protected string DrivingWheelHeater;

        public Car(string model, float cylinder, string color, int numberOfWheels, string DrivingWheelHeater) : base(model, cylinder, color, numberOfWheels)
        {
            this.DrivingWheelHeater = DrivingWheelHeater;
        }

        public override string ToString()
        {
            return $"Car " + base.ToString() + $" {DrivingWheelHeater}";
        }
    }
}
