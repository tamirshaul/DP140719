using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Exercise1
{
    public class ShipAtRisk : IState
    {
        public void State()
        {
            Console.WriteLine("Ship at risk!");
        }
    }
}
