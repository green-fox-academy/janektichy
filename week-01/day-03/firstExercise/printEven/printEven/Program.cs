using System;

namespace printEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 501)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }
    }
}
