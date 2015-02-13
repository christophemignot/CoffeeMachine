namespace CoffeeMachineTest
{
    using CoffeeMachine;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class OrderDetailTest
    {
        [TestMethod]
        public void WhenTeaWithSugarThenT10()
        {
            var order = new OrderDetail
            {
                Kind = DrinkKind.Tea,
                SugarCount = 1
            };

            Assert.AreEqual("T:1:0", order.ToString());
        }

        [TestMethod]
        public void WhenChocolateThenH()
        {
            var order = new OrderDetail
            {
                Kind = DrinkKind.Chocolate,
                SugarCount = 0
            };

            Assert.AreEqual("H::", order.ToString());
        }

        [TestMethod]
        public void WhenCoffeeAndTwoSugarThenC20()
        {
            var order = new OrderDetail
            {
                Kind = DrinkKind.Coffee,
                SugarCount = 2
            };

            Assert.AreEqual("C:2:0", order.ToString());
        }

    }

}
