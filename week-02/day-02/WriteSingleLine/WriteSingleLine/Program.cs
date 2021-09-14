using System;
using System.IO;

namespace WriteSingleLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "newfile3.txt";
            string Name = "Janek";
            createFile(path, Name);

            
        }
        static void createFile(string path, string Name)
        {


            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine(Name);
            }
            string[] fileLines = File.ReadAllLines(path);
            Console.WriteLine(fileLines[0]);
        }




    }
}
