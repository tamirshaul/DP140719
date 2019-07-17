using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Proxy
{
    public class ATM : IATM
    {
        protected double balance;
        protected string status;

        public ATM(double balance, string status)
        {
            this.balance = balance;
            this.status = status;
        }

        public void Deposit(int dep)
        {
            Console.WriteLine("deposit");
        }

        public void EjectCard()
        {
            Console.WriteLine("eject");
        }

        public string GetStatus()
        {
            return this.status;
        }

        public double GetTotalCash()
        {
            return this.balance;
        }

        public void InsertCard()
        {
            Console.WriteLine("insert");
            throw new NotImplementedException();
        }

        public bool Withdraw(int draw)
        {
            throw new NotImplementedException();
        }
    }
}
