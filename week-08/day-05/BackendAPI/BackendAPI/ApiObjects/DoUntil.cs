using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendAPI.ApiObjects
{
    public class DoUntil
    {
        public int Until { get; set; }
        public int result { get; set; }
        public string Error { get; set; }
        public int SumUntil(int until)
        {
            int result = 0;
            for (int i = until; i > 0; i--)
            {
                result += i;
            }
            return result;
        }
        public int MultiplyUntil(int until)
        {
            int result = until;
            for (int i = until-1; i > 0; i--)
            {
                result *= i;
            }
            return result;
        }
    }
}
