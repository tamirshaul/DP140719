using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.State.Login
{
    public abstract class LoginBase : ILoginBase
    {
        protected LoginContext ctx;

        protected LoginBase(LoginContext ctx)
        {
            this.ctx = ctx;
        }

        public abstract void Login(string password);

        public abstract void Restart();
    }
}
