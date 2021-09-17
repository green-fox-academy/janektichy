using System;

namespace GreatestCommonDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BiggestDivisor(60, 115));
        }
        static int BiggestDivisor(int firstNumber, int secondNumber)
        {
            if (secondNumber != 0)
            {
                return BiggestDivisor(secondNumber, firstNumber % secondNumber);
            }
            else
            {
                return firstNumber;
            }
        }
    }
}
