using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    public class Animals
    {
        public string name;
        public int hunger = 50;
        public int thirst = 50;

        public Animals(string name)
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
            ++this.thirst;
            ++this.hunger;
        }
    }
}
