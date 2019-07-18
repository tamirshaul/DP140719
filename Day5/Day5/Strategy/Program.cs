using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5.Strategy
{
    public class Program
    {
        public static void Strategy(string[] args)
        {
            NumberCollection nc = new NumberCollection();

            nc.Add(5);
            nc.Add(2);
            nc.Add(7);
            nc.Add(3);

            nc.Sort();
        }
    }
}
