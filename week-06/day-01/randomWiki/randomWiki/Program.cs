using System;
using System.IO;
using System.Linq;

namespace randomWiki
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileLines = File.ReadAllLines(@"wiki.txt");
            var mostCommon = string.Join(" ", fileLines).Split(new char[] { ' ', ',', '.'}).GroupBy(p => p).ToDictionary(p => p.Key, p => p.Count());
            Console.WriteLine();
        }
    }
}
