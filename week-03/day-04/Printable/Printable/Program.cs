using System;
using System.Collections.Generic;

namespace Printable
{
    class Program
    {
        static void Main(string[] args)
        {
            Domino domino = new Domino(1, 2);
            Todo todo = new Todo("Buy Milk", "high", true);
            Domino domino2 = new Domino(1, 2);
            Todo todo2 = new Todo("Buy Milk", "high", true);

            List<Domino> list1 = new List<Domino>();
            list1.Add(domino);
            list1.Add(domino2);

            List<Todo> list2 = new List<Todo>();
            list2.Add(todo);
            list2.Add(todo2);

            foreach (var item in list1)
            {
                domino.PrintAllFields();
            }

            foreach (var item in list2)
            {
                todo.PrintAllFields();
            }
        }
    }
}
