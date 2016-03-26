using Microsoft.VisualStudio.TestTools.UnitTesting;
using design_patterns_reference.strategy;

namespace design_patterns_reference.tests.strategy
{
    [TestClass]
    public class DuckTests
    {
        [TestMethod]
        public void MallardDuck_ShouldQuackAndFly()
        {
            var mallard = new MallardDuck();
            var quackResult = mallard.Quack();
            var flyResult = mallard.Fly();

            Assert.AreEqual("Quack", quackResult);
            Assert.AreEqual("I'm flying!!", flyResult);
        }

        [TestMethod]
        public void ModelDuck_ShouldQuackNoFly()
        {
            var modelDuck = new ModelDuck();
            var quackResult = modelDuck.Quack();
            var flyResult = modelDuck.Fly();

            Assert.AreEqual("Quack", quackResult);
            Assert.AreEqual("I can't fly", flyResult);

            modelDuck.FlyBehavior = new FlyRocketPowered();
            var newFlyResult = modelDuck.Fly();

            Assert.AreEqual("I'm flying with a rocket!", newFlyResult);
        }
    }
}
