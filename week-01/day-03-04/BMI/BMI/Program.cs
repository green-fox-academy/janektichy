using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            double myWeight = 58;
            double myHeight = 1.79;
            double BMI = myWeight / (myHeight * myHeight);

            Console.WriteLine(BMI);
        }
    }
}
