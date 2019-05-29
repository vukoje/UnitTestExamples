using NUnit.Framework;
using UnitTestExamples.Calculation;

namespace UnitTestExamples.Tests.Calculation
{
    public class CalculatorGetPriceTest
    {
        private Calculator Calculator { get; set; }
        public CalculatorHelperStub Stub { get; set; }

        [SetUp]
        public void TestInitialize()
        {
            this.Stub = new CalculatorHelperStub();
            this.Calculator = new Calculator(this.Stub);
        }

        [Test]
        public void ActionPriceTest()
        {
            decimal actionPrice = 100;
            this.Stub.GetPriceOnActionHandler = x => { return actionPrice; };

            this.TestGetPrice(actionPrice, "If action price exists it Should be used as price.");
        }

        [Test]
        public void VolumeDiscountPriceTest()
        {
            decimal volumePrice = 1;
            this.Stub.GetPriceOnActionHandler = x => { return null; };
            this.Stub.GetPriceWithVolumeDiscountHandler = (x, y) => { return volumePrice; };

            this.TestGetPrice(volumePrice, "If volume price exists and action price doesn't, volume price Should be used as price.");
        }

        [Test]
        public void StandardPriceTest()
        {
            decimal standardPrice = 1;
            this.Stub.GetPriceOnActionHandler = x => { return null; };
            this.Stub.GetPriceWithVolumeDiscountHandler = (x, y) => { return null; };
            this.Stub.GetStandardPriceHandler = x => { return standardPrice; };

            this.TestGetPrice(standardPrice, "If volume price and action price don't exist, standard price Should be used as price.");
        }

        private void TestGetPrice(decimal expectedPrice, string assertMessage)
        {
            decimal price = this.Calculator.GetPrice(1, 1); // some values
            Assert.AreEqual(expectedPrice, price, assertMessage);
        }
    }
}
