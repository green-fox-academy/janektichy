using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenExam
{
    class Tree : Plant
    {
        public Tree(string name, double waterAmount) : base(name)
        {
            this.type = "Tree";
            this.name = name;
            this.waterAmount = waterAmount;
            this.waterMinimum = 10;
        }
    }
}
