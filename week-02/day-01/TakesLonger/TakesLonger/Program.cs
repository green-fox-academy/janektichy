using System;
using System.Text;

namespace TakesLonger
{
    class Program
    {
        static void Main(string[] args)
        {
           
            StringBuilder quote = new StringBuilder("Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.");
            quote.Insert(21, "always takes longer than ");

            Console.WriteLine(quote);
        }
    }
}
