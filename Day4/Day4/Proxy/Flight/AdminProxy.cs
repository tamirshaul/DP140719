using Day4.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Proxy.Flight
{
    public class AdminProxy : IAdminProxy
    {
        FlightSystemFacade facade = new FlightSystemFacade();
        public void CreateCustomer()
        {
            facade.CreateCustomer();
        }

        public void DeleteCustomer()
        {
            facade.DeleteCustomer();
        }

    }
}
