using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Exercise10
{
    public class BaseWindow : IWindow
    {
        public string GetDetails()
        {
            return "Plain & Empty Window ";
        }
    }
}
