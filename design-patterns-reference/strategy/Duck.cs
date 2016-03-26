namespace design_patterns_reference.strategy
{
    public abstract class Duck
    {
        public IFlyBehavior FlyBehavior { get; set; }

        public IQuackBehavior QuackBehavior { get; set; }

        public string Quack()
        {
            return QuackBehavior.DoQuack();
        }

        public void Display()
        {
            
        }

        public string Fly()
        {
            return FlyBehavior.DoFly();
        }
    }

    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            QuackBehavior = new Quack();
            FlyBehavior = new FlyWithWings();
        }
    }

    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new Quack();
        }
    }
}
