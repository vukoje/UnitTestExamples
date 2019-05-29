using NUnit.Framework;
using UnitTestExamples.Calculation;
using NSubstitute;

namespace UnitTestExamples.Tests.Calculation
{
    public class CalculatorGetPriceTest
    {
        private Calculator Calculator { get; set; }
        public ICalculatorHelper Stub { get; set; }

        [SetUp]
        public void SetUp()
        {
            this.Stub = Substitute.For<ICalculatorHelper>();
            this.Calculator = new Calculator(this.Stub);
        }

        [Test]
        public void ActionPriceTest()
        {
            decimal actionPrice = 100;
            this.Stub.GetPriceOnAction(Arg.Any<int>()).Returns(actionPrice);

            this.TestGetPrice(actionPrice, "If action price exists it Should be used as price.");
        }

        [Test]
        public void VolumeDiscountPriceTest()
        {
            decimal volumePrice = 1;
            this.Stub.GetPriceOnAction(Arg.Any<int>()).Returns((decimal?)null);
            this.Stub.GetPriceWithVolumeDiscount(Arg.Any<int>(), Arg.Any<int>()).Returns(volumePrice);

            this.TestGetPrice(volumePrice, "If volume price exists and action price doesn't, volume price Should be used as price.");
        }

        [Test]
        public void StandardPriceTest()
        {
            decimal standardPrice = 1;
            this.Stub.GetPriceOnAction(Arg.Any<int>()).Returns((decimal?)null);
            this.Stub.GetPriceWithVolumeDiscount(Arg.Any<int>(), Arg.Any<int>()).Returns((decimal?)null);
            this.Stub.GetStandardPrice(Arg.Any<int>()).Returns(standardPrice);

            this.TestGetPrice(standardPrice, "If volume price and action price don't exist, standard price Should be used as price.");
        }

        private void TestGetPrice(decimal expectedPrice, string assertMessage)
        {
            decimal price = this.Calculator.GetPrice(1, 1); // some values
            Assert.AreEqual(expectedPrice, price, assertMessage);
        }
    }
}
