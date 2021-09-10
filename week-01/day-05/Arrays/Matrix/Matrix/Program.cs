using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] my2Darrray = new int[4, 4];
            for (int i = 0; i < my2Darrray.GetLength(0); i++)
            {
                for (int j = 0; j < my2Darrray.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.Write("1 ");
                    }
                    else
                    {
                        Console.Write("0 ");
                    }
                }
                Console.WriteLine();
            }
            
        }
    }
}
