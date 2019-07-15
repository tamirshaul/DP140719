using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.Prototype
{
    public class Point : IPrototype<Point>
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Point(float x, float y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"Point X: {X} Y: {Y}";
        }

        public Point Clone()
        {
            return new Point(this.X, this.Y);
        }
    }
}
