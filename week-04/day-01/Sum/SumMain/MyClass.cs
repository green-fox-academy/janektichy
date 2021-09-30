using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumMain
{
    public class MyClass
    {
        public MyClass()
        {

        }
        public static int GetSum(List<int> input)
        {
            int sum = 0;
            foreach (int number in input)
            {
                sum += number;
            }
            return sum;
        }
    }
}
