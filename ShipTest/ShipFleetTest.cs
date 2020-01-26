using BattleShip;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ShipTest
{
    [TestClass]
    public class ShipFleetTest
    {
        [TestMethod]
        public void CheckCreateFleepZeroShip()
        {
            ShipsFactory shipsFactory = new ShipsFactory();
            FleetConfig fleetConfig = new FleetConfig();
            List<Ship> shipsList;
            shipsList = shipsFactory.GetFleet(fleetConfig);
            Assert.AreEqual(0,shipsList.Count);
        }

        [TestMethod]
        public void CheckCreateFleepShip()
        {
            ShipsFactory shipsFactory = new ShipsFactory();
            FleetConfig fleetConfig = new FleetConfig();
            List<Ship> shipsList;
            fleetConfig.OneMastShipCount = 4;
            fleetConfig.TwoMastShipCount = 3;
            fleetConfig.ThreeMastShipCount = 2;
            shipsList=shipsFactory.GetFleet(fleetConfig);
            Assert.AreEqual(9, shipsList.Count);
        }
    }
}
