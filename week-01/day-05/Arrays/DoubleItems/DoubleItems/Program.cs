using System;

namespace DoubleItems
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 3, 4, 5, 6, 7 };
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i] * 2;
                Console.WriteLine(numbers[i]);
            }
            
        }
    }
}
