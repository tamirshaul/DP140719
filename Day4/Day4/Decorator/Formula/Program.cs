using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Decorator.Formula
{
    public class Program
    {
        public static void Calculator(string[] args)
        {
            IFormula pizza = new FormulaBase(3);

            IFormula tomato = new Mul(pizza, 5);
            IFormula tomatoPineapple = new Sub(tomato,3);

            Console.WriteLine(tomato.GetFormula() + " " + tomato.GetResult());
            Console.WriteLine(tomatoPineapple.GetFormula() + " " + tomatoPineapple.GetResult());

            IFormula myfavorite = new Add(new Div(new Sub(pizza,3).ModifyNumber(123),3),2);
            Console.WriteLine(myfavorite.GetFormula() + " " + myfavorite.GetResult());

            IFormula myfavorite2 = new Div(new Sub(new Add(new Add(new Div(pizza,7),8),3),1),2);
            Console.WriteLine(myfavorite2.GetFormula() + " " + myfavorite2.GetResult());

            IFormula myfavorite3 = new Mul(new Div(new Add(new Add(pizza,1),3),2),3);
            Console.WriteLine(myfavorite3.GetFormula() + " " + myfavorite3.GetResult());
        }
    }
}
