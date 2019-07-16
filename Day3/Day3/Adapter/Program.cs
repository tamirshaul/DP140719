using System;
using Design_Patterns_Console.Day3.Adapter.DBData;

namespace Day3.Adapter
{
    public class Program
    {
        public static void AdapterQuestion(string[] args)
        {
            WebClientData webcd = new WebClientData("name", 1, "1.0.1.0", true);

            draw(new BadStoreToPerfectStoreAdapter(), webcd);

            Console.WriteLine("\n====================");
            Console.WriteLine("Print before the adapter");
            Console.WriteLine("\n====================\n");

            draw(new BadStore(), webcd);
        }

        // non mutable
        private static void draw(IDBWebData dbwebdata, WebClientData webcd)
        {
            dbwebdata.Store(webcd);
        }
    }
}