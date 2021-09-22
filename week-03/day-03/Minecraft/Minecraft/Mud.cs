using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft
{
    class Mud : Block
    {


        public Mud()
        {
            this.type = "mud";
            this.color = "dark gray";
            this.lightTransmission = 0;
            this.canBeCrossed = false;
            this.adjectentBlocks = new List<string>() { "brick", "air", "lava", "door", "window", "gold" };
        }
    }
}
