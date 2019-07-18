using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Exercise8
{
    public abstract class TemplateExerciseRunner
    {
        protected void ChangeCloth()
        {
            Console.WriteLine("changing clothes");
        }
        protected void DrinkWater()
        {
            Console.WriteLine("Drinking water");
        }
        protected abstract void DoExercise();
        protected void Shower()
        {
            Console.WriteLine("Showering");
        }
        public void Run()
        {
            ChangeCloth();
            DrinkWater();
            DoExercise();
            Shower();
        }
    }
}
