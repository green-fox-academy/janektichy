using System;

namespace guessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello stranger, lets play a game!");
            Console.WriteLine("I have a stored number and you have to guess which one");
            Console.WriteLine("(Its an int, so do not guess decimals please");
            string input = Console.ReadLine();
            int guess = int.Parse(input);
            int stored = 69;
            while (stored != guess)
            {
                if (stored < guess)
                {
                    Console.WriteLine("This number is too big, try again");
                    string input2 = Console.ReadLine();
                    guess = int.Parse(input2);
                }
                else if (stored > guess)
                {
                    Console.WriteLine("This number is too small, try again");
                    string input2 = Console.ReadLine();
                    guess = int.Parse(input2);
                }
            }



            Console.WriteLine("You got it man! The number is 69.");
        }
    }
}
