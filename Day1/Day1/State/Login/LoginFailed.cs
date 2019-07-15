using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.State.Login
{
    class LoginFailed : LoginBase
    {
        private int counter;
        public LoginFailed(LoginContext ctx) : base(ctx)
        {
            counter = 1;
        }
        public override void Login(string password)
        {
            Console.WriteLine("Checking Password...");
            if (password == Program.PASSWORD)
            {
                Console.WriteLine("Login Succeed");
                ctx.State = new LoginSucceed(ctx);
            }
            else
            {
                Console.WriteLine("Login Failed");
                counter++;
                if (counter >= 3)
                {
                    ctx.State = new Locked(ctx);
                }
            }
        }

        public override void Restart()
        {
            Console.WriteLine("Restarting From Failed..");
            ctx.State = new NewLogin(ctx);
        }
    }
}
