using System;

namespace SubInt
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 1, 15, 25, 32, 84, 96, 43, 20, 70, 84 };
            int num = 2;
            FindMatchingIndexes(num, numbers);
        }
        static void FindMatchingIndexes(int num, int[] array)
        {
            int i;
            bool result;
            for (i = 0; i < array.Length; i++)
            {
                if (result = array[i].ToString().Contains(num.ToString()))
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
}
