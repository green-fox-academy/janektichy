using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolStation
{
    class Car
    {
        public int gasAmount;
        public int tankCapacity;

        public Car(int gasAmount, int tankCapacity)
        {
            this.gasAmount = gasAmount;
            this.tankCapacity = tankCapacity;
        }
    }
}
