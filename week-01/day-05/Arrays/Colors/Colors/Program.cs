using System;

namespace Colors
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] colors = new string[3][];
            

                colors[0] = new string[] { "lime", "forest green", "olive", "pale green", "spring green"};
                colors[1] = new string[] { "orange red", "red", "tomato" };
                colors[2] = new string[] { "orchid", "violet", "pink", "hot pink"};

            Console.WriteLine(colors[0][2]);
        }
    }
}
