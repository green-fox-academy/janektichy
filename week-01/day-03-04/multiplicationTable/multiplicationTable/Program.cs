using System;

namespace multiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Give me a number and I will give you the multiplication table of that number");
            string input = Console.ReadLine();
            int numero = int.Parse(input);
            int i = 1;

            while (i<11)
            {
                Console.WriteLine(i + $"* {numero} ="+ i * numero);
                i++;
            }
            
            
        }
    }
}
