using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates
{
    class BattleApp
    {
        public void GiveMeSomeBattle()
        {
            Ship ship1 = new Ship(20, 5);
            Ship ship2 = new Ship(15, 6);

            ship1.FillShip();
            ship1.RecountAliveOnShip();

            ship2.FillShip();
            ship2.RecountAliveOnShip();

            ship1.Battle(ship2);

            ship1.RecountAliveOnShip();
            ship2.RecountAliveOnShip();
        }
    }
}
