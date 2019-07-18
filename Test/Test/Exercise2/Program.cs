using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Exercise2
{
    class Program
    {
        public static void Exercise2(string[] args)
        {
            Component root = new Composite(4,"Canvas root");
            Component circle1 = new Leaf(3,"Circle 1");
            Component rectangle1 = new Leaf(6,"Rectangle 1");
            root.AddChild(circle1);
            root.AddChild(rectangle1);

            Component container1 = new Composite(2,"Container 1");
            Component circle2 = new Leaf(2,"Circle 2");
            Component circle3 = new Leaf(4,"Circle 3");

            root.AddChild(container1);
            container1.AddChild(circle2);
            container1.AddChild(circle3);

            Component container2 = new Composite(4,"Container 2");
            Component circle4 = new Leaf(2,"Circle 2");
            Component circle5 = new Leaf(4,"Circle 3");
            Component circle6 = new Leaf(8,"Circle 3");

            root.AddChild(container2);
            container2.AddChild(circle4);
            container2.AddChild(circle5);
            container2.AddChild(circle6);

            root.Draw("|");
            root.IsEven();

            var c = root.Sum();
            Console.WriteLine(c);
        }
    }
}
