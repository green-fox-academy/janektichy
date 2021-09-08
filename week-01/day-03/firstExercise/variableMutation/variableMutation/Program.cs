using System;

namespace variableMutation
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;


            Console.WriteLine(a + 10);

            int b = 100;


            Console.WriteLine(b - 7);

            int c = 44;


            Console.WriteLine(c * 2);

            int d = 125;


            Console.WriteLine(d / 5);

            int e = 8;


            Console.WriteLine(e * e * e);

            int f1 = 123;
            int f2 = 345;
            bool compared = f1 > f2;


            if (compared)
            {
                Console.WriteLine(compared);
            }
            else
            {
                Console.WriteLine("f1 is not bigger");
            }

            int g1 = 350;
            int g2 = 200;

            bool isItBigger = (g2 * 2) > g1;
            Console.WriteLine(isItBigger);

            float h = 1357988018575474;

            bool isItADivisor = h % 11 == 0;

            Console.WriteLine(isItADivisor);




            int i1 = 10;
            int i2 = 3;
            
            bool firstPart = (i2 * i2 * i2) > i1;
            bool secondPart = i1 > (i2 * i2);

            Console.WriteLine(firstPart && secondPart);

            int j = 1521;
            
            bool firstOne = 1521 % 5 == 0;
            bool secondOne = 1521 % 3 == 0;

            Console.WriteLine(firstOne || secondOne);
        }
    }
}
