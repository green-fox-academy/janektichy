using System;
using Xunit;
using Apples;

namespace TestApple
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Apple apple = new Apple();
            string expected = "apple";


            string actual = apple.GetApple();


            Assert.Equal(expected, actual);
        }
    }
}
