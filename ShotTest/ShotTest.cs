using BattleShip;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShotTest
{
    [TestClass]
    public class ShotTest
    {
        [TestMethod]
        public void ResultOfHitThreeMastShip()
        {
            ThreeMastShip threeMastShip = new ThreeMastShip();
            ShipBoardField shipBoardField = new ShipBoardField(threeMastShip);
            string shotResult;
            shipBoardField.Shoot();
            shotResult = shipBoardField.ShotResult;
            Assert.AreEqual("Trafiony", shotResult);
        }
        [TestMethod]
        public void ResultOfHitTwoMastShip()
        {
            TwoMastShip twoMastShip = new TwoMastShip();
            ShipBoardField shipBoardField = new ShipBoardField(twoMastShip);
            string shotResult;
            shipBoardField.Shoot();
            shotResult = shipBoardField.ShotResult;
            Assert.AreEqual("Trafiony", shotResult);
        }
        [TestMethod]
        public void ResultOfHitOneMastShip()
        {
            OneMastShip oneMastShip = new OneMastShip();
            ShipBoardField shipBoardField = new ShipBoardField(oneMastShip);
            string shotResult;
            shipBoardField.Shoot();
            shotResult = shipBoardField.ShotResult;
            Assert.AreEqual("Zatopiony", shotResult);
        }

        [TestMethod]
        public void ResultOfHitNullShip()
        {
            BoardConfig boardConfig = new BoardConfig
            {
                RowsNumber = 3,
                ColumnsNumber = 3
            };
            Board board = new Board(boardConfig);
            BoardField boardField = board.GetField(0, 0);
            boardField.Shoot();
            Assert.AreEqual("Pud³o", boardField.ShotResult);
        }
    }
}