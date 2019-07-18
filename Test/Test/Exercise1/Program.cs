using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Exercise1
{
    public class Program
    {
        public static void Exercise1(string[] args)
        {
            Game game1 = new Game();
            for (int i = 0; i < 51; i++)
            {
                game1.Hit();
            }

            Game game2 = new Game();
            for (int i = 0; i < 4; i++)
            {
                game1.NextStage();
            }
        }
    }
}
