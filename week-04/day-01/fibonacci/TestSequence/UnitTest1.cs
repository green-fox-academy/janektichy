using System;
using Xunit;
using fibonacci;

namespace TestSequence
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            MyClass test = new MyClass();
            int expected = 13;

            int actual = test.Fibonacci(8);

            Assert.Equal(expected, actual);
        }
    }
}
