using System;

namespace SumElements
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] numbers = { 54, 23, 66, 12 };
            int Sum = 0;
            for (int i = 1; i < 3; i++)
            {
                Sum = Sum + numbers[i];
            }
            Console.WriteLine(Sum);
            
        }
    }
}
