using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Facade
{
    public class Customer : ICustomer
    {
        public void BuyTicket()
        {
            Console.WriteLine("ticket bought");
        }

        public void ShowMyTicket()
        {
            Console.WriteLine("ticket show");
        }
    }
}
