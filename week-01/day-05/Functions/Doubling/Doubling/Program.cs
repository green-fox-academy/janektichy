using System;

namespace Doubling
{
    class Program
    {
        static void Main(string[] args)
        {
            int baseNumber = 123;
            baseNumber = DoubleNumber(baseNumber);
            Console.Write(baseNumber);
            
        }
        static int DoubleNumber(int number)
        {

            return number = 2 * number;
        }
    }
}
