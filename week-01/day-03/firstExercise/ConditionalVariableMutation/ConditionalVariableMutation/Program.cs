using System;

namespace ConditionalVariableMutation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 24;
            int output1 = 0;

            if (a % 2 == 0)
            {
                output1++;
            }

            Console.WriteLine(output1);

            int b = 13;
            string output2 = "";

            if (10 < b && b < 20)
            {
                Console.WriteLine("Sweet!");
            }
            else if (b < 10)
            {
                Console.WriteLine("Less!");
            }
            else
            {
                Console.WriteLine("More!");
            }


            Console.WriteLine(output2);

            int c = 123;
            int credits = 100;
            bool isBonus = true;

            if (credits >= 50 && isBonus == false)
            {
                c = c - 2;
            }
            else if (credits < 50 && isBonus == false)
            {
                c--;
            }


            Console.WriteLine(c);

            int d = 8;
            int time = 120;
            string output3 = "";

            if (d % 4 == 0 && time <= 200)
            {
                output3 = "check";
            }
            else if (time > 200)
            {
                output3 = "Time output";
            }
            else
            {
                output3 = "Run Forest, Run!";
            }


            Console.WriteLine(output3);
        }
    }
}
