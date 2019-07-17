using Day4.Proxy.Flight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Facade
{
    public class Program
    {
        public static void Flight(string[] args)
        {
            ProxyFactory c1 = new ProxyFactory();

            IClientProxy u1 = c1.Login("admin", "admin");

            AdminProxy uu1 = (AdminProxy)u1;
            uu1.CreateCustomer();

            IClientProxy u2 = c1.Login("elal", "4321");

            CompanyProxy uu2 = (CompanyProxy)u2;
            uu2.CancelFlight();

            IClientProxy u3 = c1.Login("aaa", "4321");

            CustomerProxy uu3 = (CustomerProxy)u3;
            uu3.BuyTicket();


        }
    }
}
