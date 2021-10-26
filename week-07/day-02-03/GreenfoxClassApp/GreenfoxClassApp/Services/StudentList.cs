using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenfoxClassApp.Services
{
    public abstract class StudentList
    {
        protected List<string> names;

        public List<string> FindAll()
        {
            return names;
        }

        public void Save(string student)
        {
            names.Add(student);
        }
        public void AddStudent(string name)
        {
            names.Add(name);
        }
        public int Count()
        {
            return names.Count();
        }
    }
}
