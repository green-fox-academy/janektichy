using System;

namespace appendA
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] animals = {"koal", "pand", "zebr", "anacond", "bo", "chinchill", "cobr", "gorill", "hyen", "hydr", "iguan", "impal", "pum", "tarantul", "pirahn"};
            for (int i = 0; i < animals.Length; i++)
            {
                animals[i] = "a " + animals[i];
                Console.WriteLine(animals[i]);
            }
            
            
        }
    }
}
