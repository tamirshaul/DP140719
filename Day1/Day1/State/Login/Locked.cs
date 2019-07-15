using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.State.Login
{
    class Locked : LoginBase
    {
        public Locked(LoginContext ctx) : base(ctx)
        {
        }
        public override void Login(string password)
        {
            Console.WriteLine("You are locked!");
        }

        public override void Restart()
        {
            Console.WriteLine("Restarting From Locked...");
            ctx.State = new NewLogin(ctx);
        }
    }
}
