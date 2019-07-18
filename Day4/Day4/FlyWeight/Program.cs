using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.FlyWeight
{
    public class Program
    {
        public static void FlyWeight(string[] args)
        {
            PrintSequense("ANNNAAAAAOOOONNNAAAAAAAAA");
        }

        static void PrintSequense(string seq)
        {
            foreach (char c in seq)
            {

                for (int i = 0; i < VeryHeavyObject.MAX_SIZE; i++)
                {
                    Console.WriteLine(FlyWeightFactory.GetHeavyObjects(c)[i]);
                }
            }
        }
    }
}
