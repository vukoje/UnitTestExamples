
namespace UnitTestExamples
{
    public interface ICalculatorHelper
    {
        decimal? GetPriceOnAction(int productId);
        decimal? GetPriceWithVolumeDiscount(int productId, int quantity);
        decimal GetStandardPrice(int productId);
    }
}
