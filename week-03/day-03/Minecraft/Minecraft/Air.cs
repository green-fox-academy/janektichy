using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft
{
    class Air : Block
    {
        public Air()
        {
            this.type = "air";
            this.color = "transparent";
            this.lightTransmission = 100;
            this.canBeCrossed = true;
            this.adjectentBlocks = new List<string>() { "mud", "brick", "glass", "door", "window", "gold" };
        }
    }
}
