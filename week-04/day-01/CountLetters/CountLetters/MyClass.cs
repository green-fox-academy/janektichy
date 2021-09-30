using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountLetters
{
    public class Count
    {
        public Count()
        {

        }
        public Dictionary<char, int> CountLetters(string input)
        {
            int containsCount = 0;
            Dictionary<char, int> output = new Dictionary<char, int>();
            char[] converted = input.ToCharArray();
            for (int i = 0; i < input.Length; i++)
            {
                
                if (output.ContainsKey(input[i]))
                {
                    continue;
                }
                else
                {
                    for (int j = 0; j < input.Length; j++)
                    {
                        if (input[i] == input[j])
                        {
                            ++containsCount; 
                        }
                    }
                    output.Add(input[i], containsCount);
                }
            containsCount = 0;
            }
            return output;
        }
    }
}
