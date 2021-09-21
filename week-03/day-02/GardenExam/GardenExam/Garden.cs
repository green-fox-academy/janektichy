using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenExam
{
    class Garden
    {
        public List<Plant> plants;

        public Garden()
        {
            this.plants = new List<Plant>();
        }
        public void ShowGardenInfo()
        {
            foreach (var plant in this.plants)
            {
                plant.ShowState();
            }
        }
        public void WaterTheGarden(int howMuch)
        {
            Console.WriteLine("Watering with " + howMuch);
            int howMany = 0;
            foreach (var plant in this.plants)
            {
                if (plant.waterAmount<plant.waterMinimum)
                {
                    howMany++;
                }
            }
            foreach (var plant in this.plants)
            {
                if (plant.waterAmount < plant.waterMinimum)
                {
                    if (plant.type == "Tree")
                    {
                        plant.waterAmount += (howMuch / howMany) * 0.4;
                    }
                    else
                    {
                        plant.waterAmount += (howMuch / howMany) * 0.75;
                    }
                }
            }
            this.ShowGardenInfo();
        }
    }
}
