using System;

namespace drawChessTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number and I will make a chessboard of the same size");
            string input = Console.ReadLine();
            int size = int.Parse(input);

            for (int line = 1; line <= size; line++)
            {
                if (( line % 2) == 0)
                {
                    for (int position = 1; position <= size; position++)
                    {
                        Console.Write(" %");
                    }
                }
                else
                {
                    for (int position = 1; position <= size; position++)
                    {
                        Console.Write("% ");
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}
