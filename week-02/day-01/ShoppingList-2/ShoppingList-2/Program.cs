using System;
using System.Collections.Generic;

namespace ShoppingList_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> prices = new Dictionary<string, double>();
            prices.Add("Milk", 1.07);
            prices.Add("Rice", 1.59 );
            prices.Add("Eggs", 3.14 );
            prices.Add("Cheese", 12.60 );
            prices.Add("Chicken Breasts", 9.40 );
            prices.Add("Apples", 2.61 );
            prices.Add("Tomato", 2.58 );
            prices.Add("Potato", 1.75 );
            prices.Add("Onion", 1.10 );
                  
            Dictionary<string, double> BobList = new Dictionary<string, double>();
            BobList.Add("Milk", 3);
            BobList.Add("Rice", 2);
            BobList.Add("Eggs", 2);
            BobList.Add("Chesse", 1);
            BobList.Add("Chicken Breast", 4);
            BobList.Add("Apples", 1);
            BobList.Add("Tomato", 2);
            BobList.Add("Potato", 1);
            Dictionary<string, double> AliceList = new Dictionary<string, double>();
            AliceList.Add("Rice", 1);
            AliceList.Add("Eggs", 5);
            AliceList.Add("Chicken Breasts", 2);
            AliceList.Add("Apples", 1);
            AliceList.Add("Tomato", 10);
        }
    }
}
