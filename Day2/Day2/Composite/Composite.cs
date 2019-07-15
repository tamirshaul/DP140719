using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.Composite
{
    class Composite : Component
    {
        IList<Component> childs = new List<Component>();
        public Composite(string name) : base(name)
        {
        }
        public override void AddChild(Component c)
        {
            childs.Add(c);
        }

        public override int Count()
        {
            int counter = 0;
            foreach (var c in childs)
            {
                counter += c.Count();
            }

            Console.WriteLine($"Count for { name } composite is: { counter }");
            return counter;
        }

        public override void Draw(string space)
        {
            Console.WriteLine(space + this.name);
            foreach (var c in childs)
            {
                c.Draw("    " + space);
            }
        }

        public override IList<Component> GetChilds()
        {
            return childs;
        }

        public override void RemoveChild(Component c)
        {
            childs.Remove(c);
        }
    }
}
