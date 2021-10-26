using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GreenfoxClassApp.Services
{
    public class FileStudentService : StudentList
    {
        public FileStudentService()
        {
            names = new List<string>();
            FillList();
        }
        public void FillList()
        {
            string[] fileLines = File.ReadAllLines("students.txt");
            for (int i = 0; i < fileLines.Length; i++)
            {
                names.Add(fileLines[i]);
            }
        }
    }
}
