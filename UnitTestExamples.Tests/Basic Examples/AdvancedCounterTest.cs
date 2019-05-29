using System;
using NUnit.Framework;

namespace UnitTestExamples.Tests
{
	public class AdvancedCounterTest
	{
		[Test]
		public void EqualsTest()
		{
			AdvancedCounter counter1 = new AdvancedCounter();
			AdvancedCounter counter2 = new AdvancedCounter();
			Assert.AreEqual(counter1, counter2, "AdvancedCounter with same Number Should be equal.");
		}

        [Test]
        public void EqualsForNumberDifferentThanZeroTest()
		{
			AdvancedCounter counter1 = new AdvancedCounter();
			AdvancedCounter counter2 = new AdvancedCounter();

			counter1.Increase();
			counter2.Increase();

			Assert.AreEqual(counter1, counter2, "AdvancedCounter with same Number Should be equal.");
		}

        [Test]
        public void EqualsForDifferentNumberTsest()
		{
			AdvancedCounter counter1 = new AdvancedCounter();
			AdvancedCounter counter2 = new AdvancedCounter();

			counter1.Increase();

			Assert.AreNotEqual(counter1, counter2, "AdvancedCounter with different Number Should NOT be equal.");
		}

        [Test]
        public void NumberChangedTest()
		{
			bool eventRaised = false;
			AdvancedCounter counter = new AdvancedCounter();
			counter.NumberChanged += delegate { eventRaised = true; };

			counter.Increase();

			Assert.IsTrue(eventRaised, "NumberChanged Should be raised on Increase.");
		}

        [Test]
        public void DecreaseWhenNumberIsZeroTest()
		{
			AdvancedCounter counter = new AdvancedCounter();
			bool hasFailed = false;
            try
            {
                counter.Decrease();
            }
            catch(InvalidOperationException)
            {
                hasFailed = true;
            }

			Assert.IsTrue(hasFailed, "Decrease Should throw InvalidOperationException when Number iz zero.");
		}

        [Test]
		public void DecreaseWhenNumberIsZero2Test()
		{
			AdvancedCounter counter = new AdvancedCounter();
            Assert.Throws<InvalidOperationException>(() => counter.Decrease(), "Decrease Should throw InvalidOperationException when Number iz zero.");
			
		}
	}
}
