using System;
using Xunit;
using Animal;

namespace AnimalTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Animals animal = new Animals("horse");
            int expected = 49;

            animal.Eat();
            int actual = animal.hunger;

            Assert.Equal(actual, expected);

        }
        [Fact]
        public void Test2()
        {
            Animals animal = new Animals("horse");
            int expected = 49;

            animal.Drink();
            int actual = animal.thirst;

            Assert.Equal(actual, expected);

        }
        [Fact]
        public void Test3()
        {
            Animals animal = new Animals("horse");
            int expected = 51;

            animal.Play();
            int actual = animal.hunger;
            int actual2 = animal.thirst;

            Assert.Equal(actual, expected);
            Assert.Equal(actual2, expected);

        }
    }
}
