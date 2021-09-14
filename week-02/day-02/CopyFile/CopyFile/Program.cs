using System;
using System.IO;

namespace CopyFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileOriginal = "theoriginalfile.txt";
            string fileNew = "newfile.txt";
            CopyFile(fileOriginal, fileNew);
           
        }
        static void CopyFile(string fileOriginal, string fileNew)
        {
            using (StreamWriter writer = new StreamWriter(fileOriginal))
            {
                Console.WriteLine("ahoj");
                Console.WriteLine("já");
                Console.WriteLine("jsem");
                Console.WriteLine("Janek");
            }
                string[] allLines = File.ReadAllLines(fileOriginal);
            using (StreamWriter writer = new StreamWriter(fileNew))
                for (int i = 0; i < allLines.Length; i++)
                {
                    writer.WriteLine(allLines[i]);
                    Console.WriteLine(fileNew[i]);
                }
        }
    }
}
