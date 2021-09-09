using System;

namespace drawPyramide
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number and I will make a pyramide with it");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            for (int line = 1; line < number; line++)
            {
                for (int position = 1; position <= number * 2; position++)
                {
                    if (position == number || (( number > position && position > number - line + 1 || position > number && position < number + line - 1)))
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
