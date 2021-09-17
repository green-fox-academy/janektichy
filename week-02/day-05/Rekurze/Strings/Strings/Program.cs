using System;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ChangeXchars("jsdsjkxsjdkxsdxxasdjlxjxkjxjx"));
        }
        static string ChangeXchars(string text, int i = 0)
        {
            if (i == text.Length)
            {
                return text;
            }
            else if (text[i] == 'x')
            {
                char[] converted = text.ToCharArray();
                converted[i] = 'y';
                text = new string(converted);
                return ChangeXchars(text, ++i);
            }
            else
            {
                return ChangeXchars(text, ++i);
            }

        }
    }
}
