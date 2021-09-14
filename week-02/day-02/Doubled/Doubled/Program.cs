using System;
using System.IO;

namespace Doubled
{
    class Program
    {
        static void Main(string[] args)
        {
            string toUncode = @"toUncode.txt";
            UncodeDouble(toUncode);
        }
        static void UncodeDouble(string toUncode)
        {
            string uncoded = @"uncoded.txt";
            using (StreamWriter writer = new StreamWriter(uncoded))
            {
                using(StreamReader reader = new StreamReader(toUncode))
                {
                    while (reader.Peek()>=0)
                    {
                        char a = (char)reader.Read();
                        char b = (char)reader.Read();
                        writer.Write(b);
                        Console.Write(b);
                    }  
                }               
            }
        }
    }
}
