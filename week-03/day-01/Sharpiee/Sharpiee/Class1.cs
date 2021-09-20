using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpiee
{
    class Sharpie
    {
        public string color;
        public float width;
        public float inkAmount;

        public Sharpie(string color, float width)
        {
            this.color = color;
            this.width = width;
            this.inkAmount = 100;
        }
        public void Use()
        {
            this.inkAmount -= 10;
        }
    }
}
