using System;

namespace mileToKmConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, may I ask you, how far is it from Prague to Berlin (in miles please).");
            string length = Console.ReadLine();
            double length2 = double.Parse(length);

            bool control = Double.IsNaN(length2);

            if (control)
            {
                Console.WriteLine("This is not a number");
            }
            
            else
            {
             Console.WriteLine(length2 * 1.609344);
            }
            
        }
    }
}
