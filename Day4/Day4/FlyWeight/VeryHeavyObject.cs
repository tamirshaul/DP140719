using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.FlyWeight
{
    public class VeryHeavyObject
    {
        static Random r = new Random();
        public const int MAX_SIZE = 1_000_000;
        int[] items;

        public VeryHeavyObject()
        {
            this.items = new int[MAX_SIZE];

            for (int i = 0; i < MAX_SIZE; i++)
            {
                items[i] = r.Next(1000);
            }
        }

        public T this [int index]
        {
            get
            {
                return items[index];
            }
        }
    }
}
