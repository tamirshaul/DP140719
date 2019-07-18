using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Exercise2
{
    class Composite : Component
    {
        IList<Component> childs = new List<Component>();
        public Composite(int number, string name) : base(number, name)
        {
        }
        public override void AddChild(Component c)
        {
            childs.Add(c);
        }

        public override void Draw(string space)
        {
            Console.WriteLine(space + this.name + " : " + this.number);
            foreach (var c in childs)
            {
                c.Draw("    " + space);
            }
        }

        public override IList<Component> GetChilds()
        {
            return childs;
        }


        public override bool IsEven()
        {
            bool isEven = true;
            foreach (var c in childs)
            {
               isEven = isEven && c.IsEven();
            }

            if (this.number % 2 != 0)
            {
                isEven = false;
            }

            if (!isEven)
            {
                Console.WriteLine($"Composite { name } is NOT Even");
            }
            else
            {
                Console.WriteLine($"Composite { name } is Even");
            }

            return isEven;
        }

        public override void RemoveChild(Component c)
        {
            childs.Remove(c);
        }

        public override int Sum()
        {
            var sum = number;
            foreach (var c in childs)
            {
                if(c.GetChilds() == null)
                {
                    sum += c.number;
                }
                else
                {
                    sum += c.number;
                    foreach (var cc in c.GetChilds())
                    {
                        sum += cc.number;
                    }
                }
            }
            return sum;
        }
    }
}
