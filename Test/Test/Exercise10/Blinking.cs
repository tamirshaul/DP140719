using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Exercise10
{
    public class Blinking : DecoratorBase
    {
        public Blinking(IWindow window) : base(window)
        {
        }

        public override string GetDetails()
        {
            return this.window.GetDetails() + "Blinking ";
        }

    }
}
