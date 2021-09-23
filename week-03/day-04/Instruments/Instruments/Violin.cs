using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    class Violin : StringedInstrument
    {
        public Violin()
        {
            this.name = "Violin";
            this.numberOfStrings = 4;
        }
        public override void Play()
        {
            Console.Write($"{this.name}, a {numberOfStrings}-stringed instrument that ");
            this.Sound();
            Console.WriteLine();
        }

        protected override void Sound()
        {
            Console.Write("screech");
        }
    }
}
