namespace Solution
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class TrailingZeros
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(1, Kata.TrailingZeros(5));
            Assert.AreEqual(6, Kata.TrailingZeros(25));
            Assert.AreEqual(131, Kata.TrailingZeros(531));
        }
        [Test]
        public void QuickTest()
        {
            Assert.AreEqual(2, Kata.TrailingZeros(12));
        }
        [Test]
        public void QuickTest1()
        {
            Assert.AreEqual(131, Kata.TrailingZeros(531));
        }
    }
}