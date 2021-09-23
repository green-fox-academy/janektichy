using System;
using Instruments;

namespace ConcertHall
{
    public class AppMusic
    {
        public static void Main(string[] args)
        {
           
            var guitar = new ElectricGuitar();
            var bassGuitar = new BassGuitar();
            var violin = new Violin();

            Console.WriteLine("Test 1 Play");
            guitar.Play();
            bassGuitar.Play();
            violin.Play();

            ElectricGuitar guitar2 = new ElectricGuitar(7);
            BassGuitar bassGuitar2 = new BassGuitar(5);

            Console.WriteLine("Test 2 Play");
            guitar2.Play();
            bassGuitar2.Play();
        }

    }
}
