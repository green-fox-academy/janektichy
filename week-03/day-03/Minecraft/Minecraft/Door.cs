using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft
{
    class Door : Block
    {
        protected int _quality;
        public string producerName;
        public Door(int quality, string producerName, string color, double lightTransmission, bool canBeCrossed)
        {
            this.type = "door";
            this.quality = quality;
            this.producerName = producerName;
            this.color = color;
            this.lightTransmission = lightTransmission;
            this.canBeCrossed = canBeCrossed;
            this.adjectentBlocks = new List<string>() { "mud", "brick", "air", "window" };
        }
        public int quality
        {
            get { return _quality; }
            set
            {
                if (value != 1 && value != 2 && value != 3)
                {
                    _quality = 3;
                }
            }
        }
        public override void PrintStatus()
        {
            base.PrintStatus();
            Console.WriteLine($"Manufactured by: {this.producerName} on quality level: {this._quality}");
        }
    }
}
