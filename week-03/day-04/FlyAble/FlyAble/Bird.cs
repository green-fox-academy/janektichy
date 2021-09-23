using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyAble
{
    class Bird : Animal, IFlyable
    {
        protected bool canFly;

        public Bird(string name)
        {
            this.canFly = true;
            this.name = name;
        }

        public override void Greet()
        {
            throw new NotImplementedException();
        }

        public override string Sound()
        {
            throw new NotImplementedException();
        }

        public override void WantChild()
        {
            Console.Write("wants child from an egg");
            Console.WriteLine();
        }
        public override void GetName()
        {
            Console.Write(this.name);
        }

        public void Land()
        {
            throw new NotImplementedException();
        }

        public void TakeOff()
        {
            throw new NotImplementedException();
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }
    }
}
