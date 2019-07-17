using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Facade
{
    public class FlightSystemFacade : IAdmin, ICustomer, ICompany
    {
        ICustomer customer = new Customer();
        ICompany company = new Company();
        IAdmin admin = new Admin();
        IFlightDAO ctx = new FlightDAO();

        public void BuyTicket()
        {
            customer.BuyTicket();
            ctx.InsertTicket();
        }

        public void CancelFlight()
        {
            company.CancelFlight();
            ctx.RemoveFlight();
        }

        public void CreateCustomer()
        {
            admin.CreateCustomer();
            ctx.InsertCustomer();
        }

        public void CreateFlight()
        {
            company.CreateFlight();
            ctx.InsertFlight();
        }

        public void DeleteCustomer()
        {
            admin.DeleteCustomer();
            ctx.RemoveCustomer();
        }

        public void ShowMyTicket()
        {
            customer.ShowMyTicket();
        }
    }
}
