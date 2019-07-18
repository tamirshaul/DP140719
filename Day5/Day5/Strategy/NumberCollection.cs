using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5.Strategy
{
    public class NumberCollection
    {
        public List<int> numbers;
        ISort sorter;

        public NumberCollection()
        {
            this.numbers = new List<int>();
            this.sorter = new MergeSort();
        }

        public void Add(int number)
        {
            this.numbers.Add(number);
            if (this.numbers.Count >= 1000)
            {
                this.sorter = new QuickSort();
            }
        }

        public void Remove(int number)
        {
            this.numbers.Remove(number);
            if (this.numbers.Count < 1000)
            {
                this.sorter = new MergeSort();
            }
        }

        public void Sort()
        {
            this.sorter.Sort(this.numbers);
        }
    }
}
