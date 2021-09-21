using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Sponsor : Person
    {
        public string company;
        public int hiredStudents;

        public Sponsor(string name, int age, string gender, string company)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.company = company;
            this.hiredStudents = 0;
        }
        public Sponsor()
        {
            this.name = "Jane Doe";
            this.age = 30;
            this.gender = "female";
            this.company = "Google";
        }
        public override void Introduce()
        {
            base.Introduce();
            Console.Write($"who represents company {company} and hired {hiredStudents} so far");
        }
        public void Hire()
        {
            ++this.hiredStudents;
        }
        public override void GetGoal()
        {
            Console.WriteLine("\nHire brilliant junior software developers.");
        }
    }
}
