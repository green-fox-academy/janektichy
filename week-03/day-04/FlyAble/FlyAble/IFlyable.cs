using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyAble
{
    interface IFlyable
    {
        public void Land();

        public void TakeOff();

        public void Fly();
    }
}
