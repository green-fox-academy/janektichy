using System;
using System.Collections.Generic;
using Xunit;
using CountLetters;

namespace TestCount
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Dictionary<char, int> input = new Dictionary<char, int>();
            input.Add('j', 2);
            input.Add('a', 2);
            input.Add('k', 1);
            input.Add('o', 3);
            input.Add('b', 1);
            input.Add('r', 1);
            input.Add('c', 1);
            input.Add('h', 1);
            input.Add(' ', 2);

            Count test = new Count();

            Dictionary<char, int> actual = test.CountLetters("jako jo bracho");

            Assert.Equal(input, actual);
        }
    }
}
