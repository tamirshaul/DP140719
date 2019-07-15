using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.State.Login
{
    public class Program
    {
        public const string PASSWORD = "12345";
        public static void LoginExercise(string[] args)
        {
            LoginContext ctx = new LoginContext();
            NewLogin login = new NewLogin(ctx);
            ctx.Init(login);

            ctx.pressedLogin("123");
            // failed
            ctx.pressedLogin("1234");
            // failed
            ctx.pressedLogin("12345");
            // now succeed
            ctx.pressedLogin("4444");
            // do nothing
            ctx.pressedRestart();
            // Restart to new login now we should have 3 tries again.
            ctx.pressedLogin("123");
            // failed
            ctx.pressedLogin("1234");
            // failed
            ctx.pressedLogin("123");
            // failed
            ctx.pressedLogin("1234");
            // Locked
            ctx.pressedRestart();
            // Restart
            ctx.pressedLogin("123");
            // Failed
            ctx.pressedRestart();
            // Restart

        }
    }
}
