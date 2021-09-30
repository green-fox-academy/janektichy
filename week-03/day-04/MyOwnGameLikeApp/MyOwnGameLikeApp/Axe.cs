using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOwnGameLikeApp
{
    class Axe : Gun 
    {

        public Axe()
        {
            this.type = "Axe";
            this.dodgeDowngrade = 5;
            this.hitUpgrade = 15;
            this.powerIncrease = 1;
        }
    }
}
