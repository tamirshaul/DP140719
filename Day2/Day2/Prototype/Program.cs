using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.Prototype
{
    public class Program
    {
        public static void Prototype(string[] args)
        {

            Shape c1 = new Circle(new Point(4, 8), 50.5);
            Shape r = new Rectangle(new Point(1, 3), (float)45.5, (float)14.3);
            Shape c2 = new Circle(new Point(5, 5), 17);
            List<Shape> shapes = new List<Shape> { c1, c2, r };
            ShapeHolder shapeHolder = new ShapeHolder(shapes);

            Console.WriteLine();
            Console.WriteLine(c1);
            DoStuffWithCircle((Circle)c1.Clone());
            Console.WriteLine(c1);
            Console.WriteLine();

            Console.WriteLine(shapeHolder);
            Shape c5 = shapeHolder.Clone().Shapes[0];
            DoStuffWithCircle((Circle)c5);
            Console.WriteLine(shapeHolder);



        }

        public static void DoStuffWithCircle(Circle c)
        {
            c.Center.X = 155;
            c.Area = -5;
        }
    }
}
