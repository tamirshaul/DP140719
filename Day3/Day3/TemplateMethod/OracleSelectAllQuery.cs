using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.TemplateMethod
{
    public class OracleSelectAllQuery : OracleTemplateBase
    {
        protected override void RunQuery()
        {
            Console.WriteLine("Running oracle select all query...");
        }

    }
}
