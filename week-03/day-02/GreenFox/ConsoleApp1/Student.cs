using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student : Person
    {
        public string previousOrganization;
        public int skippedDays;

        public Student (string name, int age, string gender, string previousOrganization)
        {
            this.previousOrganization = previousOrganization;
            this.skippedDays = 0;
            this.name = base.name;
            this.gender = base.gender;
            this.age = base.age;
        }
        public Student()
        {
            this.previousOrganization = "The School Of life";
            this.skippedDays = 0;
            this.name = "Jane Doe";
            this.age = 30;
            this.gender = "female";
        }
        public override void GetGoal()
        {
            Console.WriteLine("\nBe a junior software developer.");
        }
        public override void Introduce()
        {
            base.Introduce();
            Console.Write($"from {previousOrganization} organization who skipped {skippedDays} from the course already");
        }
        public void SkipDays(int numberOfDays)
        {
            this.skippedDays += numberOfDays;
        }

    }
}
