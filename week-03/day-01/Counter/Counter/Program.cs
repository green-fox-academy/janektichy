using System;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter tryOut = new Counter(5);

            tryOut.Add(5);
            tryOut.Get();
            tryOut.Add(15);
            tryOut.Get();
            tryOut.Reset();
            tryOut.Get();
        }
    }
}
