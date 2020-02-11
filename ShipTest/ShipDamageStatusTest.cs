using BattleShip;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShipTest
{
    [TestClass]
    public class ShipDamageStatusTest
    {
        [TestMethod]
        public void CheckStatusOfNoDamageShip()
        {
            ThreeMastShip threeMastShip = new ThreeMastShip();
            Assert.AreEqual(Ship.State.Undamaged, (threeMastShip).Status);
        }

        [TestMethod]
        public void CheckDamageStateOfOneMastShip()
        {
            OneMastShip oneMastShip = new OneMastShip();
            (oneMastShip).Damage();
            Assert.AreEqual(Ship.State.Destroyed, (oneMastShip).Status);
        }

        [TestMethod]
        public void CheckDamageStateOfTwoMastShip()
        {
            TwoMastShip twoMastShip = new TwoMastShip();
            (twoMastShip).Damage();
            Assert.AreEqual(Ship.State.Damaged, (twoMastShip).Status);
        }

        [TestMethod]
        public void CheckDamageStateOfThreeMastShip()
        {
            ThreeMastShip threeMastShip = new ThreeMastShip();
            (threeMastShip).Damage();
            Assert.AreEqual(Ship.State.Damaged, (threeMastShip).Status);
        }

        [TestMethod]
        public void CheckLivesAfterDamageOfOneMastShip()
        {
            OneMastShip oneMastShip = new OneMastShip();
            (oneMastShip).Damage();
            Assert.AreEqual(0, (oneMastShip).Lives);
        }

        [TestMethod]
        public void CheckLivesAfterDamageOfTwoMastShip()
        {
            TwoMastShip twoMastShip = new TwoMastShip();
            (twoMastShip).Damage();
            Assert.AreEqual(1, (twoMastShip).Lives);
        }

        [TestMethod]
        public void CheckLivesAfterDamageOfThreeMastShip()
        {
            ThreeMastShip threeMastShip = new ThreeMastShip();
            (threeMastShip).Damage();
            Assert.AreEqual(2, (threeMastShip).Lives);
        }
    }
}
