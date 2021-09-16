using System;

namespace Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfEars(20));
        }
        static int NumberOfEars(int bunnies, int EarCount = 0)
        {

            if (bunnies > 0)
            {
                return NumberOfEars(bunnies - 1, EarCount+=2);
            }
            return EarCount;
            
        }
    }
}
