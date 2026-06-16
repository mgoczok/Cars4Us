using System.Collections.Generic;

namespace Cars4Us.Services.Pricing
{
    public class PricingPipelineService
    {
        private readonly FinancingStrategyFactory _financingFactory;

        public PricingPipelineService()
        {
            _financingFactory = new FinancingStrategyFactory();
        }

        public PricingResult Calculate(
            decimal basePrice,
            IEnumerable<decimal> optionPrices,
            bool applyFleetDiscount,
            bool applySeasonalPromotion,
            FinancingType financingType)
        {
            // 1. Zbudowanie pipeline'u Dekoratorów z wyciąganiem poszczególnych różnic
            IPriceComponent pipeline = new BaseCarPriceComponent(basePrice);
            decimal costBasePrice = pipeline.GetPrice();

            pipeline = new AdditionalOptionsDecorator(pipeline, optionPrices);
            decimal costWithOptions = pipeline.GetPrice();
            decimal optionsCost = costWithOptions - costBasePrice;

            pipeline = new SalonMarginDecorator(pipeline);
            decimal costWithMargin = pipeline.GetPrice();
            decimal marginCost = costWithMargin - costWithOptions;

            decimal beforeFleet = pipeline.GetPrice();
            if (applyFleetDiscount)
            {
                pipeline = new FleetDiscountDecorator(pipeline);
            }
            decimal fleetDiscountAmount = beforeFleet - pipeline.GetPrice();

            decimal beforeSeasonal = pipeline.GetPrice();
            if (applySeasonalPromotion)
            {
                pipeline = new SeasonalPromotionDecorator(pipeline);
            }
            decimal seasonalDiscountAmount = beforeSeasonal - pipeline.GetPrice();

            // Podsumowanie warstwy dekoratora (ostateczna cena "fizyczna" samochodu po rabatach)
            decimal decoratedFinalCarPrice = pipeline.GetPrice();
            string breakdown = pipeline.GetBreakdown();

            // 2. Strategia Finansowania (korzysta z ostatecznej ceny ustalonej przez dekoratory)
            IFinancingStrategy financingStrategy = _financingFactory.CreateStrategy(financingType);
            FinancingCalculationResult financingResult = financingStrategy.Calculate(decoratedFinalCarPrice);

            // Dodanie informacji ze strategii finansowania do rozbicia
            if (financingResult.FinancingCost > 0)
                breakdown += $"Koszt finansowania ({financingType}): +{financingResult.FinancingCost:C}\n";

            if (financingResult.InsuranceCost > 0)
                breakdown += $"Koszt ubezpieczenia: +{financingResult.InsuranceCost:C}\n";

            // Końcowe podsumowanie i utworzenie pakietu PricingResult
            decimal finalPrice = decoratedFinalCarPrice + financingResult.FinancingCost + financingResult.InsuranceCost;
            breakdown += $"----------------------------------\n";
            breakdown += $"Cena końcowa brutto: {finalPrice:C}";

            return new PricingResult
            {
                BasePrice = basePrice,
                OptionsCost = optionsCost,
                MarginCost = marginCost,
                FleetDiscountAmount = fleetDiscountAmount,
                SeasonalDiscountAmount = seasonalDiscountAmount,
                FinancingCost = financingResult.FinancingCost,
                InsuranceCost = financingResult.InsuranceCost,
                FinalPrice = finalPrice,
                FinancingType = financingType,
                Breakdown = breakdown
            };
        }
    }
}
