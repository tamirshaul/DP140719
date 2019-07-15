using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.ChainOfResponsibility.LogLevel
{
    public abstract class LogHandlerBase
    {
        protected LogHandlerBase next;
        public abstract void Handle(string msg, int level);

        public void SetNext(LogHandlerBase next)
        {
            this.next = next;
        }
    }
}
