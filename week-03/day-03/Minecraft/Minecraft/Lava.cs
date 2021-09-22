using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft
{
    class Lava : Block
    {
        public Lava()
        {
            this.type = "lava";
            this.color = "yellow";
            this.lightTransmission = 170;
            this.canBeCrossed = false;
            this.adjectentBlocks = new List<string>() {"mud", "brick", "glass", "ice", "air", "glowstone" };
            this.transformer = new List<string[]>() {
            new string[] { "mud", "brick" },
            new string[] { "ice", "air" }
            };
        }
        public override void Transform(Block block, Wall wall)
        {
            if (block.type == "mud")
            {
                Block newBlock = new Brick();
                wall.listOfBlocks.Remove(block);
                wall.listOfBlocks.Add(newBlock);
            }
            else
            {
                Block newBlock = new Air();
                wall.listOfBlocks.Remove(block);
                wall.listOfBlocks.Add(newBlock);
            }
            
        }
    }
}
