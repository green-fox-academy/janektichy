using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxLINQ
{
    class Fox
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Type { get; set; }
        public Fox(string name, string color, string type)
        {
            this.Name = name;
            this.Color = color;
            this.Type = type;
        }
    }
}
