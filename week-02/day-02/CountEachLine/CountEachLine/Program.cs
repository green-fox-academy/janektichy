using System;
using System.IO;

namespace CountEachLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "/textfile.txt";

            try
            {
                string[] fileLines = File.ReadAllLines(fileName);
                int fileLineCount = fileLines.Length;
                Console.WriteLine("The file has " + fileLineCount + " Lines");
            }
            catch (Exception)
            {
                Console.WriteLine("There is no text in the file");
                throw;
            }


        }
    }
}
