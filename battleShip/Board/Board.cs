using System;
using System.Collections.Generic;
using System.Text;

namespace battleShip
{
    public class Board
    {
        public bool IsClear { get { return shipsOnBoard == 0; } }
        public int ShipsOnBoard { get { return shipsOnBoard; } }

        private BoardField[,] board;
        private int shipsOnBoard = 0;

        public Board(int _rowQty, int _columnQty)
        {
            this.board = new BoardField[_rowQty, _columnQty];

            //Initialize board.
            for (int row = 0; row < _rowQty; row++)
            {
                for (int column = 0; column < _columnQty; column++)
                {
                    this.board[row, column] = new EmptyBoardField();
                }
            }
        }

        public BoardField GetField(int _row, int _column)
        {
            return board[_row, _column];
        }

        public void LocateShip(Ship _ship)
        {
            bool located = false;
            bool horizontal;
            bool rangeIsEmpty = false;
            int orgRow, orgColumn, endRow, endColumn;
            Random random = new Random();

            while (!located)
            {
                //Random orientation of ship.
                horizontal = ((random.Next(0, 10) % 2) == 0);

                //Random origin of ship.
                orgRow = random.Next(0, this.board.GetLength(0) - 1);
                orgColumn = random.Next(0, this.board.GetLength(1) - 1);

                //Calculate end of ship.
                endRow = horizontal ? orgRow + _ship.Lives : orgRow + 1;
                endColumn = horizontal ? orgColumn + 1 : orgColumn + _ship.Lives;

                //Check if ship fits to board.
                if ((horizontal && endRow < this.board.GetLength(0)) || //fits in horizontal
                    (!horizontal && endColumn < this.board.GetLength(1))) //fits in vertical
                {
                    //Check if board has enough empty fields.
                    rangeIsEmpty = CheckRange(orgRow, endRow, orgColumn, endColumn);
                    if (rangeIsEmpty)
                    {
                        InsertShip(orgRow, endRow, orgColumn, endColumn, _ship);
                        located = true;
                    }
                }
            }
        }

        public void DecreaseShipsNumber()
        {
            shipsOnBoard--;
        }

        public void PrintShips()
        {
            Console.WriteLine("");

            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int column = 0; column < board.GetLength(1); column++)
                {
                    if (column + 1 < board.GetLength(1))
                    {
                        Console.Write(board[row, column].GetShipType());
                    }
                    else
                    {
                        Console.WriteLine(board[row, column].GetShipType());
                    }

                }
            }

            Console.WriteLine("");
        }

        public void PrintShots()
        {
            Console.WriteLine("");

            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int column = 0; column < board.GetLength(1); column++)
                {
                    if (column + 1 < board.GetLength(1))
                    {
                        Console.Write(" " + board[row, column].GetStatus());
                    }
                    else
                    {
                        Console.WriteLine(" " + board[row, column].GetStatus());
                    }
                }
            }

            Console.WriteLine("");
        }

        private bool CheckRange(int _orgRow, int _endRow, int _orgColumn, int _endColumn)
        {
            bool result = true;

            for (int row = _orgRow - 1; row <= _endRow; row++)
            {
                //Check minimum & maximum of rows
                if (row < 0 || row >= this.board.GetLength(0)) continue;

                for (int column = _orgColumn - 1; column <= _endColumn; column++)
                {
                    //Check minimum & maximum of columns
                    if (column < 0 || column >= this.board.GetLength(1)) continue;

                    //Check if space is empty
                    if (this.board[row, column].GetType() != typeof(EmptyBoardField))
                    {
                        result = false;
                        break;
                    }
                }
            }

            return result;
        }

        private void InsertShip(int orgRow, int endRow, int orgColumn, int endColumn, Ship _ship)
        {
            for (int row = orgRow; row < endRow; row++)
            {
                for (int column = orgColumn; column < endColumn; column++)
                {
                    board[row, column] = new ShipBoardField(_ship);
                }
            }

            shipsOnBoard++;
        }
    }
}
