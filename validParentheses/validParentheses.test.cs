namespace Solution
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void SampleTest1()
        {
            Assert.AreEqual(true, Parentheses.ValidParentheses("()"));
        }

        [Test]
        public void SampleTest2()
        {
            Assert.AreEqual(false, Parentheses.ValidParentheses(")(((("));
        }
    }
}