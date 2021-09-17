using System;
using System.Collections.Generic;

namespace StringsAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveX("sxjxnsknkfnkxnskfnknxnnsmfnm"));
        }
        public static string RemoveX(string text, int i = 0)
        {
            if (i == text.Length-1)
            {
                return text;
            }
            if (text[i] == 'x')
            {
                List<char> converted = StringToList(text);
                converted.Remove(converted[i]);
                text = String.Join("", converted.ToArray());
                return RemoveX(text, ++i);
            }
            else
            {
                return RemoveX(text, ++i);
            }
        }
        public static List<char> StringToList(string text)
        {
            List<char> charList = new List<char>();
            for (int i = 0; i < text.Length; i++)
            {
                charList.Add(new char() {});
                charList[i] = text[i];
            }
            return charList;
        }
    }
}
