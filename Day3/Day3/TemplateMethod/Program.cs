using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.TemplateMethod
{
    public class Program
    {
        public static void TemplateMethod(string[] args)
        {
            OracleSelectAllQuery q1 = new OracleSelectAllQuery();
            q1.Run();
            Console.WriteLine();

            OracleUpdateQuery q2 = new OracleUpdateQuery();
            q2.Run();
            Console.WriteLine();

            MongoInsert q3 = new MongoInsert();
            q3.Run();
            Console.WriteLine();
        }
    }
}
