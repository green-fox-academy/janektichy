using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftCarrier
{
    class F16 : Aircraft
    {
        public F16() : base()
        {
            this.baseDamage = 30;
            this.maxAmmo = 8;
            this.type = "F16";
        }
    }
}
