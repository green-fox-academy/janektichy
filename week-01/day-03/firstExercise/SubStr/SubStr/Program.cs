using System;

namespace SubStr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a sentence");
            string sentence = Console.ReadLine();
            Console.WriteLine("Give me a word in that sentence");
            string word = Console.ReadLine();
            if (sentence.Contains(word))
            {
                Console.WriteLine($"Your word stars on the {sentence.IndexOf(word)}th index of the sentence");
            }
            else
            {
                Console.WriteLine("Your word doesn't appear in your sentence");
            }

            
        }
    }
}
