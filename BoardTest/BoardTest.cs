using BattleShip;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BoardTest
{
    [TestClass]
    public class BoardTest
    {
        [TestMethod]
        public void CreateBoard()
        {
            BoardConfig boardConfig = new BoardConfig
            {
                RowsNumber = -1,
                ColumnsNumber = -3
            };
            Board board = new Board(boardConfig);
            Assert.AreEqual(0, board.ShipsOnBoard);
        }
        [TestMethod]
        public void CheckAmountOfShipsOnBoard()
        {
            BoardConfig boardConfig = new BoardConfig
            {
                RowsNumber = 10,
                ColumnsNumber = 10
            };
            Board board = new Board(boardConfig);
            OneMastShip oneMastShip = new OneMastShip();
            board.LocateShip(oneMastShip);
            board.DecreaseShipsNumber();
            Assert.AreEqual(0, board.ShipsOnBoard);
        }
        [TestMethod]
        public void CheckBoardFieldStatusEmpty()
        {
            BoardConfig boardConfig = new BoardConfig
            {
                RowsNumber = 1,
                ColumnsNumber = 1
            };
            Board board = new Board(boardConfig);
            BoardField boardField = board.GetField(0, 0);
            Assert.AreEqual('O', boardField.status);
        }

        [TestMethod]
        public void CheckBoardFieldStatusHit()
        {
            BoardConfig boardConfig = new BoardConfig
            {
                RowsNumber = 3,
                ColumnsNumber = 3
            };
            Board board = new Board(boardConfig);
            BoardField boardField = board.GetField(0, 0);
            boardField.Shoot();
            Assert.AreEqual('*', boardField.status);
        }

        [TestMethod]
        public void CheckLocateTwoMastShip()
        {
            BoardConfig boardConfig = new BoardConfig
            {
                RowsNumber = 6,
                ColumnsNumber = 6
            };
            Board board = new Board(boardConfig);
            TwoMastShip twoMastShip = new TwoMastShip();
            OneMastShip oneMastShip = new OneMastShip();
            board.LocateShip(twoMastShip);
            board.LocateShip(oneMastShip);
            Assert.AreEqual(2, board.ShipsOnBoard);
        }

        [TestMethod]
        public void CheckClearBoard()
        {
            BoardConfig boardConfig = new BoardConfig
            {
                RowsNumber = 1,
                ColumnsNumber = 3
            };
            Board board = new Board(boardConfig);
            Assert.AreEqual(true, board.IsClear);
        }

        [TestMethod]
        public void CheckNotClearBoard()
        {
            BoardConfig boardConfig = new BoardConfig
            {
                RowsNumber = 1,
                ColumnsNumber = 3
            };
            Board board = new Board(boardConfig);
            OneMastShip oneMastShip = new OneMastShip();
            board.LocateShip(oneMastShip);
            Assert.AreEqual(false, board.IsClear);
        }


    }
}
