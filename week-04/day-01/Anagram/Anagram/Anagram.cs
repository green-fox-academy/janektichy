using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    public class AnagramFinder
    {
        public AnagramFinder()
        {

        }
        public bool IsAnagram(string input1, string input2)
        {
            int containsCount = 0;
            foreach (char letter in input1)
            {
                if (input2.Contains(letter))
                {
                    ++containsCount;
                }
            }
            if (containsCount == input2.Length && containsCount == input1.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
