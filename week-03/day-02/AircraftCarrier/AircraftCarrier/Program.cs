using System;

namespace AircraftCarrier
{
    class Program
    {
        static void Main(string[] args)
        {
            var gun1 = new F16();
            var gun2 = new F16();
            var gun3 = new F16();
            var gun4 = new F16();
            var gun5 = new F16();
            var gun6 = new F16();
            var gun7 = new F35();
            var gun8 = new F35();
            var gun9 = new F35();
            var gun10 = new F35();
            var gun11 = new F35();

            var carrier1 = new AircraftCarrier(500, 500);
            var carrier2 = new AircraftCarrier(200, 50);
            carrier1.arsenal.Add(gun1);
            carrier1.arsenal.Add(gun2);
            carrier1.arsenal.Add(gun3);
            carrier1.arsenal.Add(gun7);
            carrier1.arsenal.Add(gun8);


            carrier2.arsenal.Add(gun4);
            carrier2.arsenal.Add(gun5);
            carrier2.arsenal.Add(gun6);
            carrier2.arsenal.Add(gun9);
            carrier2.arsenal.Add(gun10);
            carrier2.arsenal.Add(gun11);


            carrier2.fill();
            carrier2.GetStatus();
            Console.WriteLine();
            carrier1.GetStatus();

        }
    }
}
