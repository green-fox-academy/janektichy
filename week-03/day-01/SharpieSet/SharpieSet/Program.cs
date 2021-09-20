using System;
using System.Collections.Generic;

namespace SharpieSet
{
    class Program
    {
        static void Main(string[] args)
        {
            var sharpie1 = new Sharpie("Yellow", 30, 50);
            var sharpie2 = new Sharpie("Yellow", 60, 60);
            var sharpie3 = new Sharpie("Yellow", 70, 0);
            var sharpie4 = new Sharpie("Brown", 50, 50);
            var sharpies = new SharpieSet();
            sharpies.AddSharpie(sharpie1);
            sharpies.AddSharpie(sharpie2);
            sharpies.AddSharpie(sharpie3);
            sharpies.AddSharpie(sharpie4);

            sharpies.CountUsable();
            sharpies.RemoveTrash();
            sharpies.ShowSharpies();
        }
    }
}
