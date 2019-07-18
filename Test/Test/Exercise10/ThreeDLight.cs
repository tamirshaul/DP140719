using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Exercise10
{
    public class ThreeDLight : DecoratorBase
    {
        public ThreeDLight(IWindow window) : base(window)
        {
        }

        public override string GetDetails()
        {
            return this.window.GetDetails() + "3D Light ";
        }
    }
}
