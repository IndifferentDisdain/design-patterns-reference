namespace design_patterns_reference.strategy
{
    public interface IQuackBehavior
    {
        string DoQuack();
    }

    public class Quack : IQuackBehavior
    {
        public string DoQuack()
        {
            return "Quack";
        }
    }

    public class MuteQuack : IQuackBehavior
    {
        public string DoQuack()
        {
            return "<< Silence >>";
        }
    }

    public class Squeak : IQuackBehavior
    {
        public string DoQuack()
        {
            return "Squeak";
        }
    }
}
