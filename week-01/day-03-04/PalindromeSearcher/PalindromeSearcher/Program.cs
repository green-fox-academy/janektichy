using System;

namespace PalindromeSearcher
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, 5, 3, 7, 9, 3, 5, 11, 15, 17, 11, 15, 5, 3, 1 };
            findUnique(numbers);
        }
        static void findUnique(int[] array)
        {
            int controlOfUnique = 0;
            for (int i = array.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        controlOfUnique++;
                    }
                }
                if (controlOfUnique == 0)
                {
                    Console.WriteLine(array[i]);
                    
                }
                controlOfUnique = 0;
            }
        }
    }
}
