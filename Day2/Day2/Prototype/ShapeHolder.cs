using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.Prototype
{
    public class ShapeHolder : IPrototype<ShapeHolder>
    {
        public List<Shape> Shapes { get; set; }

        public ShapeHolder(List<Shape> shapes)
        {
            Shapes = shapes;
        }

        public ShapeHolder Clone()
        {
            List<Shape> newShapes = new List<Shape>();
            foreach (var shape in Shapes)
            {
                newShapes.Add(shape.Clone());
            }

            ShapeHolder newShapeHolder = new ShapeHolder(newShapes);

            return newShapeHolder;
        }

        public override string ToString()
        {
            string str = "";
            foreach (var shape in Shapes)
            {
                str += shape.ToString() + "        ";
            }
            return str;
        }
    }
}
