using Microsoft.VisualStudio.TestTools.UnitTesting;
using design_patterns_reference.decorator;

namespace design_patterns_reference.tests.decorator
{
    [TestClass]
    public class BeverageTests
    {
        [TestMethod]
        public void BeverageCostWithDecorators_ShouldBeSumOfBeverageAndCondimentCost()
        {
            BeverageBase beverage = new Espresso();
            Assert.AreEqual(1.99m, beverage.Cost);

            BeverageBase beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Assert.AreEqual(1.49m, beverage2.Cost);

            BeverageBase beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Assert.AreEqual(1.34m, beverage3.Cost);
        }
    }
}
