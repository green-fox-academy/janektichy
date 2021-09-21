using System;

namespace GardenExam
{
    class Program
    {
        static void Main(string[] args)
        {
            var flower1 = new Flower("yellow", 0);
            var flower2 = new Flower("blue", 0);
            var tree1 = new Tree("purple", 0);
            var tree2 = new Tree("orange", 0);

            var garden = new Garden();
            garden.plants.Add(flower1);
            garden.plants.Add(flower2);
            garden.plants.Add(tree1);
            garden.plants.Add(tree2);

            garden.ShowGardenInfo();

            Console.WriteLine();

            garden.WaterTheGarden(40);

            Console.WriteLine();

            garden.WaterTheGarden(70);

        }
    }
}
