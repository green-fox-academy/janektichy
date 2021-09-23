using System;

namespace AnimalsInTheZoo
{
    public class Zoo
    {
        public static void Main(string[] args)
        {
            var reptile = new Reptile("Crocodile");
            var mammal = new Mammal("Koala");
            var bird = new Bird("Parrot");

            Console.WriteLine("Who want a baby?");
            reptile.GetName();
            Console.Write(", ");
            reptile.WantChild();
            mammal.GetName();
            Console.Write(", ");
            mammal.WantChild();
            bird.GetName();
            Console.Write(", ");
            bird.WantChild();
        }
    }
}
