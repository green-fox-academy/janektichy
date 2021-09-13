using System;

namespace CountFromTo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Give me a number please");
            string inputone = Console.ReadLine();
            int numberone = int.Parse(inputone);
            Console.WriteLine("Give me another one");
            string inputtwo = Console.ReadLine();
            int numbertwo = int.Parse(inputtwo);

            if (numbertwo <= numberone)
            {
                Console.WriteLine("The second number should be bigger");
            }
            else
            {
                while (numberone < numbertwo)
                {
                    Console.WriteLine(numberone);
                    numberone++;
                }
            }
            
        }
    }
}
