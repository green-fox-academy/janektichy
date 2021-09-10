using System;

namespace Summing
{
    class Program
    {
        static void Main(string[] args)
        {
            int parameter = 8;
            sum(parameter);
            
        }
        static void sum(int num1)
        {
            int Sum = 0;
            for (int num2 = 0; num2 <= num1; num2++)
            {
                Sum = Sum + num2;
            }
            Console.WriteLine(Sum);
        }
    }
}
