using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            {

                double firstNumber = 22;
                double secondNumber = 13;
                double result_1 = firstNumber / secondNumber;
                int result_2;

                
                Console.WriteLine(firstNumber + secondNumber);
                Console.WriteLine(firstNumber - secondNumber);
                Console.WriteLine(firstNumber * secondNumber);
                Console.WriteLine(result_1);
                Console.WriteLine(firstNumber / secondNumber);

                int quotient = Math.DivRem(firstNumber, secondNumber, out result_2);
                

                Console.WriteLine(quotient);
                Console.WriteLine(result_2);
                
            }
        }
    }
}
