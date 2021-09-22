using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft
{
    class Wall
    {
        public List<Block> listOfBlocks;

        public Wall()
        {
            this.listOfBlocks = new List<Block>(); 
        }
        public void AddFirstBlock(Block block)
        {
            this.listOfBlocks.Add(block);
        }
        public void AddBlock(Block blockToAdd)
        {
            Block lastBlockInWall = this.listOfBlocks[this.listOfBlocks.Count - 1];
            if (blockToAdd.CanPlaceAfter(lastBlockInWall))
            {
                foreach (var type in blockToAdd.transformer)
                {
                    if (lastBlockInWall.type == type[0])
                    {
                        blockToAdd.Transform(lastBlockInWall, this);
                    }
                }
                this.listOfBlocks.Add(blockToAdd);
            }
        }
        public void PrintWallStatus()
        {
            foreach (var block in this.listOfBlocks)
            {
                block.PrintStatus();
                Console.WriteLine();
            }
        }
        public void CountWallLight()
        {
            double sum = 0;
            double count = 0;
            foreach (var block in this.listOfBlocks)
            {
                sum += block.GetTransmission();
                ++count;
            }
            Console.WriteLine("Light transmitted: " + (sum / count));
        }
    }
}
