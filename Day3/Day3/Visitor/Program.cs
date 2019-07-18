using System;
using Visitor;
using Design_Patterns_Console.Day3.Adapter.DBData;

namespace Day3.Visitor
{
    public class Program
    {
        public static void VisitorQuestion(string[] args)
        {
            Liquor vodka = new Liquor(95);

            Console.WriteLine(vodka);

            IVisitor endOfYearVisitor = new EndOfYearTax();

            Console.WriteLine($"Price after tax = {vodka.Accept(endOfYearVisitor)}");

            ShopRent shop = new ShopRent();

            Console.WriteLine(shop);

            IVisitor oneShekelStore = new OneShekelStore();

            Console.WriteLine($"Price at oneshekelstore = {shop.Accept(oneShekelStore)}");

            Console.WriteLine($"Price after tax = {shop.Accept(endOfYearVisitor)}");
        }
    }
}