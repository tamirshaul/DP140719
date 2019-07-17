using Day4.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Proxy.Flight
{
    public class CustomerProxy : ICustomerProxy
    {
        FlightSystemFacade facade = new FlightSystemFacade();
        public void BuyTicket()
        {
            facade.BuyTicket();
        }

        public void ShowMyTicket()
        {
            facade.ShowMyTicket();
        }
    }
}
