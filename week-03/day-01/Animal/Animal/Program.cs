using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal zebra = new Animal("zebra");
            Animal prase = new Animal("prase");
            Animal anakonda = new Animal("anakonda");
            Animal pes = new Animal("pes");
            pes.Eat();
            pes.Drink();
            zebra.Play();
            Console.WriteLine(zebra.hunger + zebra.thirst);
            Console.WriteLine(pes.hunger);
            Console.WriteLine(pes.thirst);
        }
    }
}
