using SumMain;
using System;
using System.Collections.Generic;
using Xunit;


namespace Sum
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            MyClass prd = new MyClass();
            List<int> input = new List<int>() { 2, 3, 5, 8, 15, 18, 70, 90, 20, 1 };
            int expected = 2 + 3 + 5 + 8 + 15 + 18 + 70 + 90 + 20 + 1;

            int actual = MyClass.GetSum(input);

            Assert.Equal(expected, actual);
        }
    }
}
