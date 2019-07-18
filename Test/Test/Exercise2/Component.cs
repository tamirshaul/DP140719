using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Exercise2
{
    public abstract class Component
    {
        public int number { get; private set; }
        public string name { get; private set; }
        protected Component(int number, string name)
        {
            this.number = number;
            this.name = name;
        }

        public abstract void AddChild(Component c);

        public abstract void RemoveChild(Component c);

        public abstract IList<Component> GetChilds();

        public abstract void Draw(string space);
        public abstract int Sum();

        public abstract bool IsEven();
    }
}
