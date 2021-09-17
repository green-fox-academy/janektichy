using System;

namespace MaximumFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] theRowOfNumbers = { 10, 20, 15, 21, 36, 50, 12, 0, 4, 8, 19, 80 };
            Console.WriteLine(WhatIsTheBiggest(theRowOfNumbers));
        }
        public static int WhatIsTheBiggest(int[] theRowOfNumbers, int k = 0, int index = 0)
        {
            if (index == theRowOfNumbers.Length)
            {
                return k;
            }
            else if (k < theRowOfNumbers[index])
            {
                return WhatIsTheBiggest(theRowOfNumbers, k = theRowOfNumbers[index], ++index);
            }
            else
            {
                return WhatIsTheBiggest(theRowOfNumbers, k, ++index);
            }
        }
    }
}
