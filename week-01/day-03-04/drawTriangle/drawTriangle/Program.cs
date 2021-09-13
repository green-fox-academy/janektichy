using System;

namespace drawTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a size of a triangle");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            int i = 1;
            int a = 0;
            while (i < number + 1)
            {
                while (a < i)
                {
                    Console.Write("*");
                    a++;
                }
                Console.WriteLine();
                i++;
                a = 0;
            }
            
        }
    }
}
