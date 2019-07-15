using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.ChainOfResponsibility
{
    class Program
    {
        public static void BillHandler(string[] args)
        {
            BillHandlerBase billHandler500 = new BillHandler500();
            BillHandlerBase billHandler200 = new BillHandler200();
            BillHandlerBase billHandler100 = new BillHandler100();
            BillHandlerBase billHandler25 = new BillHandler25();
            BillHandlerBase billHandler5 = new BillHandler5();
            BillHandlerBase billHandler2 = new BillHandler2();

            BillHandlerBase chainRoot = billHandler500;

            billHandler500.SetNext(billHandler200);
            billHandler200.SetNext(billHandler100);
            billHandler100.SetNext(billHandler25);
            billHandler25.SetNext(billHandler5);
            billHandler5.SetNext(billHandler2);

            chainRoot.Handle(788);
        }
    }
}
