using System;

namespace TeacherAndStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            var teacher = new Teachers();
            var student = new Students();

            student.Question(teacher);
            teacher.Teach(student);
        }
    }
}
