using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    abstract class StringedInstrument : Instrument
    {
        protected int numberOfStrings;

        protected abstract void Sound();

    }
}
