using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Exercise10
{
    public class Program
    {
        public static void Exercise10(string[] args)
        {
            IWindow window = new BaseWindow();

            IWindow tomato = new Shikuf(window);
            IWindow tomatoPineapple = new Colorized(tomato);

            Console.WriteLine(tomato.GetDetails());
            Console.WriteLine(tomatoPineapple.GetDetails());

            IWindow myfavorite = new Shikuf(new Hazlala(new Colorized(window)));
            Console.WriteLine(myfavorite.GetDetails());

            IWindow myfavorite2 = new Shikuf(new ThreeDLight(new Colorized(new Hazlala(new Blinking(window)))));
            Console.WriteLine(myfavorite2.GetDetails());

            IWindow myfavorite3 = new Shikuf(new Hazlala(new Colorized(new ThreeDLight(window))));
            Console.WriteLine(myfavorite3.GetDetails());
        }
    }
}
