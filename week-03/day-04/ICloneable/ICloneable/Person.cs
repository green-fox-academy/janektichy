using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloneable
{
    class Person
    {
        public string name;
        public int age;
        public string gender;

        public Person(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
        public Person()
        {
            this.name = "Jane Doe";
            this.age = 30;
            this.gender = "female";
        }
        public virtual void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment!");

        }
        public virtual void Introduce()
        {
            Console.Write($"Hi, I'm {this.name}, a {this.age} years old {this.gender} ");
        }
    }
}
