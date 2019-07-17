using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Facade
{
    public interface IFlightDAO
    {
        void InsertTicket();
        void GetTickets();
        void InsertFlight();
        void RemoveFlight();
        void RemoveCustomer();
        void RemoveTicket();
        void InsertCustomer();
        void InsertCompany();
    }
}
