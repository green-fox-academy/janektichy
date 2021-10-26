using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsefulUtilities.RandomColorDependency
{
    public class CeaserService
    {
        public string Caesar(string text, int shift)
        {
            if (shift < 0)
            {
                shift = shift + 26;
            }
            string result = "";

            foreach (var character in text)
            {
                var offset = char.IsUpper(character) ? 'A' : 'a';
                result += (char)((character + shift - offset) % 26 + offset);
            }

            return result;
        }
    }
}
