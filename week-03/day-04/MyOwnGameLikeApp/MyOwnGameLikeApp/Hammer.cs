using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOwnGameLikeApp
{
    class Hammer : Gun
    {
        public Hammer()
        {
            this.type = "Hammer";
            this.dodgeDowngrade = 15;
            this.hitUpgrade = 5;
            this.powerIncrease = 3;
        }
    }
}
