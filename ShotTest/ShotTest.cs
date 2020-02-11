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
            Assert.AreEqual(Shot.Result.Damaged, shipBoardField.Shoot());
        }
        [TestMethod]
        public void ResultOfHitTwoMastShip()
        {
            TwoMastShip twoMastShip = new TwoMastShip();
            ShipBoardField shipBoardField = new ShipBoardField(twoMastShip);
            Assert.AreEqual(Shot.Result.Damaged, shipBoardField.Shoot());
        }
        [TestMethod]
        public void ResultOfHitOneMastShip()
        {
            OneMastShip oneMastShip = new OneMastShip();
            ShipBoardField shipBoardField = new ShipBoardField(oneMastShip);
            Assert.AreEqual(Shot.Result.Destroyed, shipBoardField.Shoot());
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
            Assert.AreEqual(Shot.Result.Missed, boardField.Shoot());
        }
    }
}