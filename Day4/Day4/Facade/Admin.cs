using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Facade
{
    public class Admin : IAdmin
    {
        public void CreateCustomer()
        {
            Console.WriteLine("customer created");
        }

        public void DeleteCustomer()
        {
            Console.WriteLine("customer deleted");
        }
    }
}
