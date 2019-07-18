using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Exercise3
{
    class CarProxy : ICarProxy
    {
        public void ShowGas()
        {
            ICar car = new Car();
            car.ShowGas();
        }

        public void ShowLocation()
        {
            ICar car = new Car();
            car.ShowLocation();
        }
    }
}
