using System;
using System.Collections.Generic;

namespace MapIntroduction_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> Dic = new Dictionary<string, string>();
            Dic.Add("978-1-60309-452-8", "A Letter to Jo");
            Dic.Add("978-1-60309-459-7", "Lupus");
            Dic.Add("978-1-60309-444-3", "Red Panda and Moon Bear");
            Dic.Add("978-1-60309-461-0", "The Lab");

            foreach (KeyValuePair<string, string> pair in Dic)
            {
                Console.WriteLine($"{pair.Value} (ISBN: {pair.Key})");
            }
            foreach (KeyValuePair<string, string> pair in Dic)
            {
                if (pair.Key == "978-1-60309-444-3" || pair.Value == "The Lab")
                {
                    Dic.Remove(pair.Key);
                    Dic.Remove(pair.Value);
                }
            }
            Dic.Add("978-1-60309-450-4", "They Called Us Enemy");
            Dic.Add("978-1-60309-453-5", "Why Did We Trust Him?");
            foreach (string key in Dic.Keys)
            {
                if (key == "478-0-61159-424-8")
                {
                    Console.WriteLine("There is");
                }
                else
                {
                    Console.WriteLine("There is not");
                }

            }
            foreach (KeyValuePair<string, string> pair in Dic)
            {
                if (pair.Key == "978-1-60309-453-5")
                {
                    Console.WriteLine(pair.Value + "Is associated with that key");

                }
            }
        }
    }
}
