using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.ChainOfResponsibility
{
    class BillHandler25 : BillHandlerBase
    {
        private int currAmount = 25;
        public override void Handle(int amount)
        {
            if (amount == 0)
            {
                return;
            }
            if (amount >= currAmount)
            {
                Console.WriteLine($"Giving { currAmount } x {amount / currAmount} bills");
            }

            if (amount % currAmount > 0)
            {
                if (next != null)
                {
                    next.Handle(amount % currAmount);
                }
            }
        }
    }
}
