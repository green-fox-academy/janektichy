using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft
{
    class Brick : Block
    {
        public Brick()
        {
            this.type = "brick";
            this.color = "rgb: 144, 76, 42";
            this.lightTransmission = 0;
            this.canBeCrossed = false;
            this.adjectentBlocks = new List<string>() { "mud", "glass", "air", "door", "window" };
        }
        public Brick(string color)
        {
            this.color = color;
            this.type = "brick";
            this.lightTransmission = 0;
            this.canBeCrossed = false;
            this.adjectentBlocks = new List<string>() { "mud", "glass", "air", "door", "window" };
        }
    }
}
