using System;
namespace avarageOfInput
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Give me a number");
            string input1 = Console.ReadLine();
            double number1 = double.Parse(input1);
            Console.WriteLine("And another one");
            string input2 = Console.ReadLine();
            double number2 = double.Parse(input2);
            Console.WriteLine("And another one");
            string input3 = Console.ReadLine();
            double number3 = double.Parse(input3);
            Console.WriteLine("And another one");
            string input4 = Console.ReadLine();
            double number4 = double.Parse(input4);
            Console.WriteLine("Just one more please");
            string input5 = Console.ReadLine();
            double number5 = double.Parse(input5);


            Console.WriteLine($"Sum: {number1 + number2 + number3 + number4 + number5} Avarage: {(number1 + number2 + number3 + number4 + number5) / 5}");
        }
    }

}
