using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Decorator
{
    public class Program
    {
        public static void Decorator(string[] args)
        {
            IPizza pizza = new BasePizza();

            IPizza tomato = new TomatoTopping(pizza);
            IPizza tomatoPineapple = new PineappleTopping(tomato);

            Console.WriteLine(tomato.GetDetails() + " " + tomato.GetPrice());
            Console.WriteLine(tomatoPineapple.GetDetails() + " " + tomatoPineapple.GetPrice());

            IPizza myfavorite = new TomatoTopping(new CheeseTopping(new PineappleTopping(pizza)));
            Console.WriteLine(myfavorite.GetDetails() + " " + myfavorite.GetPrice());

            IPizza myfavorite2 = new TomatoTopping(new CheeseTopping(new PineappleTopping(new HalfPriceTopping(new HalfPriceTopping(pizza)))));
            Console.WriteLine(myfavorite2.GetDetails() + " " + myfavorite2.GetPrice());

            IPizza myfavorite3 = new TomatoTopping(new CheeseTopping(new PineappleTopping(new OlivesTopping(pizza))));
            Console.WriteLine(myfavorite3.GetDetails() + " " + myfavorite3.GetPrice());
        }
    }
}
