using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherAndStudents
{
    class Students
    {
        private string name = "Janek";

        public void Learn()
        {
            Console.WriteLine("The student is actually learning");
        }
        public void Question(Teachers teacher)
        {
            teacher.Answer();
        }
    }
}
