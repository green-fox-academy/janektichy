using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparable
{
    public class Domino : IComparable
    {
        public readonly int[] Values;

        public Domino(int valueA, int valueB)
        {
            this.Values = new int[] { valueA, valueB };
        }

        public int[] GetValues()
        {
            return Values;
        }
        public List<Domino> Sort(List<Domino> dominoes)
        {
            Domino checkPoint = new Domino(0, 0);
            for (int j = 0; j < dominoes.Count; j++)
            {
                for (int i = 0; i < dominoes.Count - 1; i++)
                {
                    if (dominoes[i + 1].Compare(dominoes[i]))
                    {
                        checkPoint = dominoes[i];
                        dominoes[i] = dominoes[i + 1];
                        dominoes[i + 1] = checkPoint;
                    }
                }
            }
            return dominoes;
        }
        public bool Compare(Domino secondDomino)
        {
          if (this.Values[0] > secondDomino.Values[0] || (this.Values[0] == secondDomino.Values[0]) && (this.Values[1] > secondDomino.Values[1]))
            {
                return true;
            }
          else
            {
                return false;
            }
        }
    }
}
