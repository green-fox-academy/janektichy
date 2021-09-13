using System;
using System.Collections.Generic;

namespace PersonalFinance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Finance = new List<int>() { 500, 1000, 1250, 175, 800, 120 };
            FinanceSituation(Finance);
        }
        static void FinanceSituation(List<int> Finance)
        {
            
            int Spent = 0;
            int Count = 1;
            
            int isBigger = 0;
            int[] sorted = new int[Finance.Count];
            foreach (int number in Finance)
            {
                Count++;
                Spent += number;
            }
            for (int i = 0; i < Finance.Count; i++)
            {
                for (int j = 0; j < Finance.Count; j++)
                {
                    if (Finance[i] > Finance[j])
                    { 
                        isBigger++;
                    }
                }
                sorted[isBigger] = Finance[i];
                isBigger = 0;
            }
            int Avarage = Spent / (Count-1);

            Console.WriteLine("The Cheapest was " + sorted[0]);
            Console.WriteLine("The Greatest was " + sorted[Finance.Count - 1]);
            Console.WriteLine("We've spent " + Spent);
            Console.WriteLine("The Avarage was  " + Avarage);

        }
    }
}
