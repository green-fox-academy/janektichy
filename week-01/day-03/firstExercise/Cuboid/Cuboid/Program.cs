using System;

namespace Cuboid
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 15;
            double b = 22;
            double c = 30;
            double surfaceArea = 2 * (a + b) + 2 * (a + c) + 2 * (b + c);
            double Volume = a * b * c;

            Console.WriteLine($"Surface area of this cuboid is {surfaceArea}");
            Console.WriteLine($"Volume of this cuboid is {Volume}");



        }
    }
}
