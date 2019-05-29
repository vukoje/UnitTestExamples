using NUnit.Framework;

namespace UnitTestExamples.Tests
{
	public class CounterTest
	{
		[Test]
		public void ConstructorTest()
		{
			Counter counter = new Counter(); // Setup & Exercise
			Assert.AreEqual(0, counter.Number, "Number SHOULD be 0 after class createion."); // Verify
		}

        [Test]
        public void IncreaseTest()
		{
			Counter counter = new Counter(); // Setup
			counter.Increase(); // Exercise
			Assert.AreEqual(1, counter.Number, "Number SHOULD be 1 after Increase."); // Verify
		}

        [Test]
        public void DecreaseTest()
		{
			Counter counter = new Counter(); // Setup
			counter.Decrease(); // Exercise
			Assert.AreEqual(-1, counter.Number, "Number SHOULD be -1 after Decrease."); // Verify
		}

        [Test]
        public void ResetTest()
		{
			Counter counter = new Counter(); // Setup
			counter.Increase(); // Setup!!!
			counter.Reset(); // Exercise
			Assert.AreEqual(0, counter.Number, "Number SHOULD be 0 after Reset."); // Verify
		}
	}
}
