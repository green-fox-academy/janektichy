using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coloring.Coloring
{
    public class Blue : IColor
    {
        public Printer Printer { get; set; }
        public Blue(Printer printer)
        {
            Printer = printer;
        }
        public void PrintColor()
        {
            Printer.Log("I am a blue color");
        }
    }
}
