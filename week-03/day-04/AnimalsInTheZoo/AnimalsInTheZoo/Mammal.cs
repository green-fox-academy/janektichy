using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsInTheZoo
{
    class Mammal : Animal
    {

        protected int numberOfBoobs;
        public Mammal(string name)
        {
            this.name = name;
        }
        public override void Greet()
        {
            throw new NotImplementedException();
        }

        public override string Sound()
        {
            throw new NotImplementedException();
        }

        public override void WantChild()
        {
            Console.Write("wants a child from my uterus");
            Console.WriteLine();
        }
        public override void GetName()
        {
            Console.Write(this.name);
        }
    }
}
