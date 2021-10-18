using System;
using System.Collections.Generic;
using System.Linq;

namespace FoxLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Fox> foxes = new List<Fox>();
            foxes.Add(new Fox("Pip","green", "stupid"));
            foxes.Add(new Fox("Pop", "blue", "lazy"));
            foxes.Add(new Fox("Pup", "green", "pallida"));
            foxes.Add(new Fox("Pep", "grey", "clever"));
            foxes.Add(new Fox("Pyp", "green", "small"));

            var greenFoxes = foxes.Where(f => f.Color == "green").ToArray();
            var pallidaGreenFoxes = foxes.Where(f => f.Type == "pallida" && f.Color == "green").ToList();
            Console.WriteLine();
        }
    }
}
