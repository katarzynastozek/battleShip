using System;

namespace BattleShip
{
    public class Board
    {
        public bool IsClear { get { return shipsOnBoard == 0; } }
        public int ShipsOnBoard { get { return shipsOnBoard; } }
        public BoardField[,] BoardFields { get { return _board; } }

        private readonly BoardField[,] _board;
        private int shipsOnBoard = 0;

        public Board(BoardConfig boardConfiguration)
        {
            
            try
            {
                if (boardConfiguration.RowsNumber > 0 && boardConfiguration.ColumnsNumber > 0)
                {
                    this._board = new BoardField[boardConfiguration.RowsNumber, boardConfiguration.ColumnsNumber];
                    Initialize();
                }                   
            }
            catch (ArgumentException e)
            {

                Console.WriteLine(e);
            }
        }

        private void Initialize()
        {
            for (int row = 0; row < _board.GetLength(0); row++)
            {
                for (int column = 0; column < _board.GetLength(1); column++)
                {
                    this._board[row, column] = new EmptyBoardField();
                }
            }
        }

        public BoardField GetField(int _row, int _column)
        {
              return _board[_row, _column];
        }

        public void LocateShip(Ship @Ship)
        {
            Location location = new Location(_board, @Ship);
            location.Create();
            InsertShip(location, @Ship);
        }

        public void DecreaseShipsNumber()
        {
            shipsOnBoard--;
        }

        private void InsertShip(Location ShipLocation, Ship @Ship)
        {
            for (int row = ShipLocation.OrgRow; row < ShipLocation.EndRow; row++)
            {
                for (int column = ShipLocation.OrgColumn; column < ShipLocation.EndColumn; column++)
                {
                    _board[row, column] = new ShipBoardField(@Ship);
                }
            }

            shipsOnBoard++;
        }
    }
}
