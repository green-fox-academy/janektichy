using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsInTheZoo
{
    class Bird : Animal
    {
        protected bool canFly;

        public Bird(string name)
        {
            this.canFly = true;
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
            Console.Write("wants child from an egg");
            Console.WriteLine();
        }
        public override void GetName()
        {
            Console.Write(this.name);
        }
    }
}
