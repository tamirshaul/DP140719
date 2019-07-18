using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Exercise6
{
    public class Program
    {
        public static void Exercise6(string[] args)
        {
            List<NumberRepresentive> nr = new List<NumberRepresentive>
            {
                new NumberRepresentive(5,8),
                new NumberRepresentive(3,8),
                new NumberRepresentive(5,5),
                new NumberRepresentive(5,4),
                new NumberRepresentive(5,8),
            };

            PrintSequense(nr);
        }

        static void PrintSequense(List<NumberRepresentive> seq)
        {
            foreach (var c in seq)
            {
               Console.WriteLine(FlyWeightFactory.GetHeavyObjects(c));
            }
        }
    }
}
