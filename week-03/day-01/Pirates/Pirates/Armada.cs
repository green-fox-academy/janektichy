using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates
{
    class Armada
    {
        public List<Ship> army = new List<Ship>();

        public void FillArmy()
        {
            var random = new Random();
            int armySize = random.Next(0, 15);
            for (int i = 0; i < armySize; i++)
            {
                int captainRum = random.Next(10, 20);
                int crewRum = random.Next(5, 10);
                Ship ship = new Ship(captainRum, crewRum);
                ship.FillShip();
                this.army.Add(ship);
                Console.WriteLine(ship.ship.Count);
            }
        }
        public bool BattleArmy(Armada secondArmy)
        {
            int i = this.army.Count-1;
            int j = secondArmy.army.Count-1;
            while (j != 1 || i != 1)
            {
                for (; i > 0;)
                {
                    for (; j > 0;)
                    {
                        bool win = this.army[i].Battle(secondArmy.army[j]);
                        if (win)
                        {
                            j--;
                        }
                        else
                        {
                            i--;
                        }
                    }
                }
            }
            if (j == 1)
            {
                Console.WriteLine($"The other army has won with {secondArmy.army.Count - j}");
                return true;
            }
            else
            {
                Console.WriteLine($"Your army has won with {this.army.Count - i} ships left");
                return false;
            }
        }

    }
}
