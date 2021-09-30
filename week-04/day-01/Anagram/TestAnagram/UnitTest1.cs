using System;
using Xunit;
using Anagram;

namespace TestAnagram
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            AnagramFinder anagram = new AnagramFinder();
            bool isAnagram = anagram.IsAnagram("perko", "kproe");

            Assert.True(isAnagram);
        }
    }
}
