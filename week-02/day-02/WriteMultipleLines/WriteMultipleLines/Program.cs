using System;
using System.IO;

namespace WriteMultipleLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "newfile.txt";
            string word = "Janek";
            int number = 10;
            createFile(path, word, number);


        }
        static void createFile(string path, string word, int number)
        {

            try
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    for (int i = 0; i < number; i++)
                    {
                        writer.WriteLine(word);

                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("invalid input");
            }
            string[] fileLines = File.ReadAllLines(path);
            for (int i = 0; i < fileLines.Length; i++)
            {
                Console.WriteLine(fileLines[i]);
            }
        }
    }
}
