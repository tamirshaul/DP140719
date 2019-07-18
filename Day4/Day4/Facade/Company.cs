using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Facade
{
    public class Company : ICompany
    {
        public void CancelFlight()
        {
            Console.WriteLine("flight cancelled");

        }

        public void CreateFlight()
        {
            Console.WriteLine("flight created");
        }
    }
}
