using System;

namespace partyIndicator
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Give me a number please");
            string firstinput = Console.ReadLine();
            int girls = int.Parse(firstinput);
            Console.WriteLine("Give me another one");
            string secondinput = Console.ReadLine();
            int boys = int.Parse(secondinput);
            if ((boys == girls) && ((boys + girls) >= 20))
            {
                Console.WriteLine("The party is excellent.");
            }
            else if (girls == 0)
            {
                Console.WriteLine("Sausage party");
            }

            else if (((boys + girls) >= 20) && (boys != girls))
            {
                Console.WriteLine("Quite a cool party!");
            }
            else if ((boys + girls) < 20)
            {
                Console.WriteLine("Avarage party.");
            }
            
        }
    }
}
