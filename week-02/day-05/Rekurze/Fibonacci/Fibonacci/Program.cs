using System;
using System.Collections.Generic;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> TheSequence = new List<int>() { 0, 1 };
            Console.WriteLine(Fibonacci(10, 0, TheSequence));
        }
        public static int Fibonacci(int n, int k, List<int> TheSequence)
        {
            if (k == n+1)
            {
                return TheSequence[n];
            }
            else if (k == 0 || k == 1)
            {
                return Fibonacci(n, ++k, TheSequence);
            }
            else
            {
                TheSequence.Add(TheSequence[k-1] + TheSequence[k - 2]);
                return Fibonacci(n, ++k, TheSequence);
            }

        }
    }
}
