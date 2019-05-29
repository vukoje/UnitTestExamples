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

        [Test]
        public void GuardAssertExampleTest()
        {
            this.Counter.Decrease(); // Setup

            // guard assert 1
            if (this.Counter.Number != -1)
            {
                Assert.Inconclusive("Guard Asser: Number should be -1 insted of {0}", this.Counter.Number);
            }

            this.Counter.Decrease(); // Exercise
            Assert.AreEqual(-2, this.Counter.Number, "Number SHOULD be -2 after Decrease on Number -1."); // Verify
        }
    }
}
