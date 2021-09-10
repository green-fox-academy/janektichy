using System;

namespace ChangeElement
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 1, 2, 3, 8, 5, 6 };
            numbers[4] = 8;
            Console.WriteLine(numbers[4]);
            
        }
    }
}
