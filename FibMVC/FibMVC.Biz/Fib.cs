using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibMVC.Biz
{
    public class Fib
    {
        public List<int> fibList = new List<int>();
        
        public List<int> returnListOfFib(int num)
        {
            fibList.Add(0);
            fibList.Add(1);
            for(int i = 2; i < num; i++)
            {
                fibList.Add(fibList[i - 2] + fibList[i - 1]);
            }

            return fibList;
        }

    }
}
