using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Facade
{
    class FlightDAO : IFlightDAO
    {
        public void GetTickets()
        {
            Console.WriteLine("tickets");
        }

        public void InsertCompany()
        {
            Console.WriteLine("inserting company");
        }

        public void InsertCustomer()
        {
            Console.WriteLine("inserting customer");
        }

        public void InsertFlight()
        {
            Console.WriteLine("inserting flight");
        }

        public void InsertTicket()
        {
            Console.WriteLine("inserting ticket");
        }

        public void RemoveCustomer()
        {
            Console.WriteLine("remove customer");
        }

        public void RemoveFlight()
        {
            Console.WriteLine("remove flight");
        }

        public void RemoveTicket()
        {
            Console.WriteLine("remove ticket");
        }
    }
}
