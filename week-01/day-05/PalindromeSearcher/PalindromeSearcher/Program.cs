using System;

namespace PalindromeSearcher
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = "012wxyz789";
            char[] arr;

            
            string[] words = { "racecar", "dog", "goat", "dad", "duck", "doodle", "never" };
            PalindromeSearcher(words);
            
        }
        static void PalindromeSearcher(string[] array)
        {
            int countOfChars = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    countOfChars++;
                }
            }
            int k = 0;
            char[] arrayOfChars = new char[countOfChars];
            for (int i = 0; i < array.Length; i++)
            {
                
                    string currentString = array[i];
                    char[] parsedWord = currentString.ToCharArray(0, array[i].Length);
                for (int j = 0; j < parsedWord.Length; j++)
                {
                    arrayOfChars[k] = parsedWord[j];
                    k++;
                }
                
            }


            for (int i = 1; i < arrayOfChars.Length - 1; i++)
            {
                if ((arrayOfChars[i - 1]) == (arrayOfChars[i + 1]))
                {
                    Console.Write(arrayOfChars[i - 1]);
                    Console.Write(arrayOfChars[i]);
                    Console.Write(arrayOfChars[i+1]);
                    Console.WriteLine();
                }
            }
            for (int i = 2; i < arrayOfChars.Length - 2; i++)
            {
                if ((arrayOfChars[i - 1]) == (arrayOfChars[i + 1]) && (arrayOfChars[i-2] == arrayOfChars[i+2]))
                {
                    Console.Write(arrayOfChars[i - 2]);
                    Console.Write(arrayOfChars[i - 1]);
                    Console.Write(arrayOfChars[i]);
                    Console.Write(arrayOfChars[i + 1]);
                    Console.Write(arrayOfChars[i + 2]);
                    Console.WriteLine();
                }
            }
            for (int i = 3; i < arrayOfChars.Length - 3; i++)
            {
                if ((arrayOfChars[i - 1]) == (arrayOfChars[i + 1]) && (arrayOfChars[i - 2] == arrayOfChars[i + 2]) && (arrayOfChars[i - 3] == arrayOfChars[i + 3]))
                {
                    Console.Write(arrayOfChars[i - 3]);
                    Console.Write(arrayOfChars[i - 2]);
                    Console.Write(arrayOfChars[i - 1]);
                    Console.Write(arrayOfChars[i]);
                    Console.Write(arrayOfChars[i + 1]);
                    Console.Write(arrayOfChars[i + 2]);
                    Console.Write(arrayOfChars[i - 3]);
                    Console.WriteLine();
                }
            }

        }
    }
}
