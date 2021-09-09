using System;

namespace drawDiamond
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number and I will make a diamond with it");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            for (int line = 2; line <= number/2; line++)
            {
                for (int position = 1; position <= number * 2; position++)
                {
                    if (position == number || number > position && position > number - line + 1 || position > number && position < number + line - 1)
                    {
                        Console.Write("*");
                    }

                    else
                    {
                        Console.Write(" ");
                    }
                    
                }
                Console.WriteLine("");
            }
            for (int line = number / 2; line > 1; line--)
            {
                for (int position = 1; position <= number * 2; position++)
                {
                    if (position == number || number > position && position > number - line + 1 || position > number && position < number + line - 1)
                    {
                        Console.Write("*");
                    }

                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine("");
            }
        }
    }
}
