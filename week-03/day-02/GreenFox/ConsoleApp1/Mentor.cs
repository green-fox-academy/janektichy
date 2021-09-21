using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Mentor : Person
    {
        public string level;

        public Mentor(string name, int age, string gender, string level)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.level = level;
        }
        public Mentor()
        {
            this.name = "Jane Doe";
            this.age = 30;
            this.gender = "female";
            this.level = "intermediate";
        }
        public override void GetGoal()
        {
            Console.WriteLine("\nEducate brilliant junior software developers.");
        }
        public override void Introduce()
        {
            base.Introduce();
            Console.Write($"{this.level} mentor");
        }
    }
}
