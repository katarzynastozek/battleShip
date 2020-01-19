using battleShip;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShipTest
{
    [TestClass]
    public class CreateShipTest
    {
        [TestMethod]
        public void CheckIfOneMastShipIsCreatedCorrectly()
        {
            OneMastShip oneMastShip = new OneMastShip();
            Assert.IsNotNull(oneMastShip);
            Assert.AreEqual(1, (oneMastShip).Lives);
            Assert.AreEqual(' ',(oneMastShip).State);
        }

        [TestMethod]
        public void CheckIfTwoMastShipIsCreatedCorrectly()
        {
            TwoMastShip twoMastShip = new TwoMastShip();
            Assert.IsNotNull(twoMastShip);
            Assert.AreEqual(2, (twoMastShip).Lives);
            Assert.AreEqual(' ', (twoMastShip).State);
        }

        [TestMethod]
        public void CheckIfThreeMastShipIsCreatedCorrectly()
        {
            ThreeMastShip threeMastShip = new ThreeMastShip();
            Assert.IsNotNull(threeMastShip);
            Assert.AreEqual(3, (threeMastShip).Lives);
            Assert.AreEqual(' ', (threeMastShip).State);
        }
    }
}
