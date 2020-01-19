using battleShip;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BoardTest
{
    [TestClass]
    public class BoardTest
    {
        [TestMethod]
        public void CreateBoard()
        {
            Board board = new Board(-1, -3);
            Assert.IsNotNull((object)board);
            Assert.AreEqual(true, board.IsClear);
            Assert.AreEqual(0, board.ShipsOnBoard);
        }
        [TestMethod]
        public void CheckAmountOfShipsOnBoard()
        {
            Board board = new Board(10, 10);
            OneMastShip oneMastShip = new OneMastShip();
            Assert.AreEqual(true, board.IsClear);
            board.LocateShip(oneMastShip);
            Assert.AreEqual(false, board.IsClear);
            board.DecreaseShipsNumber();
            board.PrintShips();
            Assert.IsNotNull(board);
            Assert.AreEqual(0, board.ShipsOnBoard);
        }
        [TestMethod]
        public void CheckBoardFieldStatusEmpty()
        {
            Board board = new Board(1, 1);
            BoardField boardField=board.GetField(0, 0);
            Assert.IsNotNull(boardField);
            Assert.AreEqual('O', boardField.status);
        }

        [TestMethod]
        public void CheckBoardFieldStatusHit()
        {
            Board board = new Board(3, 3);
            BoardField boardField = board.GetField(0,0);
            Assert.IsNotNull(boardField);
            boardField.Shoot();
            Assert.AreEqual('*', boardField.status);            
        }

        [TestMethod]
        public void CheckLocateTwoMastShip()
        {
            Board board = new Board(6,6);
            TwoMastShip twoMastShip = new TwoMastShip();
            OneMastShip oneMastShip = new OneMastShip();
            board.LocateShip(twoMastShip);
            board.LocateShip(oneMastShip);
            Assert.AreEqual(2, board.ShipsOnBoard);
        }

    }
}
