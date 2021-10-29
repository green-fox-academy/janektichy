using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Services
{
    public class AllFoxes
    {
        public List<Fox> Foxes { get; set; }
        public AllFoxes(Fox fox)
        {
            Foxes = new List<Fox>();
            Foxes.Add(fox);
            Foxes[0].Tricks.Add("bejt dement");
            Foxes[0].Tricks.Add("udělat flexbox");
        }
    }
}
