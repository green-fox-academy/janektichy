using System;
using System.Collections.Generic;

namespace ProductDatabase
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
        static void Answer(Dictionary<string, int> Products)
        {
            int[] sorted = new int[Products.Count];
            int Sum = 0;
            int productCount = 0;
            int biggerCount = 0;
            int smallerCount = 0;
            int isBelow300 = 0;
            int for125Count = 0;

            foreach (KeyValuePair<string, int> pair in Products)
            {
                Sum += pair.Value;
                productCount++;
                if (pair.Value < 300)
                {
                    isBelow300++;
                }
                if (pair.Key == "Fish")
                {
                    Console.WriteLine("The fish cost is " + pair.Value);
                }
                if (pair.Value == 125)
                {
                    for125Count++;
                }

                foreach (int price in Products.Values)
                {
                    if (price < pair.Value)
                    {
                        biggerCount++;
                    }
                    if (price > pair.Value)
                    {
                        smallerCount++;
                    }
                }
                if (smallerCount == 5)
                {
                    Console.WriteLine("The lowest price is for " + pair.Key);
                }
                if (biggerCount == 5)
                {
                    Console.WriteLine("The biggest price is for " + pair.Key);
                }


                biggerCount = 0;
                smallerCount = 0;

            }
            Console.WriteLine($"there is {isBelow300} prices under 300");
            if (for125Count == 6)
            {
                Console.WriteLine("There is something for 125");
            }
            else
            {
                Console.WriteLine("There is nothing for 125");
            }
            int Avarage = Sum / productCount;
            Console.WriteLine("The Avarage cost is " + Avarage);
        }
    }
}
