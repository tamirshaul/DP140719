using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Exercise10
{
    public class Shikuf : DecoratorBase
    {
        public Shikuf(IWindow window) : base(window)
        {
        }

        public override string GetDetails()
        {
            return this.window.GetDetails() + "Shikuf ";
        }
    }
}
