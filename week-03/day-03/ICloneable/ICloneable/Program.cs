using System;

namespace Cloneable
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student();
            Student clone = student.Clone();
            clone.Introduce();
        }
    }
}
