using System;

namespace Farm
{
    class Program
    {
        static void Main(string[] args)
        {
            var animal1 = new Animal("Cow");
            var animal2 = new Animal("Horse");
            var animal3 = new Animal("Pig");
            var animal4 = new Animal("Goat");
            var animal5 = new Animal("Dog");
            var animal6 = new Animal("Tiger");

            var farm = new Farm();
            farm.Breed(animal1);
            farm.Breed(animal2);
            farm.Breed(animal3);
            farm.Breed(animal4);
            farm.Breed(animal5);
            farm.Breed(animal6);

            animal1.Play();
            animal2.Play();
            animal2.Play();
            animal3.Eat();
            animal4.Eat();
            animal4.Eat();


            farm.Sell();
            farm.ShowAnimals();

        }
    }
}
