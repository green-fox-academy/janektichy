using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates
{
    class Pirate
    {
        public int intoxication = 0;
        public bool isDead = false;

        public void DrinkSomeRum()
        {
            if (this.isDead == true)
            {
                Console.WriteLine("Sorry, I am dead");
            }
            else
            {
                this.intoxication++;
            }
            
        }
        public void HowsItGoingMate()
        {
            if (this.isDead == true)
            {
                Console.WriteLine("Sorry, I am dead");
            }
            else if (this.intoxication >= 4)
            {
                Console.WriteLine("Arghh, I'ma Pirate. How d'ya d'ink its goin?");
                this.intoxication = 0;
            }
            else
            {
                Console.WriteLine("Pour me anudder!");
            }
        }
        public void Brawl(Pirate pirate2)
        {
            var random = new Random();
            int fight = random.Next(1, 4);

            if (fight == 1)
            {
                this.isDead = true;
            }
            else if (fight == 2)
            {
                pirate2.isDead = true;
            }
            else if (fight == 3)
            {
                this.isDead = true;
                pirate2.isDead = true;
            }
        }
    }
}
