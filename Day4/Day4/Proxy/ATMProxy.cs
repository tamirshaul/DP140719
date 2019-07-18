using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Proxy
{
    public class ATMProxy : IMonitorService
    {
        protected ATM atm;

        public ATMProxy(ATM atm)
        {
            this.atm = atm;
        }

        public string GetStatus()
        {
            return this.atm.GetStatus();
        }

        public double GetTotalCash()
        {
            return this.atm.GetTotalCash();
        }
    }
}
