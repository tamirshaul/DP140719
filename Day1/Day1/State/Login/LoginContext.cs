using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.State.Login
{
    public class LoginContext
    {
        public ILoginBase State { get; set; }

        public LoginContext()
        {
        }

        public void Init(ILoginBase state)
        {
            this.State = state;
        }

        public void pressedLogin(string password)
        {
            if (State == null)
                throw new ApplicationException("state not initailized!");

            State.Login(password);
        }

        public void pressedRestart()
        {
            if (State == null)
                throw new ApplicationException("state not initailized!");

            State.Restart();
        }
    }
}
