using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Decorator.Formula
{
    public class Mul : CalculationDecoratorBase
    {
        public Mul(IFormula formula, double number) : base(formula, number)
        {
        }

        public override string GetFormula()
        {
            return this.formula.GetFormula() + "Multipication ";
        }

        public override double GetResult()
        {
            return this.formula.GetResult() * this.number;
        }

    }
}
