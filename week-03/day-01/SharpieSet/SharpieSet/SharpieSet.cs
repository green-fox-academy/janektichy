using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpieSet
{
    class SharpieSet
    {
        public List<Sharpie> sharpies = new List<Sharpie>();
        
        public void AddSharpie(Sharpie sharpie)
        {
            this.sharpies.Add(sharpie);
        }
        public void CountUsable()
        {
            int count = 0;
            for (int i = 0; i < this.sharpies.Count; i++)
            {
                if (this.sharpies[i].inkAmount > 0)
                {
                    ++count;
                }
            }
            Console.WriteLine($"There is {count} sharpies in that sharpie set");
        }
        public void RemoveTrash()
        {
            int count = 0;
            for (int i = 0; i < this.sharpies.Count; i++)
            {
                if (!(this.sharpies[i].inkAmount > 0))
                {
                    this.sharpies.Remove(this.sharpies[i]);
                }
            }
        }
        public void ShowSharpies()
        {
            for (int i = 0; i < this.sharpies.Count; i++)
            {
                Console.Write($"{this.sharpies[i].width} {this.sharpies[i].color}");
                Console.WriteLine();
            }
        }
    }
}
