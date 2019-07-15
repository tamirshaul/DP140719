using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.Composite
{
    class Program
    {
        public static void Composite(string[] args)
        {
            Component root = new Composite("Canvas root");
            Component circle1 = new Leaf("Circle 1");
            Component rectangle1 = new Leaf("Rectangle 1");
            root.AddChild(circle1);
            root.AddChild(rectangle1);

            Component container1 = new Composite("Container 1");
            Component circle2 = new Leaf("Circle 2");
            Component circle3 = new Leaf("Circle 3");

            root.AddChild(container1);
            container1.AddChild(circle2);
            container1.AddChild(circle3);

            Component container2 = new Composite("Container 2");
            Component circle4 = new Leaf("Circle 2");
            Component circle5 = new Leaf("Circle 3");
            Component circle6 = new Leaf("Circle 3");

            root.AddChild(container2);
            container2.AddChild(circle4);
            container2.AddChild(circle5);
            container2.AddChild(circle6);

            root.Draw("|");
            root.Count();

            root.IsBinary();
        }
    }
}
