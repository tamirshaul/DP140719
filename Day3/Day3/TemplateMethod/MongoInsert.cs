using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.TemplateMethod
{
    public class MongoInsert : MongoBase
    {
        protected override void RunQuery()
        {
            Console.WriteLine("Running mongo insert query...");
        }
    }
}
