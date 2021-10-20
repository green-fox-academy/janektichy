using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstASPNetApp.Models
{
    public class Greeting
    {
        public long ID { get; set; }
        public static long IDsave { get; set; }
        public string Content { get; set; }
        public Greeting()
        {
            IDsave++;
            ID = IDsave;
        }
    }
}
