using System.Collections.Generic;
using System.Linq;

namespace Cars4Us.Services.Pricing
{
    public class AdditionalOptionsDecorator : PriceDecorator
    {
        private readonly decimal _optionsTotal;

        public AdditionalOptionsDecorator(IPriceComponent component, IEnumerable<decimal> optionPrices)
            : base(component)
        {
            _optionsTotal = optionPrices?.Sum() ?? 0m;
        }

        public override decimal GetPrice()
        {
            return base.GetPrice() + _optionsTotal;
        }

        public override string GetBreakdown()
        {
            if (_optionsTotal > 0)
                return base.GetBreakdown() + $"Dodatkowe opcje: +{_optionsTotal:C}\n";
            return base.GetBreakdown();
        }
    }
}
