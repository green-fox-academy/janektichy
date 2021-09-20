using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates
{
    class Ship
    {
        public List<Pirate> ship = new List<Pirate>();
        int aliveOnShip;
        int rumConsumedCrew;
        int rumConsumedCaptain;
        int deathCount;

        public Ship(int rumConsumedCaptain, int rumConsumedCrewAvarage)
        {
            this.aliveOnShip = this.ship.Count - this.deathCount;
            this.rumConsumedCaptain = rumConsumedCaptain;
            this.rumConsumedCrew = this.aliveOnShip * rumConsumedCrewAvarage + rumConsumedCaptain;
        }

        public void FillShip()
        {
            var random = new Random();
            int max = random.Next(0, 114);
            Pirate captain = new Pirate();
            this.ship.Add(captain);
            for (int i = 0;i  <= max; i++)
            {
                this.ship.Add(new Pirate());
            }
        }
        public void RecountAliveOnShip()
        {
            foreach (var pirate in this.ship)
            {
                if (pirate.isDead)
                {
                    this.deathCount++;
                }
            }
            this.aliveOnShip = this.ship.Count - this.deathCount;
            Console.WriteLine($"There is {this.aliveOnShip} pirates left on the ship");
        }
        public bool Battle(Ship otherShip)
        {
            int score1 = this.aliveOnShip - this.rumConsumedCaptain;
            int score2 = otherShip.aliveOnShip - otherShip.rumConsumedCaptain;
            var random = new Random();
            if (score1 > score2)
            {
                int deaths = random.Next(0, otherShip.aliveOnShip);
                otherShip.aliveOnShip -= deaths;
                for (int i = 0; i < deaths; i++)
                {
                    otherShip.ship[i].isDead = true;
                }
                for (int i = 0; i < this.ship.Count; i++)
                {
                    int rum = random.Next(0, 100);
                    for (int j = 0; j < rum; j++)
                    {
                        this.ship[i].DrinkSomeRum();
                    }
                }
                return true;
            }
            else
            {
                int deaths = random.Next(0, this.aliveOnShip);
                for (int i = 0; i < deaths; i++)
                {
                    otherShip.ship[i].isDead = true;
                }
                this.aliveOnShip -= deaths;
                for (int i = 0; i < otherShip.ship.Count; i++)
                {
                    int rum = random.Next(0, 100);
                    for (int j = 0; j < rum; j++)
                    {
                        otherShip.ship[i].DrinkSomeRum();
                    }
                }
                return false;
            }

        }  
    }
}
