using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.Composite
{
    class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {
        }

        public override void AddChild(Component c)
        {
            throw new NotSupportedException("Leaf element cannot add childs!");
        }

        public override int Count()
        {
            return 1;
        }

        public override void Draw(string space)
        {
            Console.WriteLine(space + this.name);
        }

        public override IList<Component> GetChilds()
        {
            return null;
        }

        public override void RemoveChild(Component c)
        {
            throw new NotSupportedException("Leaf element cannot delete childs!");
        }
    }
}
