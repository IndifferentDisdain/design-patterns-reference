namespace design_patterns_reference.strategy
{
    public interface IFlyBehavior
    {
        string DoFly();
    }

    public class FlyWithWings : IFlyBehavior
    {
        public string DoFly()
        {
            return "I'm flying!!";
        }
    }

    public class FlyNoWay : IFlyBehavior
    {
        public string DoFly()
        {
            return "I can't fly";
        }
    }

    public class FlyRocketPowered : IFlyBehavior
    {
        public string DoFly()
        {
            return "I'm flying with a rocket!";
        }
    }
}
