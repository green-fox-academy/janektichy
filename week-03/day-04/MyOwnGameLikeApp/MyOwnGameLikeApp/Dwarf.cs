using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOwnGameLikeApp
{
    class Dwarf : Fighter
    {
        public Dwarf(Gun gun, string name)
        {
            this.type = "Dwarf";
            this.name = name;
            this.gun = gun;
            this.health = 80;
            this.power = 10;
            this.chanceToDodge = 20;
            this.chanceToHit = 90;
        }
    }
}
