using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft
{
    class Block
    {
        protected string color;
        protected double lightTransmission;
        protected bool canBeCrossed;
        protected List<string> adjectentBlocks;
        public string type;
        public List<string[]> transformer = new List<string[]>();

        
        public bool CanPlaceAfter(Block toBePlacedAfterBlock)
        {
            foreach (string type in this.adjectentBlocks)
            {
                if (this.adjectentBlocks.Contains(toBePlacedAfterBlock.type))
                {
                    return true;
                }
            }
            return false;
        }
        public double GetTransmission()
        {
            return this.lightTransmission;
        }
        public virtual void PrintStatus()
        {
            Console.WriteLine($"Block of type: {this.type}");
            Console.WriteLine($"Has light transmission: {this.lightTransmission} %");
            this.Crossed();
        }
        public void Crossed()
        {
            if (this.canBeCrossed)
            {
                Console.WriteLine("Can be crossed");
            }
            else
            {
                Console.WriteLine("Can not be crossed");
            }
        }
        public virtual void Transform(Block block, Wall wall)
        {

        }
    }
}
