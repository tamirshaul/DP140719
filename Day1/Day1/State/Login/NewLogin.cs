using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.State.Login
{
    
    public class NewLogin : LoginBase
    {
        public NewLogin(LoginContext ctx) : base(ctx)
        {
        }
        public override void Login(string password)
        {
            Console.WriteLine("Checking Password...");
            if(password == Program.PASSWORD)
            {
                Console.WriteLine("Login Succeed");
                ctx.State = new LoginSucceed(ctx);
            }
            else
            {
                Console.WriteLine("Login Failed");
                ctx.State = new LoginFailed(ctx);
            }
        }

        public override void Restart()
        {
            Console.WriteLine("Already new login...");
        }
    }
}
