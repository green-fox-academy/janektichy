using System;
using System.IO;

namespace UncodeReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            string toUncode = "toUncode.txt";
            UncodePLS(toUncode);
        }
        static void UncodePLS(string toUncode)
        {
            string uncoded = "newfile.txt";
            string[] allLines = new string[22];
            using (StreamReader reader = new StreamReader(toUncode))
            {
            using (StreamWriter writer = new StreamWriter(uncoded))
                {
                    for (int i = 0; i < allLines.Length; i++)
                    {
                        allLines[i] = reader.ReadLine();
                    }
                    for (int i = 0; i < allLines.Length; i++)
                    {
                        for (int j = allLines[i].Length-1; j >= 0; j--)
                        {
                            writer.Write(allLines[i][j]);
                            Console.Write(allLines[i][j]);
                        }
                    Console.WriteLine();
                    }
                }
            }
        }
    }
}
