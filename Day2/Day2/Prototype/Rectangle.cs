using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.Prototype
{
    public class Rectangle : Shape
    {
        private double v1;
        private int v2;

        public Point Point { get; set;}
        public float Length { get; set; }
        public float Width { get; set; }

        public Rectangle(Point point, float length, float width)
        {
            Point = point;
            Length = length;
            Width = width;
        }
        public override string ToString()
        {
            return $"Rectangle Starts on { Point} Length: {Length} Width: {Width}";
        }

        public override Shape Clone()
        {
            return new Rectangle(this.Point, this.Length, this.Width);
        }
    }
}
