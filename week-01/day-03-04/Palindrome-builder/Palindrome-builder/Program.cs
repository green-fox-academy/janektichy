using System;

namespace Palindrome_builder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            CreatePalindrome(input);
        }
        static void CreatePalindrome(string input)
        {
            Console.WriteLine("Type something in and I will make it a palindrome");
            input = Console.ReadLine();
            char[] splitToLetters = new char[input.Length];
            char[] splitReversed = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                splitToLetters[i] = input[i];
                splitReversed[i] = input[input.Length - i - 1];
            }
            Console.Write(splitToLetters);
            Console.Write(splitReversed);
            

        }
    }
}
