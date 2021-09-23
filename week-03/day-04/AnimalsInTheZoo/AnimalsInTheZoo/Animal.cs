using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsInTheZoo
{
    abstract class Animal
    {
        protected string name;
        protected int age;
        protected bool isMale;
        protected string type;


        public abstract void Greet();

        public abstract void WantChild();

        public abstract string Sound();

        public abstract void GetName();

    }
}
