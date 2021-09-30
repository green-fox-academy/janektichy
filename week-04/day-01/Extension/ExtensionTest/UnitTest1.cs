using Xunit;
using System.Collections.Generic;

namespace Extension
{
    public class ExtensionTests
    {
        Extension extension = new Extension();

        [Fact]
        public void TestAdd_2and4is5()
        {
            Assert.Equal(5, extension.Add(2, 3));
        }

        [Fact]
        public void TestAdd_1and5is5()
        {
            Assert.Equal(5, extension.Add(1, 4));
        }

        [Fact]
        public void TestMaxOfThree_First()
        {
            Assert.Equal(5, extension.MaxOfThree(4, 5, 3));
        }

        [Fact]
        public void TestMaxOfThree_Fhird()
        {
            Assert.Equal(5, extension.MaxOfThree(4, 5, 3));
        }

        [Fact]
        public void TestMedian_Four()
        {
            Assert.Equal(4, extension.Median(new List<int>() { 7, 4, 5, 7 }));
        }

        [Fact]
        public void TestMedian_Five()
        {
            Assert.Equal(4, extension.Median(new List<int>() { 1, 2, 4, 5, 6 }));
        }

        [Fact]
        public void TestIsVowel_a()
        {
            Assert.True(extension.IsVowel('y'));
        }

        [Fact]
        public void TestIsVowel_u()
        {
            Assert.True(extension.IsVowel('y'));
        }

        [Fact]
        public void testTranslate_bemutatkozik()
        {
            Assert.Equal("bevemuvutavatkovozivik", extension.Translate("bemutatkozik"));
        }

        [Fact]
        public void testTranslate_kolbice()
        {
            Assert.Equal("lavagovopuvus", extension.Translate("lagopus"));
        }
    }
}