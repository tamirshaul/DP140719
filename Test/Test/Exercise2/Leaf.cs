using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Exercise2
{
    class Leaf : Component
    {
        public Leaf(int number, string name) : base(number,name)
        {
        }

        public override void AddChild(Component c)
        {
            throw new NotSupportedException("Leaf element cannot add childs!");
        }

        public override void Draw(string space)
        {
            Console.WriteLine(space + this.name + " : " + this.number);
        }

        public override IList<Component> GetChilds()
        {
            return null;
        }

        public override bool IsEven()
        {
            return this.number % 2 == 0;
        }

        public override void RemoveChild(Component c)
        {
            throw new NotSupportedException("Leaf element cannot delete childs!");
        }

        public override int Sum()
        {
            return this.number;
        }
    }
}
