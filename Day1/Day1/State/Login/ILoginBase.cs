using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.State.Login
{
    public interface ILoginBase
    {
        void Login(string password);
        void Restart();
    }
}
