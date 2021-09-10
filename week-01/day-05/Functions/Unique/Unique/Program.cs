using System;

namespace Unique
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a method that takes an array of integers as a parameter
            //  and returns an array of integers where every integer is unique (occurs only once)

            //  Example

            //  should print: `[1, 11, 34, 52, 61]`
            int[] numbers = { 1, 5, 7, 10, 18, 20, 1, 7, 18, 1, 5, 10 };
            FindUniqueItems(numbers);
        }
        static void FindUniqueItems(int[] array)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            /*
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {

                for (; j < array.Length - i; j++)
                {
                    if (!array.ToString().Contains(array[i].ToString()))
                        {
                        Console.WriteLine(array[i]);
                        }
                    
                }
                j = 0;
            }
            bool isItUnique;
            for (int i = array.Length; i > 0; i++)
            {
                for (int j = 0; j < array.Length - i; j++)
                {
                    if (isItUnique = !array.ToString().Contains(array[i].ToString()))
                    {
                        Console.WriteLine(array[j]);
                    }
                    else
                    {

                    }
                }
            }*/
        }
    }
}
