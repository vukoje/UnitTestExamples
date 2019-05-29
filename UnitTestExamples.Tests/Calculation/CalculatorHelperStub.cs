using System;
using UnitTestExamples.Calculation;

namespace UnitTestExamples.Tests
{
    public class CalculatorHelperStub : ICalculatorHelper
    {
        public Func<int, decimal?> GetPriceOnActionHandler { get; set; }
        public Func<int, int, decimal?> GetPriceWithVolumeDiscountHandler { get; set; }
        public Func<int, decimal> GetStandardPriceHandler { get; set; }

        public decimal? GetPriceOnAction(int productId)
        {
            return this.GetPriceOnActionHandler.Invoke(productId);
        }

        public decimal? GetPriceWithVolumeDiscount(int productId, int quantity)
        {
            return this.GetPriceWithVolumeDiscountHandler.Invoke(productId, quantity);
        }

        public decimal GetStandardPrice(int productId)
        {
            return this.GetStandardPriceHandler(productId);
        }
    }
}
