namespace p03.ShoppingCart_After
{
    using System.Collections.Generic;
    using System.Linq;

    using Contracts;
    using Rules;

    public class PricingCalculator : IPricingCalculator
    {
        private readonly List<IPriceRule> pricingRules;

        public PricingCalculator()
        {
            this.pricingRules = new List<IPriceRule>()
            {
                new EachPriceRule(),
                new PerGramPriceRule(),
                new SpecialPriceRule(),
                new BuyFourGetOneFree(),
            };
        }

        public decimal CalculatePrice(OrderItem item)
        {
            return this.pricingRules
                .First(r => r.IsMatch(item))
                .CalculatePrice(item);
        }
    }
}
