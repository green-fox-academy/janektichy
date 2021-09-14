using System;
using System.IO;

namespace BirthList
{
    class Program
    {
        static void Main(string[] args)
        {
            string list = "list.txt";
            GetBirths(list);

        }
        static void GetBirths(string adress)
        {
            int k = 0;
            string[] converted = File.ReadAllLines(adress);
            using (StreamWriter writer = new StreamWriter("onlyNumbers.txt"))
            {
                for (int i = 0; i < converted.Length; i++)
                {
                    for (int j = 0; j < converted[i].Length; j++)
                    {
                        if (Char.IsDigit(converted[i][j]))
                        {
                            writer.Write(converted[i][j]);
                        }
                    }
                    writer.WriteLine();
                }
            }
            string[] digitsOnly = File.ReadAllLines("onlyNumbers.txt");
            string[] birthYearsOnly = new string[digitsOnly.Length];
            for (int i = 0; i < digitsOnly.Length; i++)
            {
                birthYearsOnly[i] = digitsOnly[i].Substring(0, 4);
            }
            int isItSameCount = 0;
            int theBiggest = 0;
            int mostCommonYear = 0;          for (int i = 0; i < birthYearsOnly.Length; i++)
            {
                for (int j = 0; j < birthYearsOnly.Length; j++)
                {
                    if (birthYearsOnly[i] == birthYearsOnly[j] && i != j)
                    {
                        isItSameCount++;
                    }
                }
                if (isItSameCount > theBiggest)
                {
                    theBiggest = isItSameCount;
                    mostCommonYear = int.Parse(birthYearsOnly[i]);
                }
                isItSameCount = 0;
            }
            Console.WriteLine("In that list most people where born in " + mostCommonYear);
        }
    }
}
