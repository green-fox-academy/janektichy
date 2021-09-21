using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Cohort
    {
        public string name;
        public List<Student> students;
        public List<Mentor> mentors;

        public Cohort(string name)
        {
            this.name = name;
            this.students = new List<Student>();
            this.mentors = new List<Mentor>();
        }
        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }
        public void AddMentor(Mentor mentor)
        {
            this.mentors.Add(mentor);
        }
        public void Info()
        {
            Console.WriteLine($"The {this.name} cohort has {this.students.Count} students and {this.mentors.Count} mentors");
        }
    }
}
