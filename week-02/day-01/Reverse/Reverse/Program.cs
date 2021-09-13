using System;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {

            string toBeReversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";


         Reverse(toBeReversed);
        }
        static void Reverse(string toBeReversed)

        {
            char[] toReverse = toBeReversed.ToCharArray();
            char[] Reversed = new char[toReverse.Length];
            
            for (int i = 0; i < toBeReversed.Length; i++)
            {
                Reversed[i] = toReverse[Reversed.Length - i - 1];
               
            }
            
            Console.WriteLine(Reversed);

        }
    }
}
