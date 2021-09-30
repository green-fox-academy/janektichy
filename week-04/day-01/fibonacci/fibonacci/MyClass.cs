using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    public class MyClass
    {
        public MyClass()
        {

        }
        public int Fibonacci(int index, int first = 0, int second = 1)
        {
            if (index == 1)
            {
                return first;
            }
            else
            {
                return Fibonacci(index - 1, second, first + second);
            }
        }
    }
}
