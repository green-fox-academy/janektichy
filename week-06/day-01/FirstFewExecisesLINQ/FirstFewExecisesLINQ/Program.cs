using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstFewExecisesLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            int[] even = numbers.Where(n => n % 2 == 0).ToArray();
            double avarage = numbers.Where(n => n % 2 != 0).Average();
            int[] positiveSquared = numbers.Where(n => n > 0).Select(n => n * n).ToArray();
            int[] anotherNumbers = new[] { 3, 9, 2, 8, 6, 5 };
            int[] squaredIsMoreThanTwenty = anotherNumbers.Where(n => n * n > 20).ToArray();
            int[] lotOfNumbers = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            var group = lotOfNumbers.GroupBy(n => n).ToDictionary(n => n.Key, n => n.Count());
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            var found = cities.Where(s => s[0] == 'A' && s[s.Length - 1] == 'I').ToArray();
            string test = "alo K jsOSk LKDnd, nsn kndLNKDSNFLN ,sn l";
            var uppperChars = string.Join("", test).Where(c => Char.IsUpper(c));
            Console.WriteLine();
        }
    }
}
