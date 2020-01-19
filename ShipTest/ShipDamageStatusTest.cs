using battleShip;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShipTest
{
    [TestClass]
    public class ShipDamageStatusTest
    {
        [TestMethod]
        public void CheckDamageStatusOfOneMastShip()
        {
            OneMastShip oneMastShip = new OneMastShip();
            (oneMastShip).Damage();
            Assert.AreEqual(0, (oneMastShip).Lives);
            Assert.AreEqual('X', (oneMastShip).State);
        }

        [TestMethod]
        public void CheckDamageStatusOfTwoMastShip()
        {
            TwoMastShip twoMastShip = new TwoMastShip();
            (twoMastShip).Damage();
            Assert.AreEqual(1, (twoMastShip).Lives);
            Assert.AreEqual('/', (twoMastShip).State);
        }

        [TestMethod]
        public void CheckDamageStatusOfThreeMastShip()
        {
            ThreeMastShip threeMastShip = new ThreeMastShip();
            (threeMastShip).Damage();
            Assert.AreEqual(2, (threeMastShip).Lives);
            Assert.AreEqual('/', (threeMastShip).State);
        }
    }
}
