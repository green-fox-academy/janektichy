using System;
using System.Collections.Generic;

namespace telephone_book
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            phoneBook.Add("William A. Lathan", "405-709-1865");
            phoneBook.Add("John K. Miller", "402-247-8568");
            phoneBook.Add("Hortensia E. Foster", "606-481-6467");
            phoneBook.Add("Amanda D. Newland", "319-243-5613");
            phoneBook.Add("Brooke P. Askew", "307-687-2982");
            Answers(phoneBook);
        }
        static void Answers(Dictionary<string, string> phoneBook)
        {
            int doWeKnow = 0;
            foreach (KeyValuePair<string, string> pair in phoneBook)
            {
                if (pair.Key == "John K. Miller")
                {
                    Console.WriteLine("John K. Miller's number is " + pair.Value);
                }
                if (pair.Value == "307-687-2982")
                {
                    Console.WriteLine("The number 307 - 687 - 2982 is " + pair.Key + "'s");
                }
                if (pair.Key == "Chris E. Myers")
                {
                    doWeKnow++;
                }
            }
            if (doWeKnow > 0)
            {
                Console.WriteLine("We do know Chris E. Myers' number");
            }
            else
            {
                Console.WriteLine("We don't know his number");
            }
        }
    }
}
