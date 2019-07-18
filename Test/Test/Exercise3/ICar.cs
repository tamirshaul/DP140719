using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Exercise3
{
    public interface ICar : ICarProxy
    {
        void Start();
        void Stop();
        void Accelerate();
        void Slow();
        void TurnRight();
        void TurnLeft();
        
    }
}
