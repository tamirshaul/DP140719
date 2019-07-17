﻿using Day4.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Proxy.Flight
{
    public interface IAdminProxy : IClientProxy, IAdmin
    {
    }
}
