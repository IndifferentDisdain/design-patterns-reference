namespace design_patterns_reference.strategy
{
    public abstract class Duck
    {
        private IFlyBehavior _flyBehavior { get; set; }

        private IQuackBehavior _quackBehavior { get; set; }

        protected Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
        {
            _flyBehavior = flyBehavior;
            _quackBehavior = quackBehavior;
        }

        public string Quack()
        {
            return _quackBehavior.DoQuack();
        }

        public string Fly()
        {
            return _flyBehavior.DoFly();
        }

        // Note: I think I like this better than having a public property
        // This way, you can just implement this method in the base class
        // if and when you need the functionality. Plus, this adds better encapsulation.
        public void SetNewFlyBehavior(IFlyBehavior behavior)
        {
            _flyBehavior = behavior;
        }

        public void SetNewQuackBehavior(IQuackBehavior behavior)
        {
            _quackBehavior = behavior;
        }
    }

    public class MallardDuck : Duck
    {
        public MallardDuck() : base(new FlyWithWings(), new Quack()) { }        
    }

    public class ModelDuck : Duck
    {
        public ModelDuck() : base(new FlyNoWay(), new Quack()) { }
    }
}
