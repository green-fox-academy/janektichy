using System;
using System.Collections.Generic;

namespace IComparable
{
    class Program
    {
        public static void Main(string[] args)
        {
            var dominoes = InitializeDominoes();
            dominoes.Sort();
            foreach (var domino in dominoes)
            {
                Console.WriteLine($"{domino.Values[0]}, {domino.Values[1]}");
            }


        }

        public static List<Domino> InitializeDominoes()
        {
            var dominoes = new List<Domino>();
            dominoes.Add(new Domino(5, 2));
            dominoes.Add(new Domino(4, 6));
            dominoes.Add(new Domino(1, 5));
            dominoes.Add(new Domino(6, 7));
            dominoes.Add(new Domino(2, 4));
            dominoes.Add(new Domino(7, 1));
            return dominoes;
        }
    }
}
