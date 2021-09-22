using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft
{
    class Ice : Block
    {
        public Ice()
        {
            this.type = "ice";
            this.color = "transparent";
            this.lightTransmission = 97;
            this.canBeCrossed = false;
            this.adjectentBlocks = new List<string>() {"mud", "brick", "glass", "lava", "air", "glowstone"};
            this.transformer = new List<string[]>() {
            new string[] { "lava", "glass" }
            };
        }
        public override void Transform(Block block, Wall wall)
        {
            Block newBlock = new Glass();
            wall.listOfBlocks.Remove(block);
            wall.listOfBlocks.Add(newBlock);   
        }
    }
}
