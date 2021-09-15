using System;
using System.IO;

namespace LotteryNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbersToSort = "numbers.txt";
            SortNumbers(numbersToSort);
        }
        static void SortNumbers(string fileName)
        {
            string[] converted = File.ReadAllLines(fileName);
            string[][] splited = new string[converted.Length][];
            string[] splitedAndShorted = new string[splited.Length];
            for (int i = 0; i < converted.Length; i++)
            {
                splited[i] = converted[i].Split(";");
            }
            
            for (int i = 0; i < splited.Length-1; i++)
            {
                for (int j = splited[i].Length-1; j >= splited[i].Length-5; j--)
                {
                    splitedAndShorted[i] = splited[i][j];
                    Console.Write(splitedAndShorted[i]);
                }
                Console.WriteLine();
            }
           


        }
    }
}
