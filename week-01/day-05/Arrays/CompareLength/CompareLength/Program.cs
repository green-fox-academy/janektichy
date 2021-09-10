using System;

namespace CompareLength
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArrayOfNumbers = { 1, 2, 3 };
            int[] secondArrayOfNumbers = { 4, 5 };

            if (firstArrayOfNumbers.Length > secondArrayOfNumbers.Length)
            {
                Console.WriteLine("firstArrayOfNumbers is the longer one");
            }
            else
            {
                Console.WriteLine("secondArrayOfNumbers is longer");
            }
        }
    }
}
