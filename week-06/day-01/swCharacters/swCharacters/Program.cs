using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace swCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileLines = File.ReadAllLines(@"sw.txt");          
            var allCharacters = fileLines.Skip(1).Select(l => new Character(l)).ToList();
            var heaviestCharacter = allCharacters.OrderByDescending(c => c.Mass).First();
            var avarageMaleHeight = allCharacters.Where(c => c.Gender == "male").Select(c => c.Height).Average();
            var avarageFemaleHeight = allCharacters.Where(c => c.Gender == "female").Select(c => c.Height).Average();
            var dividedByGender = allCharacters.GroupBy(c => c.Gender).ToDictionary(g => g.Key, g => g).ToDictionary(g => g.Key, new Dictionary<string, int>);
            Console.WriteLine();
        }
    }
}
