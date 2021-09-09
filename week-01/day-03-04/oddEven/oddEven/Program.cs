using System;

namespace oddEven
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Give me a number and I will tell you if it's odd or even.");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            if (number % 2 == 0)
            {
                Console.WriteLine("That is an even number");
            }
            else
            {
                Console.WriteLine("This one is an odd number");
            }
            
        }
    }
}
