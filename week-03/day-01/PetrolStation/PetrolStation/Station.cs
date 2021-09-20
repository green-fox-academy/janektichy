using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolStation
{
    class Station
    {
        public int gasAmount;

        public Station(int gasAmount)
        {
            this.gasAmount = gasAmount;
        }
        public void Reffil(Car car)
        {
            car.gasAmount = car.tankCapacity;
            this.gasAmount -= car.tankCapacity;
        }
    }
}
