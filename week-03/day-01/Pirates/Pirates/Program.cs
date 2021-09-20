using System;

namespace Pirates
{
    class Program
    {
        static void Main(string[] args)
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
