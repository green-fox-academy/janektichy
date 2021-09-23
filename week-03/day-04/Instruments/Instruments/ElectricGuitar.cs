using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    class ElectricGuitar : StringedInstrument
    {
        public ElectricGuitar()
        {
            this.numberOfStrings = 6;
            this.name = "Electric Guitar";
        }
        public ElectricGuitar(int numberOfStrings)
        {
            this.numberOfStrings = numberOfStrings;
            this.name = "Electric Guitar";
        }

        public override void Play()
        {
            Console.Write($"{this.name}, a {numberOfStrings}-stringed instrument that ");
            this.Sound();
            Console.WriteLine("");
        }

        protected override void Sound()
        {
            Console.Write("twangs"); 
        }
    }
}
