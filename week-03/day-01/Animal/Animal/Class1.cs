using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Animal
    {
        public string name;
        public int hunger = 50;
        public int thirst = 50;

        public Animal(string name)
        {
            this.name = name;
            this.hunger = 50;
            this.thirst = 50;
        }
        public void Eat()
        {
            --this.hunger;
        }
        public void Drink()
        {
            --this.thirst;
        }
        public void Play()
        {
            --this.thirst;
            --this.hunger;
        }
    }
}
