namespace Cars4Us.Services.Pricing
{
    public class FleetDiscountDecorator : PriceDecorator
    {
        public FleetDiscountDecorator(IPriceComponent component) : base(component) { }

        public override decimal GetPrice()
        {
            return base.GetPrice() * 0.95m; // -5%
        }

        public override string GetBreakdown()
        {
            decimal discount = base.GetPrice() * 0.05m;
            return base.GetBreakdown() + $"Rabat flotowy (5%): -{discount:C}\n";
        }
    }
}
