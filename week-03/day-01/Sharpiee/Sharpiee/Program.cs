using System;

namespace Sharpiee
{
    class Program
    {
        static void Main(string[] args)
        {
            Sharpie sharpie = new Sharpie("Yellow", 50);
            sharpie.Use();
            Console.WriteLine(sharpie.inkAmount);
        }
    }
}
