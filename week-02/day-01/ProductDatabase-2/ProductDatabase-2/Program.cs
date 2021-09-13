using System;
using System.Collections.Generic;

namespace ProductDatabase_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> Products = new Dictionary<string, int>();
            Products.Add("Eggs", 200);
            Products.Add("Milk", 200);
            Products.Add("Fish", 400);
            Products.Add("Apples", 150);
            Products.Add("Bread", 50);
            Products.Add("Chicken", 550);
            Answer(Products);
        }
        static void Answer(Dictionary<string, int > Products)
        {
            foreach (KeyValuePair<string,int> pair in Products)
            {
                if (pair.Value < 201)
                {
                    Console.Write(pair.Value + " ");
                }
            }
            Console.WriteLine();
            foreach (KeyValuePair<string, int> pair in Products)
            {
                if (pair.Value > 150)
                {
                    Console.Write(pair.Key + " for " + pair.Value + ", ");
                }
            }
        }
    }
}
