using System;
using System.Collections.Generic;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ShoppingList = new System.Collections.Generic.List<string>() {"eggs", "milk", "fish", "apples", "bread", "chicken" };
            ListSearch(ShoppingList);

        }
        static void ListSearch(List<string> ShoppingList)
        {
            int bSearchCount = 0;
            int mSearchCount = 0;
            foreach (string item in ShoppingList)
            {
                if (item == "milk")
                {
                    mSearchCount++;
                }
                if (item == "bananas")
                {
                    bSearchCount++;
                }
            }
            if (mSearchCount > 0)
                Console.WriteLine("We do have milk on the list");
            else
                Console.WriteLine("We do not have milk on the list");
            if (bSearchCount > 0)
                Console.WriteLine("We do have bananas on the list");
            else
                Console.WriteLine("We do not have bananas on the list");
        }
    }
}
