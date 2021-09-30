using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOwnGameLikeApp
{
    class Elf : Fighter
    {
        public Elf (Gun gun, string name)
        {
            this.type = "Elf";
            this.name = name;
            this.gun = gun;
            this.health = 100;
            this.power = 7;
            this.chanceToDodge = 40;
            this.chanceToHit = 80;
        }
    }
}
