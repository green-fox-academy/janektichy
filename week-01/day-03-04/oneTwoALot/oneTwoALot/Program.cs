using System;

namespace oneTwoALot
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Give me a number please");
            string input = Console.ReadLine();
            double number = double.Parse(input);
            if (number <= 0) 
            {
                Console.WriteLine("Not enough");
            }
            else if (number == 1) 
            {
                Console.WriteLine("One");
            }
            else if (number == 2)
            {
                Console.WriteLine("Two");
            }
            else
            {
                Console.WriteLine("A lot");
            }


            
        }
    }
}
