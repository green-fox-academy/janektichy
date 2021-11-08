using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendAPI.ApiObjects
{
    public class NumbersCount
    {
        public string What { get; set; }
        public int[] Numbers { get; set; }
        public int result { get; set; }
        public string Error { get; set; }
        public int Sum(int[] arr)
        {
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
            }
            return result;
        }
        public int Multiply(int[] arr)
        {
            int result = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                result *= arr[i];
            }
            return result;
        }
        public int[] GetDoubled(int[] arr)
        {
            
            int[] result = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = arr[i] * 2;
            }
            return result;
        }
    }
}
