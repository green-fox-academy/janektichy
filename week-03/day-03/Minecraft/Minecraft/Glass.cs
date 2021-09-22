using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft
{
    class Glass : Block
    {
        public Glass()
        {
            this.type = "glass";
            this.color = "transparent";
            this.canBeCrossed = false;
            this.lightTransmission = 80;
            this.adjectentBlocks = new List<string>() { "mud", "brick", "ice", "air", "glowstone", "door"};
        }
        public string color
        {
            get;
            set;
        }
        public double lightTransmission
        {
            get;
            set;
        }


    }
}
