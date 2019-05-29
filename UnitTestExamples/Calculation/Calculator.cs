using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTestExamples.Calculation
{
    public class Calculator
    {
        public ICalculatorHelper Helper { get; set; }

        public Calculator()
            : this(new CalculatorHelper())
        {
        }

        public Calculator(ICalculatorHelper helper)
        {
            this.Helper = helper;
        }

        public decimal GetPrice(int productId, int quantity)
        {
            // if price on action exists
            // it is used
            decimal? priceOnAction = this.Helper.GetPriceOnAction(productId);
            if (priceOnAction.HasValue)
            {
                return priceOnAction.Value;
            }

            // if price on action doesn't exist
            // and price with volume discount exists
            // it is used
            decimal? priceWithVolumeDiscount = this.Helper.GetPriceWithVolumeDiscount(productId, quantity);
            if (priceWithVolumeDiscount.HasValue)
            {
                return priceWithVolumeDiscount.Value;
            }

            // if price on action and 
            // price with volume discount don't exist
            // return standard price
            return this.Helper.GetStandardPrice(productId);
        }
    }
}
