using System;
using System.Collections.Generic;

namespace mapIntroduction_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> firstDic = new Dictionary<int, string>();
            bool isEmpty = firstDic.Count >= 0;
            Console.WriteLine(isEmpty);
            firstDic.Add(97, "a");
            firstDic.Add(98, "b");
            firstDic.Add(99, "c");
            firstDic.Add(65, "A");
            firstDic.Add(66, "B");
            firstDic.Add(67, "C");
            foreach (int thing in firstDic.Keys)
            {
                Console.WriteLine(thing);
            }
            foreach  (string something in firstDic.Values)
            {
                Console.WriteLine(something);
            }
            firstDic.Add(68, "D");
            Console.WriteLine(firstDic.Count);
            foreach (KeyValuePair<int, string> pair in firstDic)
            {
                if (pair.Key == 99)
                {
                    Console.WriteLine(pair.Value);
                }
                if (pair.Key == 97)
                {
                    firstDic.Remove(pair.Key);
                }
            }
            int keyCount = 0;
            foreach (int key in firstDic.Keys)
            {
                if (key == 100)
                {
                    keyCount++;
                }

            }
            if (keyCount > 0)
            {
                Console.WriteLine("There is a key 100");
            }
            else
            {
                Console.WriteLine("There is not a key like that");
            }
            firstDic.Clear();
        }
    }
}
