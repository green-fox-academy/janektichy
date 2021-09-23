using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations
{
    class Reservation : IReservationy
    {
        protected string[] dow;
        protected char[] code;

        public Reservation()
        {
            this.dow = new string[] { "MON", "TUE", "WED", "THU", "FRI", "SAT", "SUN" };
            this.code = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        }
        public string GetCodeBooking()
        {
            char[] generatedCode = new char[8];
            Random random = new Random();
            for (int i = 0; i < 8; i++)
            {
                generatedCode[i] = code[random.Next(0, this.code.Length)];
            }
            string codeToString = new string(generatedCode);
            return codeToString;
        }

        public string GetDowBooking()
        {
            Random random = new Random();
            return this.dow[random.Next(1, 7)];
        }
    }
}
