using Day4.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Proxy.Flight
{
    public class CompanyProxy : ICompanyProxy
    {
        FlightSystemFacade facade = new FlightSystemFacade();
        public void CancelFlight()
        {
            facade.CancelFlight();
        }

        public void CreateFlight()
        {
            facade.CreateFlight();
        }
    }
}
