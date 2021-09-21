using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates
{
    class WarApp
    {
        public void MakeWar()
        {
            Armada army = new Armada();
            Console.WriteLine("First Army:");
            army.FillArmy();
            Armada army2 = new Armada();
            Console.WriteLine("Second Army;");
            army2.FillArmy();

            army.BattleArmy(army2);
        }
    }
}
