using System;

namespace parametricAvarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me some numbers, end when you type 'count it,' I will give you the sum and the avarage of them");
            string input = "";
            
            double numero;
            double sum = 0;
            double count = 0;
            double avarage = 0;

            for (; input != "count it";)
            {

                input = Console.ReadLine();

                if (Double.TryParse(input, out numero))
                {
                    sum = sum + numero;
                    count++;
                    avarage = sum / count;
                    Console.WriteLine("Thanks");
                }
                else if (input == "count it") 
                {
                  Console.WriteLine($"Sum: {sum} Avarage: {avarage}");
                }
                else
                {
                    Console.WriteLine("This is not a number");
                }
            }
        }
    }
}
