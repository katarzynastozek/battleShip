using battleShip;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ShipBoardFieldTest
{
    [TestClass]
    public class ShipBoardFieldTest
    {
        [TestMethod]
        public void CheckShipTypeOneMastShip()
        {
            OneMastShip oneMastShip = new OneMastShip();
            ShipBoardField shipBoardField;
            char shipType;
            shipBoardField = new ShipBoardField(oneMastShip);
            shipType = shipBoardField.GetShipType();
            Assert.AreEqual('1', shipType);
        }
        [TestMethod]
        public void CheckShipTypeTwoMastShip()
        {
            TwoMastShip twoMastShip = new TwoMastShip();
            ShipBoardField shipBoardField;
            char shipType;
            shipBoardField = new ShipBoardField(twoMastShip);
            shipType = shipBoardField.GetShipType();
            Assert.AreEqual('2', shipType);
        }
        [TestMethod]
        public void CheckShipTypeThreeMastShip()
        {
            ThreeMastShip threeMastShip=new ThreeMastShip();
            ShipBoardField shipBoardField;
            char shipType;
            shipBoardField = new ShipBoardField(threeMastShip);
            shipType = shipBoardField.GetShipType();
            Assert.AreEqual('3', shipType);
        }
        [TestMethod]
        public void CheckShipTypeNullShip()
        {
            ShipBoardField shipBoardField = new ShipBoardField(null);
            char shipType;
            shipType = shipBoardField.GetShipType();
            Assert.AreEqual('?', shipType);
        }
    }
}
