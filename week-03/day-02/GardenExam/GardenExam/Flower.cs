using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenExam
{
    class Flower : Plant
    {

        public Flower(string name, double waterAmount) : base(name)
        {
            this.type = "Flower";
            this.name = name;
            this.waterMinimum = 5;
            this.waterAmount = waterAmount;
        }
    }
}
