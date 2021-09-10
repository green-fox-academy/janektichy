using System;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = "";

            string input2 = "";
            isAnagram(input1, input2);
        }
        static void isAnagram(string input1, string input2)
        {
            Console.WriteLine("Give me a word please");
            input1 = Console.ReadLine();
            Console.WriteLine("Now, give me it's Anagram - the same word spelled backwards");
            input2 = Console.ReadLine();
            char[] firstWord = new char[input1.Length];
            char[] secondWord = new char[input2.Length];
            for (int i = 0; i < input1.Length; i++)
            {
                firstWord[i] = input1[i];
            }
            for (int i = input2.Length - 1; i > 0; i--)
            {
                secondWord[i - 1] = input2[i];
            }
            Array.Reverse(secondWord);


            int isSame = 0;
            int j;
            for (j = 0; j < firstWord.Length; j++)
            {
                if (secondWord[j] == firstWord[j])
                {
                    isSame++;
                }

                
            }



            if (isSame == secondWord.Length)
            {
                Console.WriteLine("That's an Anagram");
            }
            else
            {
                Console.WriteLine("That's not an Anagram");
                
            }
        }
    }
}
