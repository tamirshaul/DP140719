using Day4.Proxy.Flight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Facade
{
    public interface IAdmin
    {
        void CreateCustomer();
        void DeleteCustomer();
    }
}
