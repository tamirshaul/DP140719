﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.TemplateMethod
{
    public abstract class TemplateQueryRunner
    {
        protected abstract void CreateDbConnection();
        protected abstract void OpenDbConnection();
        protected abstract void RunQuery();
        protected abstract void CloseDbConnection();
        public void Run()
        {
            CreateDbConnection();
            OpenDbConnection();
            RunQuery();
            CloseDbConnection();
        }
    }
}
