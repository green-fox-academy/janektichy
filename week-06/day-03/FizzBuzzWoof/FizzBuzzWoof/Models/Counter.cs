using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzWoof.Models
{
    public class Counter
    {
        public string Count { get; set; }
        public static int StaticCount { get; set; }

        public int WordsPrinted { get; set; }
        public string FontSize { get; set; }
        public Counter()
        {
            StaticCount++;
            Count = PickResult();
        }
    
        public string PickResult()
        {
            WordsPrinted = 0;
            StringBuilder sb = new StringBuilder();
            if (StaticCount % 3 == 0 || StaticCount % 5 == 0 || StaticCount % 7 == 0)
            {
                if (StaticCount % 3 == 0)
                {
                    sb.Append("Fizz");
                    ++WordsPrinted;
                }
                if (StaticCount % 5 == 0)
                {
                    sb.Append("Buzz");
                    ++WordsPrinted;
                }
                if (StaticCount % 7 == 0)
                {
                    sb.Append("Woof");
                    ++WordsPrinted;
                }
            }
            else
            {
                FontSize = "12px";
                return StaticCount.ToString();
            }
            int size = WordsPrinted * 24;
            FontSize = $"{size}px";
            string result = sb.ToString();
            return result;
        }
    }
}
