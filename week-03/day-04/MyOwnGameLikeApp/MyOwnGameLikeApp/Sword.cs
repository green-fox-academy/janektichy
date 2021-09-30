using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOwnGameLikeApp
{
    class Sword : Gun
    {
        public Sword()
        {
            this.type = "Sword";
            this.powerIncrease = 0;
            this.hitUpgrade = 0;
            this.dodgeDowngrade = 0;
        }
    }
}
