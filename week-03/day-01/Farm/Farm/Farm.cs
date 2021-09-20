using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    class Farm
    {
        List<Animal> animals = new List<Animal>();
        int limit = 5;

        public void Breed(Animal animal)
        {
            if (this.animals.Count < this.limit)
            {
                this.animals.Add(animal);
            }
            else
            {
                Console.WriteLine("There is to much animals on that Farm, you will have to sell one first");
            }
        }
        public void Sell()
        {
            int isHungryCount = 0;
            for (int i = 0; i < this.animals.Count; i++)
            {
                for (int j = 0; j < this.animals.Count; j++)
                {
                    if (this.animals[i].hunger > this.animals[j].hunger)
                    {
                        isHungryCount++;
                    }
                    if (isHungryCount == 0)
                    {
                        this.animals.Remove(this.animals[i]);
                    }
                }
            }
        }
        public void ShowAnimals()
        {
            for (int i = 0; i < this.animals.Count; i++)
            {
                Console.WriteLine(this.animals[i].name);
            }
        }
    }
}
