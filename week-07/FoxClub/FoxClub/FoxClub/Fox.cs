using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub
{
    public class Fox
    {
        public string Name { get; set; }
        public List<string> Tricks { get; set; }
        public string Food { get; set; }
        public string Drink { get; set; }
        public List<string> TricksToLearn { get; set; }
        public List<string> ActionHistory { get; set; }
        public Fox(string name)
        {
            Name = name;
            Food = "meat";
            Drink = "water";
            Tricks = new List<string>();
            TricksToLearn = new List<string>() { ("code in C#"), ("bejt dement"), ("udělat flexbox"), ("všude cpát kuřecí péro"), ("pařit among us") };
            ActionHistory = new List<string>();
        }
        public Fox()
        {
            Name = "kuřecí péro";
            Food = "meat";
            Drink = "water";
            Tricks = new List<string>();
            TricksToLearn = new List<string>() { ("code in C#"), ("bejt dement"), ("udělat flexbox"), ("všude cpát kuřecí péro"), ("pařit among us") };
            ActionHistory = new List<string>();
        }
    }
}
