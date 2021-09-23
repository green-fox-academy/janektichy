using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printable
{
    class Domino : IPrintable
    {
        protected int[] Values;

        public Domino(int a, int b)
        {
            this.Values = new int[] {a, b };
        }

        public void PrintAllFields()
        {
            Console.WriteLine($"Domino A side: {this.Values[0]}, B side: {this.Values[1]}");
        }
    }
}
