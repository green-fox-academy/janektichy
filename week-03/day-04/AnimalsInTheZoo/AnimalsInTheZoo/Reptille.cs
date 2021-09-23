using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsInTheZoo
{
    class Reptile : Animal
    {
        protected int numberOfTeeth;

        public Reptile(string name)
        {
            this.name = name;
        }
        public override void Greet()
        {
            throw new NotImplementedException();
        }

        public override string Sound()
        {
            return "grrr";
        }

        public override void WantChild()
        {
            Console.Write("watns child from an egg");
            Console.WriteLine();
        }
        public override void GetName()
        {
            Console.Write(this.name);
        }
    }
}
