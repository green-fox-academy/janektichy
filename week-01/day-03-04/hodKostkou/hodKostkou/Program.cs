using System;

namespace hodKostkou
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("press enter to throw a dice and see the score");
            Random player1 = new Random();
            Random player2 = new Random();
            int score1 = 0;
            int score2 = 0;
            for (; score1 < 5 && score2 < 5;)
            {
                Console.ReadLine();
                int throw1 = player1.Next(1, 7);
                int throw2 = player2.Next(1, 7);
                Console.WriteLine("Player number one throw is {throw1}");
                if (throw1 > throw2)
                {
                    score1++;
                    Console.WriteLine("Player number 1 has a point");
                }
                else if (throw1 < throw2)
                {
                    score2++;
                    Console.WriteLine("Player number 2 has a point");
                }
                else
                {
                    Console.WriteLine("It's a Tie, throw again");
                }
                
                Console.WriteLine($"Player number one has {score1} points and Player number two {score2} points");
            }
            
        }
    }
}
