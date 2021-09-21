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
            List<Domino> sorted = new List<Domino>();
            int isBigger = 0;
            for (int i = 0; i < dominoes.Count; i++)
            {
                for (int j = 0; j < dominoes.Count; j++)
                {
                    if (dominoes[i].Values[0] > dominoes[j].Values[0])
                    {
                        isBigger++;
                    }
                    else if (dominoes[i].Values[0] == dominoes[j].Values[1] && dominoes[i].Values[1] > dominoes[j].Values[1])
                    {
                        isBigger++;
                    }
                }
                sorted.Insert(isBigger, dominoes[i]);
            }
            return sorted;
        }
    }
}
