using System;

namespace animalsAndLegs
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Give me a number of chickens on a farm");
            string chicken = Console.ReadLine();
            int chlegs = int.Parse(chicken);
            Console.WriteLine("Give me a number of pigs on a farm");
            string pig = Console.ReadLine();
            int plegs = int.Parse(pig);

            Console.WriteLine($"There is {plegs * 4 + chlegs * 2} animal legs on that farm");
            
        }
    }
}
