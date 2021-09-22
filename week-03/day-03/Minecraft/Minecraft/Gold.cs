using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft
{
    class Gold : Block
    {
        public Gold(int lightTransmission)
        {
            this.type = "gold";
            this.color = "rgb: 255,215,0";
            this.lightTransmission = lightTransmission;
            this.canBeCrossed = false;
            this.adjectentBlocks = new List<string>() { "glowstone", "glass"};
        }
    }
}
