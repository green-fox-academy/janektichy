using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    class BassGuitar : StringedInstrument
    {
        public BassGuitar()
        {
            this.name = "bass guitar";
            this.numberOfStrings = 4;
        }
        public BassGuitar(int numberOfStrings)
        {
            this.name = "bass guitar";
            this.numberOfStrings = numberOfStrings;
        }
        protected override void Sound()
        {
            Console.Write("duum-duum-duum");
        }

        public override void Play()
        {
            Console.Write($"{this.name}, a {numberOfStrings}-stringed instrument that ");
            this.Sound();
            Console.WriteLine();
        }
    }
}
