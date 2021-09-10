using System;

namespace Factorio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a non decimal number and I will give you it's factorial!");
            string input = Console.ReadLine();
            ulong number = ulong.Parse(input);
            calculateFactorial(number);
            
        }
        static void calculateFactorial(ulong
            
            num1)
        {
            ulong factorial = 1;
            for (ulong i = num1; i > 0; i--)
            {
                factorial = factorial * i;
            }
            Console.WriteLine(factorial);
        }
    }
}
