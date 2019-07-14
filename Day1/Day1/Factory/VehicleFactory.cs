using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Factory
{
    public class VehicleFactory
    {
        public Vehicle CreateVehicle(string model, float cylinder, string color, int numberOfWheels, string data)
        {
            if (numberOfWheels == 2)
            {
                return new Motorcycle(model, cylinder, color, numberOfWheels, data);
            }
            else if (numberOfWheels == 4)
            {
                return new Car(model, cylinder, color, numberOfWheels, data);
            }
            else if (numberOfWheels == 8)
            {
                return new Truck(model, cylinder, color, numberOfWheels, data);
            }
            else if (numberOfWheels == 1)
            {
                return new Sugway(model, cylinder, color, numberOfWheels, data);
            }
            throw new ArgumentException($"Cannot create vehicle with {numberOfWheels} number of wheels");
        }
    }
}
