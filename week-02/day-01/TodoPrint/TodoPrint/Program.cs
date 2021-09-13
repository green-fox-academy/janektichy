using System;
using System.Text;

namespace TodoPrint

{
    class Program
    {
        static void Main(string[] args)
        {

            StringBuilder TodoText = new StringBuilder("\n - Buy milk\n");
            TodoText.Insert(0,"My todo:");
            TodoText.AppendLine(" - Download games");
            TodoText.AppendLine("\t - Diablo");
       

            Console.Write(TodoText);
        }
    }
}
