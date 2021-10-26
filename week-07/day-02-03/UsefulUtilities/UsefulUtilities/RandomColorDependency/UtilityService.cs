using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsefulUtilities.RandomColorDependency
{
    public class UtilityService
    {
        private readonly List<string> colors;
        private readonly Random random;

        public UtilityService()
        {
            colors = new List<string>
        {
            "red",
            "blue",
            "lime",
            "orange",
            "magenta"
        };

            random = new Random();
        }

        public string RandomColor()
        {
            return colors[random.Next(colors.Count)];
        }
        public bool ValidateEmail(string email)
        {
            if (email.Contains('@') && email.Contains('.'))
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
