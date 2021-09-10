using System;

namespace SwapElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] orders = { "first", "second", "third" };
            orders[0] = orders[1];
            orders[2] = orders[0];
            orders[0] = orders[1];
            Console.WriteLine(orders[0] + " " + orders[2]);
           
        }
    }
}
