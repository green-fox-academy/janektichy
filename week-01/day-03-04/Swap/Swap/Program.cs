using System;

namespace Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a = 123;
            int c = a;
            int b = 456;

            a = b;
            b = c;

            

            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}
