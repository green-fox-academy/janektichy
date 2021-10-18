using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swCharacters
{
    class Character
    {
        public string Name { get; set; }
        public double Height { get; set; }
        public double Mass { get; set; }
        public string HairColor { get; set; }
        public string SkinColor { get; set; }
        public string EyeColor { get; set; }
        public double BirthYear { get; set; }
        public string Gender { get; set; }
        protected string input;
        public Character(string input)
        {
            this.input = input;
            FillInfo();
        }
        public Character FillInfo()
        {
            string[] info = input.Split(';');
            this.Name = info[0];
            if (double.TryParse(info[1], out double result))
            {
                this.Height = result;
            }
            else
            {
                this.Height = 0;
            }
            if (double.TryParse(info[2], out double result2))
            {
                this.Mass = result2;
            }
            else
            {
                this.Mass = 0;
            }
            this.HairColor = info[3];
            this.SkinColor = info[4];
            this.EyeColor = info[5];
            info[6] = info[6].Replace('B', '0');
            info[6] = info[6].Replace('Y', '0');
            if (double.TryParse(info[6], out double result3))
            {
                this.BirthYear = result3/1000;
            }
            else
            {
                this.BirthYear = 0;
            }
            if (info[7] == "female" || info[7] == "male")
            {
                this.Gender = info[7];
            }
            else
            {
                this.Gender = "unknown";
            }
            return this;
        }
    }
}
