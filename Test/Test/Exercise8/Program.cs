using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Exercise8
{
    public class Program
    {
        public static void Exercise8(string[] args)
        {
            TemplateExerciseRunner q1 = new HandsExercise();
            q1.Run();
            Console.WriteLine();

            TemplateExerciseRunner q2 = new LegsExercise();
            q2.Run();
            Console.WriteLine();

        }
    }
}
