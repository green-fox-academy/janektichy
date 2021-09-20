using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpieSet
{
    class Sharpie
    {
        public string color;
        public float width;
        public float inkAmount;

        public Sharpie(string color, float width, int inkAmount)
        {
            this.color = color;
            this.width = width;
            this.inkAmount = inkAmount;
        }
        public void Use()
        {
            this.inkAmount -= 10;
        }
    }
}
