using System;

namespace secondsInADay
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;

            if (currentMinutes > 0)
            {
                currentHours = currentHours + 1;
            }
            
            if (currentSeconds > 0)
            {
                currentMinutes = currentMinutes + 1;
            }

            int remainingHours = 24 - currentHours;
            int remainingMinutes = 60 - currentMinutes;
            int remainingSeconds = 60 - currentSeconds;



       

            Console.WriteLine($"{remainingHours} hours { remainingMinutes} minutes and {remainingSeconds} seconds  is remaining.");
                
            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented by the variables above
        }
    }
}
