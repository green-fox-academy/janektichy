using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenExam
{
    class Plant
    {
        public string type;
        public string name;
        public double waterMinimum;
        public double waterAmount;

        public Plant(string name)
        {
            this.name = name;
        }
        public void ShowState()
        {
            string doesNeedWater = "";
            if (this.waterAmount >= this.waterMinimum)
            {
                doesNeedWater = "doesn't need water";
            }
            else
            {
                doesNeedWater = "needs water";
            }
            Console.WriteLine($"The {name} {type} {doesNeedWater}");
        }
    }
}
