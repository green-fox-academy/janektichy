using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft
{
    class Glowstone : Block
    {
        public Glowstone()
        {
            this.lightTransmission = 300;
            this.type = "glowstone";
            this.color = "white";
            this.canBeCrossed = false;
            this.adjectentBlocks = new List<string>() { "ice", "glass", "air", "lava" };
            this.transformer = new List<string[]>() {
            new string[] { "glass", "gold" } 
            };
        }
        public override void Transform(Block block, Wall wall)
        {
            Block newBlock = new Gold(160);
            wall.listOfBlocks.Remove(block);
            wall.listOfBlocks.Add(newBlock);
        }
    }
}
