using System;
using System.IO;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            string winx = "win-x.txt";
            string wino = "win-o.txt";
            string draw = "draw.txt";
            Result(winx);
            Result(wino);
            Result(draw);
        }
        static void Result(string game)
        {
            int rowIsOne = 0;
            int rowIsThree = 0;
            int columnIsOne = 0;
            int columnIsThree = 0;
            int rowEqualsColumn = 0;
            int secondDiagonal = 0;
            string[] converted = File.ReadAllLines(game);
            int k = 2;
            for (int i = 0; i < converted.Length; i++)
            {
                for (int j = 0; j < converted[i].Length; j++)
                {
                    if ((i == j) && (converted[i] == "X"))
                    {
                        rowEqualsColumn++;
                    }
                    if (i == 0 && converted[i] == "X")
                    {
                        rowIsOne++;
                    }
                    if (i == 2 && converted[i] == "X")
                    {
                        rowIsThree++;
                    }
                    if (j == 0 && converted[i] == "X")
                    {
                        columnIsOne++;
                    }
                    if (j == 2 && converted[i] == "X")
                    {
                        columnIsThree++;
                    }
                    if (i == j - k && converted[i] == "X")
                    {
                        k -= 2;
                        secondDiagonal++;
                    }
                }
            }
            
        }
    }
}
