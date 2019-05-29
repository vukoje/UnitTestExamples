using NUnit.Framework;
using UnitTestExamples.Basic;

namespace UnitTestExamples.Tests
{
	public class CounterTest2
	{
		private Counter Counter { get; set; }

		[SetUp]
		public void SetUp()
		{
			this.Counter = new Counter(); // Implicit setup
		}

		[TearDown]
		public void TestCleanup()
		{
			this.Counter = null; // cleanup
		}

		[Test]
		public void IncreaseTest()
		{
			// Counter counter = new Counter(); // Inline Setup
			this.Counter.Increase(); // Exercise
			Assert.AreEqual(1, this.Counter.Number, "Number SHOULD be 1 after Increase."); // Verify
		}
	}
}
