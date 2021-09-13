using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i < 101)

            {
                if ((i % 3 == 0)&&(i % 5 == 0))
                {
                    Console.WriteLine("Fizz Buzz");
                    i++;
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    i++;
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    i++;
                }
                else
                {
                    Console.WriteLine(i);
                    i++;
                }
                
            }
            
        }
    }
}
