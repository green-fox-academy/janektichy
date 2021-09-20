using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominoes
{
    public class Dominoes
    {
        public static void Main(string[] args)
        {
            var dominoes = InitializeDominoes();
            List<Domino> orderedDominoes = OrderDominoes(dominoes);
            ShowDominoRow(orderedDominoes);


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
        public static List<Domino> OrderDominoes(List<Domino> dominoes)
        {
            var orderedDominoes = new List<Domino>();
            Domino firstDomino = dominoes[0];
            orderedDominoes.Add(firstDomino);
            for (int i = 0; i < dominoes.Count; i++)
            {
                for (int j = 0; j < dominoes.Count; j++)
                {
                    if (orderedDominoes[i].Values[1] == dominoes[j].Values[0])
                    {
                        orderedDominoes.Add(dominoes[j]);
                    }
                }
            }
            return orderedDominoes;
        }
        public static void ShowDominoRow(List<Domino> dominoes)
        {
            foreach (var domino in dominoes)
            {
                Console.WriteLine($"[{domino.Values[0]}, {domino.Values[1]}]");
            }
        }
    }
}
