namespace Cars4Us.Services.Pricing
{
    public abstract class PriceDecorator : IPriceComponent
    {
        protected readonly IPriceComponent _component;

        protected PriceDecorator(IPriceComponent component)
        {
            _component = component;
        }

        public virtual decimal GetPrice() => _component.GetPrice();

        public virtual string GetBreakdown() => _component.GetBreakdown();
    }
}
