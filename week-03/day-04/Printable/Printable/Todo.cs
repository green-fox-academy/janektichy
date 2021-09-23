using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printable
{
    class Todo : IPrintable
    {
        protected string task;
        protected string priority;
        protected bool isDone;

        public Todo(string task, string priority, bool isDone)
        {
            this.task = task;
            this.priority = priority;
            this.isDone = isDone;
        }

        public void PrintAllFields()
        {
            Console.WriteLine($"Task: {this.task} | Priority: {this.priority} | Done: {this.isDone}");
        }
    }
}
