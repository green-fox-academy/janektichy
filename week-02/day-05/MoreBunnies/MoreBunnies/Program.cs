using System;

namespace MoreBunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountEars(10));
        }
        static int CountEars(int bunnies, int EarCounter = 0)
        {
            if (bunnies == 0)
            {
                return EarCounter;
            }
            if (bunnies%2 == 0)
            {
                return CountEars(bunnies - 1, EarCounter += 2);
            }
            else
            {
                return CountEars(bunnies - 1, EarCounter+=3);
            }

        }
    }
}
