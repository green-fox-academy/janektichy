using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenfoxClassApp.Services
{
    public class StudentService : StudentList
    {

        public StudentService()
        {
            names = new List<string> { "Sanyi", "Lilla", "John" };
        }
    }
}
