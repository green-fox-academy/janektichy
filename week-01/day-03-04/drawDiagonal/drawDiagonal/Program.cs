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


            int position;

            for (int line = 1; line <= number; line++)

            { 
                for (position = 1; position <= number; position++)
                {
                    if (position == number)
                    {
                        Console.WriteLine("%");

                    }
                    else
                    {
                        if (position == line || line == number || position == 1 || line == 1)
                        {
                            Console.Write("%");
                        }
                        else
                        {
                            Console.Write(" ");
                        }



                    }

                }
             
            }
            
        }
    }
}
