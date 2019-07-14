using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.State.Login
{
    class LoginSucceed : LoginBase
    {
        public LoginSucceed(LoginContext ctx) : base(ctx)
        {
        }
        public override void Login(string password)
        {
            Console.WriteLine("Already Logged in..");
        }

        public override void Restart()
        {
            Console.WriteLine("Restarting From Succeed..");
            ctx.State = new NewLogin(ctx);
        }
    }
}
