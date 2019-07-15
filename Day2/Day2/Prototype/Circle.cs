using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.Prototype
{
    public class Circle : Shape
    {
        public Point Center { get; set; }

        public double Area{ get; set; }

        public Circle(Point center, double area)
        {
            this.Center = center;
            Area = area;
        }

        public override string ToString()
        {
            return $"Circle center {Center} Area: {Area}";
        }

        public override Shape Clone()
        {
            return new Circle(this.Center.Clone(), this.Area);
        }
    }
}
