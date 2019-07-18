using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5.Strategy
{
    public class QuickSort : ISort
    {
        public void Sort(List<int> list)
        {
            Console.WriteLine("quick sort");
        }
    }
}
