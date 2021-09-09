using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Welcome to the Calculator!");
            Console.WriteLine("Please provide the first number:");

            string firstinput = Console.ReadLine();
            int firstnumber = int.Parse(firstinput);


            Console.WriteLine("Please provide the second number:");

            string secondinput = Console.ReadLine();
            int secondnumber = int.Parse(secondinput);

            Console.WriteLine("Please provide the operation (add, subtract, multiply or divide):");
            string operation = Console.ReadLine();

            double result = 0;
            switch (operation)
            {
                case "*":
                case "multiply":
                    result =  firstnumber * secondnumber;
                    break;
                case "/":
                case "divide":
                    result = firstnumber / secondnumber;
                    break;
                case "subtract":
                case "-":
                    result = firstnumber - secondnumber;
                    break;
                case "add":
                case "+":
                    result = firstnumber + secondnumber;
                    break;
                default:
                    Console.Error.WriteLine("Invalid size. Please try again.");
                    return;
            }

            
        

            Console.WriteLine($"The result of the calculation is {result}");
        }
    }
}
