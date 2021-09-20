using System;

namespace PetrolStation
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car(0, 100);
            var station = new Station(500);

            station.Reffil(car);
            Console.WriteLine($"{car.gasAmount} {car.tankCapacity}, {station.gasAmount}");
        }
    }
}
