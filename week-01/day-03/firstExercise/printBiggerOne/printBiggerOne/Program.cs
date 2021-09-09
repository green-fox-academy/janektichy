using System;

namespace printBiggerOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number!");
            string input = Console.ReadLine();
            double numerouno = Double.Parse(input);
            Console.WriteLine("Another one please!");
            string input2 = Console.ReadLine();
            double numerodos = Double.Parse(input2);


            if (numerodos > numerouno)
            {
                Console.WriteLine(numerodos + " is bigger");
            }
            else if (numerodos == numerouno)
            {
                Console.WriteLine("They are equal");
            }
            else
            {
                Console.WriteLine(numerouno + " is bigger");
            }

        }
    }
}
