using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Bonus2
{
    class Program
    {
        public static void Bonus2(string[] args)
        {
            List<string> strList = new List<string> { "java", "jjava" ,"vaj", "aavj", "j", "vjaa", "dan", "and", "ddan"};
            Console.WriteLine(CheckStr(strList, "vaj"));
        }

        public static int CheckStr(List<string> list)
        {
            var countInstances = 0;
            List<Dictionary<char, int>> DictList = new List<Dictionary<char, int>>();
            foreach (var listStr in list)
            {
                var tmp = new Dictionary<char, int>();
                foreach (var c in listStr)
                {
                    if (!tmp.ContainsKey(c))
                    {
                        flag = false;
                        break;
                    }
                    tmp[c]--;
                    if (tmp[c] == 0)
                    {
                        tmp.Remove(c);
                    }
                }
                    if(tmp.Count == 0 && flag)
                    {
                        countInstances++;
                        Console.WriteLine(listStr);
                    }
                
            }

            return countInstances;

        }
    }
}
