using System;
using System.Collections.Generic;

namespace StringsAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveX("sxjxnsknkfnkxnskfnknxnnsmfnmx"));
        }
        public static string RemoveX(string text, int i = 0)
        {
            if (i == text.Length)
            {
                return text;
            }
            if (text[i] == 'x')
            {
                List<char> = StringToList()
                converted[i].
            }
        }
        public static void StringToList(string text, List<char> charList)
        {

            for (int i = 0; i < text.Length; i++)
            {
                charList[i] = text[i];
            }
        }
    }
}
