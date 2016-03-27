namespace design_patterns_reference.decorator
{
    public abstract class BeverageBase
    {
        public abstract string Description { get; }

        public abstract decimal Cost { get; }
    }

    public class Espresso : BeverageBase
    {
        public override string Description => "Espresso";

        public override decimal Cost => 1.99m;
    }

    public class HouseBlend : BeverageBase
    {
        public override string Description => "House Blend";

        public override decimal Cost => 0.89m;
    }

    public class DarkRoast : BeverageBase
    {
        public override string Description => "Dark Roast";

        public override decimal Cost => 0.99m;
    }

    public class Decaf : BeverageBase
    {
        public override string Description => "Decaf";

        public override decimal Cost => 1.05m;
    }
}
