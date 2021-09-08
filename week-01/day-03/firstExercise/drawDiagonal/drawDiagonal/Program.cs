using System;

namespace drawDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Give me a number");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            int i = 1;
            int a = 1;
            int b = 1;
            int c = 1;

            while (i <= number)
            {
                if (i == 1)
                {

                    while (a <= number)
                    {
                        
                        Console.Write("%");
                        a++;
                    }
                }
                if (i == number)
                {

                    while (a <= number)
                    {
                        Console.Write("%");
                        a++;
                    }
                }
                else
                {
                    while (b<=number)
                    {
                        if (b == 1) 
                        {
                            Console.WriteLine("%");

                        }
                        else if (b == number)
                        { 
                            Console.Write("%");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                        b++;
                    }
                    b = 1;
                }
                a = 1;
                
                c = 1;
                i++;
            }


            // Write a program that reads a number from the standard input, then draws a
            // square like this:
            //
            //
            // %%%%%
            // %%  %
            // % % %
            // %  %%
            // %%%%%
            //
            // The square should have as many lines as the number was
        }
    }
}
