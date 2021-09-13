using System;
using System.Collections.Generic;

namespace ListIntroduction_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            Console.WriteLine(names.Count);
            Console.WriteLine(names.GetType());
            names.Add("William");
            bool isEmpty = names.Count >= 0;
            Console.WriteLine(isEmpty);
            names.Add("John");
            names.Add("Amanda");
            Console.WriteLine(names.Count);
            Console.WriteLine(names[2]);
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            foreach (var name in names)
            {
                if(name == "William" || name == "John" || name == "Amanda")
                {
                    Console.WriteLine(name);
                }
            }
            names.RemoveAt(1);
            for (int i = names.Count; i > 0; i--)
            {
                Console.WriteLine(names[i-1]);
            }
                    

        }
    }
}
