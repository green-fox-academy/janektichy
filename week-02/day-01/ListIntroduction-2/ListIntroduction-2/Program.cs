using System;
using System.Collections.Generic;

namespace ListIntroduction_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Fruit = new List<string>() { "Apple", "Avocado", "Blueberries", "Durian", "Lychee" };
            List<string> Fruit2 = new List<string>() { "Apple", "Avocado", "Blueberries", "Durian", "Lychee" };
            bool isDurianIn = Fruit.Contains("Durian");
            Console.WriteLine(isDurianIn);
            Fruit2.Remove("Durian");
            Fruit.Insert(4, "Kiwifruit");
            bool isFruit2Bigger = Fruit2.Count > Fruit.Count;
            Console.WriteLine(isFruit2Bigger);
            Fruit.IndexOf("Avocado");
            Fruit2.IndexOf("Durian");
            Fruit2.AddRange(new List<string>
            {
                new string ("Passion Fruit"),
                new string ("Pomelo")
            });
            Console.WriteLine(Fruit[3]);

        }
    }
}
