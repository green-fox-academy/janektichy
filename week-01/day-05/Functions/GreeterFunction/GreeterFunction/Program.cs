using System;

namespace GreeterFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            string al = "Green Fox";
            Greet(al);
            
        }
        static void Greet(string Greetuser)
        {
           Console.WriteLine("Greetings dear, " + Greetuser);

        }
    }
}
