using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Decorator
{
    public class OlivesTopping : ToppingDecoratorBase
    {
        public OlivesTopping(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDetails()
        {
            return this.pizza.GetDetails() + "olives ";
        }

        public override double GetPrice()
        {
            return this.pizza.GetPrice() + 3;
        }
    }
}
