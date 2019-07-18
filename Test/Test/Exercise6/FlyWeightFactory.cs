using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Exercise6
{
    public static class FlyWeightFactory
    {

        private static Dictionary<NumberRepresentive, double> respository = new Dictionary<NumberRepresentive, double>();
        private static object key = new object();
        public static double GetHeavyObjects(NumberRepresentive typeOfObject)
        {
            if (respository.TryGetValueSpecial(typeOfObject, out double result))
            {
                Console.WriteLine("returning from memory");
                return result;
            }

            lock (key)
            {

                if (respository.TryGetValueSpecial(typeOfObject, out double resultAgain))
                {
                    Console.WriteLine("returning from memory");
                    return resultAgain;
                }

               Console.WriteLine("generating new");
                double newObject;

                newObject = Math.Pow(typeOfObject.Basis,typeOfObject.Mone);

                respository[typeOfObject] = newObject;

                return newObject;
            }

        }

        public static bool TryGetValueSpecial(this Dictionary<NumberRepresentive, double> repository, NumberRepresentive newNum, out double result)
        {
            bool flag = false;
            result = -1;
            var keys = repository.Keys;

            foreach (var key in keys)
            {
                if(key.Basis == newNum.Basis && key.Mone == newNum.Mone)
                {
                    flag = true;
                    result = repository[key];
                    break;
                }
            }
            return flag;
        }
    }
}
