using System;

namespace StringsAgainAndAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SeparateTheText("Ahoj, já jsem Janek"));
        }
        public static string SeparateTheText(string text, int i = 1)
        {
            if (i == text.Length)
            {
                return text;
            }
            else
            {
                text = text.Insert(i, "*");
                return SeparateTheText(text, i+2);
            }
        }
    }
}
