using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOwnGameLikeApp
{
    class Ork : Fighter 
    {
        public Ork(Gun gun, string name)
        {
            this.type = "Ork";
            this.name = name;
            this.gun = gun;
            this.health = 150;
            this.power = 13;
            this.chanceToDodge = 0;
            this.chanceToHit = 70;
        }
    }
}
