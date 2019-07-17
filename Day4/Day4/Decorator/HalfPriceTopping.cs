using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Decorator
{
    public class HalfPriceTopping : ToppingDecoratorBase
    {
        public HalfPriceTopping(IPizza pizza) : base(pizza)
        {

        }
        public override string GetDetails()
        {
            return this.pizza.GetDetails() + "Half Price! ";
        }

        public override double GetPrice()
        {
            return this.pizza.GetPrice() / 2;
        }
    }
}
