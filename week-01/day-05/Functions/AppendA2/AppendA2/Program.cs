using System;

namespace AppendA2
{
    class Program
    {
        static void Main(string[] args)
        {
            string typo = "Chinchill";
            AppendA(typo);
            
        }
        static void AppendA(string name)
        {
            string a = "a";
            Console.WriteLine(name + a);
        }
    }
}
