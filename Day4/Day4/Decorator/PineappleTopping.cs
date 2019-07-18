using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Decorator
{
    public class PineappleTopping : ToppingDecoratorBase
    {
        public PineappleTopping(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDetails()
        {
            return this.pizza.GetDetails() + "pineapple ";
        }

        public override double GetPrice()
        {
            return this.pizza.GetPrice() + 3;
        }
    }
}
