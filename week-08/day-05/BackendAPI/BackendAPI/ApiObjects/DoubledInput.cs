using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendAPI.ApiObjects
{
    public class DoubledInput
    {
        public int Received { get; set; }
        public int Result { get; set; }
        public string Error { get; set; }

        public DoubledInput(int recieved)
        {
            Received = recieved;
            Result = recieved * 2;
        }
    }
}
