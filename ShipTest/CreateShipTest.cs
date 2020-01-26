using BattleShip;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShipTest
{
    [TestClass]
    public class CreateShipTest
    {
        [TestMethod]
        public void CheckTypeOfOneMastShip()
        {
            OneMastShip oneMastShip = new OneMastShip();
            Assert.AreEqual('1',oneMastShip.Type);
        }

        [TestMethod]
        public void CheckTypeOfTwoMastShip()
        {
            TwoMastShip twoMastShip = new TwoMastShip();
            Assert.AreEqual('2', twoMastShip.Type);
        }

        [TestMethod]
        public void CheckTypeOfThreeMastShip()
        {
            ThreeMastShip threeMastShip = new ThreeMastShip();
            Assert.AreEqual('3', threeMastShip.Type);
        }    
    }
}
