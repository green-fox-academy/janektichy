using System;

namespace SumDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfDigits(2328221));
        }
        static int SumOfDigits(int number)
        {
            if(number < 10)
            {
                return number;
            }
            return number%10 + SumOfDigits(number / 10);
        }
    }
}
