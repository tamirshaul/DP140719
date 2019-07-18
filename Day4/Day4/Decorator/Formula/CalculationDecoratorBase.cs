using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Decorator.Formula
{
    public abstract class CalculationDecoratorBase : IFormula
    {
        protected IFormula formula;
        protected double number;

        protected CalculationDecoratorBase(IFormula formula, double number)
        {
            this.formula = formula;
            this.number = number;
        }

        public abstract string GetFormula();
        public abstract double GetResult();

        public CalculationDecoratorBase ModifyNumber(double number)
        {
            this.number = number;
            return this;
        }

        
    }
}
