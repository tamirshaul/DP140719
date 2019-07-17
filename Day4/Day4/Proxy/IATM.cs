using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Proxy
{
    public interface IATM : IMonitorService
    {
        void Deposit(int dep);
        bool Withdraw(int draw);
        void InsertCard();
        void EjectCard();

    }
}
