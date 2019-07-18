using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Proxy.Flight
{
    public class ProxyFactory
    {
        public IClientProxy Login(string username, string password)
        {
            if (username == "elal" && password == "4321")
            {
                return new CompanyProxy();
            }
            else if (username == "admin" && password == "admin")
            {
                return new AdminProxy();
            }
            else if (password == "4321")
            {
                return new CustomerProxy();
            }
            else
                return null;
        
        }
    }
}
