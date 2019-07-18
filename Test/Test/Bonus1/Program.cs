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
            int[] arr = { 1, 1,2,2,10,107,9,9,5,6,6 };

            Console.WriteLine(Recurse(arr));

        }

        public static int Recurse(int[] arr)
        {
            return CheckArr(arr, 0, arr.Length - 1);
        }

        public static int CheckArr(int[] arr, int i, int j)
        {
            if (j - i == 1)
            {
                return i % 2 == 0 ? arr[i] : arr[j];
            }

            int half = (i+j) / 2;
            if(arr[half] == arr[half + 1])
            {
                if(half % 2 == 0)
                {
                    return CheckArr(arr, half, j);
                }
                else
                {
                    return CheckArr(arr, i, half);
                }
            }
            else
            {
                if (half % 2 == 0)
                {
                    return CheckArr(arr, i, half);
                }
                else
                {
                    return CheckArr(arr, half, j);
                }
            }
        }
    }
}
