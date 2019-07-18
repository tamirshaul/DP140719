using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Exercise3;

namespace Test.Exercise3
{
    class Program
    {
        public static void Exercise3(string[] args)
        {
            ICarProxy proxy = new CarProxy();

            proxy.ShowGas();
            proxy.ShowLocation();
        }
    }
}
