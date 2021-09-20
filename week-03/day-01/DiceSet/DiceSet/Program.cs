using System;

namespace DiceSet
{
    class Program
    {
        public static void Main(string[] argv)
        {

            DiceSet diceSet = new DiceSet();


            diceSet.Roll();
            for (int i = 0; i < 6; i++)
            {
                while (diceSet.dice[i] != 6)
                {
                    diceSet.Reroll(i);
                }
                Console.Write(diceSet.dice[i] + " ");
            }
        }
    }
}
