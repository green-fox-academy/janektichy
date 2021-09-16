using System;

namespace NumberAdder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberAdder(4));
        }
        static int NumberAdder(int lastNumber)
        {
            if(lastNumber == 1)
            {
                return 1;
            }
            return lastNumber + NumberAdder(lastNumber-1);
        }
    }
}
