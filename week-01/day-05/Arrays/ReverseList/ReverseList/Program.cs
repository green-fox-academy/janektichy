using System;

namespace ReverseList
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 4, 5, 6, 7 };
            Array.Reverse(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Array.Reverse(numbers);
            
            
        }
    }
}
