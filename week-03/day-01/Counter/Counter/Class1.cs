using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class Counter
    {
        public int count = 0;
        public int rememberInputValue;

        public Counter(int count)
        {
            this.count = count;
            this.rememberInputValue = count;
        }
        public void Add(int addNumber)
        {
            count += addNumber;
        }
        public void Add()
        {
            this.count++;
        }
        public void Get()
        {
            Console.WriteLine(this.count);
        }
        public void Reset()
        {
            this.count = this.rememberInputValue;
        }

    }
}
