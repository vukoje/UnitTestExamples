using NUnit.Framework;

namespace UnitTestExamples.Tests
{    
	public class CalculatorTest
	{
		[Test]
		public void SumTest()
		{
			int result = Calculator.Sum(1, 2);
			Assert.AreEqual(3, result, "Sum of 1 and 2 SHOULD be 3.");
		}
	}
}
