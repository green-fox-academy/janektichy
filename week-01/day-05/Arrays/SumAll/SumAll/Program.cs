using System;

namespace SumAll
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 4, 5, 6, 7 };
            int Sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                Sum = numbers[i] + Sum;
            }
            Console.WriteLine(Sum);
            
        }
    }
}
