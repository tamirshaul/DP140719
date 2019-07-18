using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Decorator.Formula
{
    public class FormulaBase : IFormula
    {
        protected double number;

        public FormulaBase(double number)
        {
            this.number = number;
        }

        public string GetFormula()
        {
            return "formula is ";
        }

        public double GetResult()
        {
            return this.number;
        }
    }
}
