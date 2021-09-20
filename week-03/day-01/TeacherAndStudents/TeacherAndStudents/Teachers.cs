using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherAndStudents
{
    class Teachers
    {
        private string name = "Pan Šulin";

        public void Teach(Students student)
        {
            student.Learn();
        }
        public void Answer()
        {
            Console.WriteLine("The teacher is answering the question");
        }
    }
}
