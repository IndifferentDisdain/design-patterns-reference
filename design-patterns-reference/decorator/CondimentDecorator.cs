namespace design_patterns_reference.decorator
{
    public abstract class CondimentDecorator : BeverageBase
    {
        //public abstract string Description { get; set; }
    }

    public class Mocha : CondimentDecorator
    {
        private readonly BeverageBase _beverage;

        public Mocha(BeverageBase beverage)
        {
            _beverage = beverage;
        }

        public override string Description => $"{_beverage.Description}, Mocha";

        public override decimal Cost => _beverage.Cost + 0.20m;
    }

    public class SteamedMilk : CondimentDecorator
    {
        private readonly BeverageBase _beverage;

        public SteamedMilk(BeverageBase beverage)
        {
            _beverage = beverage;
        }

        public override string Description => $"{_beverage.Description}, Steamed Milk";

        public override decimal Cost => _beverage.Cost + 0.10m;
    }

    public class Soy : CondimentDecorator
    {
        private readonly BeverageBase _beverage;

        public Soy(BeverageBase beverage)
        {
            _beverage = beverage;
        }

        public override string Description => $"{_beverage.Description}, Soy";

        public override decimal Cost => _beverage.Cost + 0.15m;
    }

    public class Whip : CondimentDecorator
    {
        private readonly BeverageBase _beverage;

        public Whip(BeverageBase beverage)
        {
            _beverage = beverage;
        }

        public override string Description => $"{_beverage.Description}, Whip";

        public override decimal Cost => _beverage.Cost + 0.10m;
    }
}
