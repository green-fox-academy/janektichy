using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOfThings
{
    public class Thing
    {
        private string Name;
        private bool Completed;

        public Thing(string name)
        {
            this.Name = name;
        }

        public void Complete()
        {
            this.Completed = true;
        }
        public void ShowThing()
        {
            if (this.Completed)
            {
                Console.Write("[x]");
            }
            else
            {
                Console.Write("[ ]");
            }

            Console.Write(" " + this.Name);
            Console.WriteLine();
        }
    }
}
