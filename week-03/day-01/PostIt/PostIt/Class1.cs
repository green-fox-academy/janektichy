using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostIt
{
    class PostIt
    {
        public string text;
        public ConsoleColor color;
        public ConsoleColor bgColor;

        public PostIt(string text, ConsoleColor color, ConsoleColor bgColor)
        {
            this.text = text;
            this.color = color;
            this.bgColor = bgColor;
           
        }
        public void MakeParagraph()
        {
            Console.BackgroundColor = this.bgColor;
            Console.ForegroundColor = this.color;
            Console.WriteLine(this.text);
        }
    }
}
