using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Bonus1
{
    class Program
    {
        public static void Bonus1(string[] args)
        {
            int[] arr = { 1, 1,10,10,9,9,5,6,6 };

            Console.WriteLine(Recurse(arr));

        }

        public static int CheckArray(int[] arr, int index)
        {
            if(arr[index] != arr[index + 1])
            {
                return arr[index];
            }
            else
            {
                return CheckArray(arr, index + 2);
            }
        }

        public static int Recurse(int[] arr)
        {
            return CheckArray(arr, 0);
        }
    }
}
