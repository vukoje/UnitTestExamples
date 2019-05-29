using NUnit.Framework;
using UnitTestExamples.Basic;

namespace UnitTestExamples.Tests.GuardAssert
{
    public class CounterTest
    {
        [Test]
        public void DecreaseTest()
        {
            Counter counter = new Counter(); // Setup
            counter.Decrease(); // Setup
            
            // guard assert 1
            if (counter.Number != -1)
            {
                Assert.Inconclusive("Guard Asser: Number should be -1 insted of {0}", counter.Number);
            }

            // guard assert 2
            //Assert.AreEqual(-1, 0, "Gurad assert.");

            counter.Decrease(); // Exercise
            Assert.AreEqual(-2, counter.Number, "Number SHOULD be -2 after Decrease on Number -1."); // Verify
        }
    }
}
