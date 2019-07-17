using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Decorator
{
    public class BasePizza : IPizza
    {
        public string GetDetails()
        {
            return "Plain daugh and spices ";
        }

        public double GetPrice()
        {
            return 25;
        }
    }
}
