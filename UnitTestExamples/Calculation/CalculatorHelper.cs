
namespace UnitTestExamples.Calculation
{
    public class CalculatorHelper : ICalculatorHelper
    {
        public decimal? GetPriceOnAction(int productId)
        {
            // price on action caclulation

            return 5;
        }

        public decimal? GetPriceWithVolumeDiscount(int productId, int quantity)
        {
            // price with volume discount calculation

            return 3;
        }

        public decimal GetStandardPrice(int productId)
        {
            // standard price calculation

            return 10;
        }
    }
}
