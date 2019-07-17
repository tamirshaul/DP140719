using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.FlyWeight
{
    public class FlyWeightFactory<T>
    {
        Dictionary<char, VeryHeavyObject> repository = new Dictionary<char, VeryHeavyObject>();

        VeryHeavyObject GetHeavyObjects(char typeOfObject)
        {
            if(this.repository.TryGetValue(typeOfObject, out VeryHeavyObject result))
            {
                return result;
            }

            VeryHeavyObject newObject = null;

            switch (typeOfObject)
            {
                case 'A':
                    newObject = new VeryHeavyObject();
                    break;
                case 'N':
                    newObject = new VeryHeavyObject();
                    break;
                case 'O':
                    newObject = new VeryHeavyObject();
                    break;

            }

            repository[typeOfObject] = newObject;

            return newObject;
        }
    }
}
