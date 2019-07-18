using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Exercise10
{
    public abstract class DecoratorBase : IWindow
    {
        protected IWindow window;
        public DecoratorBase(IWindow window)
        {
            this.window = window;
        }
        
        public abstract string GetDetails();
    }
}
