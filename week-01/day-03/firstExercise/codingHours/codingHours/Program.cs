using System;

namespace codingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            int avarageDaily = 6;
            int semesterLength = 17;
            int workingdaysInAWeek = 5;
            int codingInSemester = avarageDaily * semesterLength * workingdaysInAWeek;
            int workHoursWeekly = 52;
            int workHoursInSemester = workHoursWeekly * semesterLength;
            int percentageOfCodingHours = codingInSemester / (workHoursInSemester / 100);

            Console.WriteLine(codingInSemester);
            Console.WriteLine(percentageOfCodingHours);
        }
    }
}
