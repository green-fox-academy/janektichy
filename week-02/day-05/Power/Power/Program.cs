using System;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Power(2,8));
        }
        static int Power(int number, int power)
        {
            if (power == 1)
            {
                return number;
            }
            return number * Power(number, power - 1);
        }
    }
}
