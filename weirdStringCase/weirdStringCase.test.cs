namespace Solution
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class Tests
    {
        [Test]
        public static void ShouldWorkForSomeExamples()
        {
            Assert.AreEqual("ThIs", Kata.ToWeirdCase("This"));
            Assert.AreEqual("Is", Kata.ToWeirdCase("is"));
            Assert.AreEqual("ThIs Is A TeSt", Kata.ToWeirdCase("This is a test"));
        }
    }
}