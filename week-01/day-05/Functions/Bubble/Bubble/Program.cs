using System;

namespace Bubble
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 25, 47, 12, 15, 8, 1, 5, 32, 60 };
            sortArray(myArray);
        }
        static void sortArray(int[] array)
        {
            int isBigger = 0;
            int[] sorted = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i]>array[j])
                    {
                        isBigger++;
                        

                    }
                    
                }
                sorted[isBigger] = array[i];
               
                isBigger = 0;
            }
            for (int i = 0; i < sorted.Length; i++)
            {
                Console.WriteLine(sorted[i]);
            }

        }
    }
}
