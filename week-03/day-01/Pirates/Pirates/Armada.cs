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
            int armySize = random.Next(2, 15);
            for (int i = 0; i < armySize; i++)
            {
                int captainRum = random.Next(10, 20);
                int crewRum = random.Next(5, 10);
                Ship ship = new Ship(captainRum, crewRum);
                ship.FillShip();
                this.army.Add(ship);
                Console.WriteLine($"{i+1}. ship has {ship.ship.Count} pirates in the crew.");
            }
        }
        public bool BattleArmy(Armada secondArmy)
        {
            int i = this.army.Count - 1;
            int j = secondArmy.army.Count - 1;
            Console.WriteLine();
            Console.WriteLine("The Battle begins!");
            Console.WriteLine();

            while (j != -1 && i != -1)
            {
                bool win = this.army[i].Battle(secondArmy.army[j]);
                if (win)
                {
                    Console.WriteLine("Ship of the first army has won the battle");
                    Console.WriteLine();
                    --j;
                }
                else
                {
                    Console.WriteLine("Ship of the second army has won the battle");
                    Console.WriteLine();
                    --i;
                }
            } 



                if (j == -1)
            {
                Console.WriteLine($"First army has won with {i+1} ships remaining");
                return true;
            }
            else
            {
                Console.WriteLine($"Second army has won with {j+1} ships remaining");
                return false;
            }
        }

    }
}
