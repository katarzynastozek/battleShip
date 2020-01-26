using System;

namespace BattleShip
{
    public class Location
    {
        public int OrgRow { get { return _orgRow; } }
        public int OrgColumn { get { return _orgColumn; } }
        public int EndRow { get { return _endRow; } }
        public int EndColumn { get { return _endColumn; } }

        private int _orgRow, _orgColumn, _endRow, _endColumn;

        private readonly BoardField[,] _board;
        private readonly Ship _ship;

        public Location(BoardField[,] @Board, Ship @Ship)
        {
            this._board = @Board;
            this._ship = @Ship;
        }

        public void Create()
        {
            bool horizontal;
            bool rangeIsEmpty = false;
            
            Random random = new Random();

            while (!rangeIsEmpty)
            {
                //Random orientation of ship.
                horizontal = ((random.Next(0, 10) % 2) == 0);

                //Random origin of ship.
                _orgRow = random.Next(0, _board.GetLength(0) - 1);
                _orgColumn = random.Next(0, _board.GetLength(1) - 1);

                //Calculate end of ship.
                _endRow = horizontal ? _orgRow + _ship.Lives : _orgRow + 1;
                _endColumn = horizontal ? _orgColumn + 1 : _orgColumn + _ship.Lives;

                //Check if ship fits to board.
                if ((horizontal && _endRow < _board.GetLength(0)) || //fits in horizontal
                    (!horizontal && _endColumn < _board.GetLength(1))) //fits in vertical
                {
                    //Check if board has enough empty fields.
                    rangeIsEmpty = CheckRange(_board);
                }
            }
        }

        private bool CheckRange(BoardField[,] board)
        {
            bool result = true;

            for (int row = _orgRow - 1; row <= _endRow; row++)
            {
                //Check minimum & maximum of rows
                if (row < 0 || row >= board.GetLength(0)) continue;

                for (int column = _orgColumn - 1; column <= _endColumn; column++)
                {
                    //Check minimum & maximum of columns
                    if (column < 0 || column >= board.GetLength(1)) continue;

                    //Check if space is empty
                    if (board[row, column].GetStatus() != EmptyBoardField.Status.EMPTY)
                    {
                        result = false;
                        break;
                    }
                }
            }

            return result;
        }

    }
}
