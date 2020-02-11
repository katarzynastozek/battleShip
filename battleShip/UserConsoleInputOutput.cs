using System;
using System.Collections.Generic;

namespace BattleShip
{
    public class UserConsoleInputOutput : IUserInputOutput
    {
        private Dictionary<BoardField.State, char> _fieldStatus;
        private Dictionary<Ship.State, char> _shipStatus;
        private Dictionary<Shot.Result, string> _shotResult;

        public UserConsoleInputOutput()
        {
            CreateFieldStatusDictionary();
            CreateShipStatusDictionary();
            CreateShotResultDictionary();
        }

        public int GetBoardRowsSize()
        {
            Console.WriteLine("Podaj ilość wierszy");
            return Convert.ToInt32(Console.ReadLine());
        }

        public int GetBoardColumnsSize()
        {
            Console.WriteLine("Podaj ilość kolumn");
            return Convert.ToInt32(Console.ReadLine());
        }

        public int GetOneMastShipsAmount()
        {
            Console.WriteLine("Podaj ilość statków jednomasztowych");
            return Convert.ToInt32(Console.ReadLine());
        }

        public int GetTwoMastShipsAmount()
        {
            Console.WriteLine("Podaj ilość statków dwumasztowych");
            return Convert.ToInt32(Console.ReadLine());
        }

        public int GetThreeMastShipsAmount()
        {
            Console.WriteLine("Podaj ilość statków trójmasztowych");
            return Convert.ToInt32(Console.ReadLine());
        }

        public int GetShotRow()
        {
            Console.WriteLine("Podaj wiersz");
            int rowDecision = Convert.ToInt32(Console.ReadLine());
            return ConvertOnBoardScale(rowDecision);
        }

        public int GetShotColumn()
        {
            Console.WriteLine("Podaj kolumnę");
            int columnDecision = Convert.ToInt32(Console.ReadLine());
            return ConvertOnBoardScale(columnDecision);
        }

        public void PrintShotResult(Shot.Result ShotResult)
        {
            Console.Clear();
            Console.WriteLine(_shotResult[ShotResult]);
        }

        public void PrintNumberOfShipsOnBoard(int ShipsOnBoard)
        {
            Console.WriteLine(string.Format("Ilość pozostałych statków: {0}", ShipsOnBoard));
        }

        public void PrintBoardStatus(Board board)
        {
            Console.WriteLine("");

            BoardField boardField;
            int lastRowNumber = board.RowsCount;
            int lastColumnNumber = board.ColumnsCount - 1;

            for (int row = 0; row < lastRowNumber; row++)
            {
                for (int column = 0; column < lastColumnNumber; column++)
                {
                    boardField = board.GetField(row, column);
                    Console.Write(" " + GetFieldStatus(boardField));
                }

                boardField = board.GetField(row, lastColumnNumber);
                Console.WriteLine(" " + GetFieldStatus(boardField));
            }

            Console.WriteLine("");
        }

        public void PrintStatistics(Statistics statistics)
        {
            Console.WriteLine("----- STATYSTYKI GRY -----");
            Console.WriteLine(string.Format("Ilość strzałów: {0}", statistics.Shots));
            Console.WriteLine(string.Format("Ilość celnych strzałów: {0}", statistics.ShotsOnTarget));
            Console.WriteLine(string.Format("Ilość nie trafionych strzałów: {0}", statistics.ShotsMissed));
            Console.WriteLine(string.Format("Skuteczność: {0}%", statistics.Score));
            Console.ReadLine();
        }

        private char GetFieldStatus(BoardField boardField)
        {
            if (boardField.HasShip)
            {
                if (boardField.Status == BoardField.State.ShotDown)
                {
                    return _shipStatus[boardField.GetShip().Status];
                }
                else
                {
                    return _fieldStatus[boardField.Status];
                }
            }
            else
            {
                return _fieldStatus[boardField.Status];
            }
        }

        private void CreateFieldStatusDictionary()
        {
            _fieldStatus = new Dictionary<BoardField.State, char>();
            _fieldStatus.Add(BoardField.State.Fine, 'O');
            _fieldStatus.Add(BoardField.State.ShotDown, '*');
        }

        private void CreateShipStatusDictionary()
        {
            _shipStatus = new Dictionary<Ship.State, char>();
            _shipStatus.Add(Ship.State.Undamaged, ' ');
            _shipStatus.Add(Ship.State.Damaged, '/');
            _shipStatus.Add(Ship.State.Destroyed, 'X');
        }

        private void CreateShotResultDictionary()
        {
            _shotResult = new Dictionary<Shot.Result, string>();
            _shotResult.Add(Shot.Result.Missed, "Pudło");
            _shotResult.Add(Shot.Result.Damaged, "Trafiony");
            _shotResult.Add(Shot.Result.Destroyed, "Zatopiony");
        }

        private int ConvertOnBoardScale(int Coord)
        {
            return --Coord;
        }
    }
}
