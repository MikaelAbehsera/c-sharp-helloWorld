namespace Solution
{
	using NUnit.Framework;
	using System;

	[TestFixture]
	public class SolutionTest
	{
		[Test]
		public void MyTest()
		{
			Assert.AreEqual(8, Program.findSum(5));
			Assert.AreEqual(33, Program.findSum(10));
		}
	}
}