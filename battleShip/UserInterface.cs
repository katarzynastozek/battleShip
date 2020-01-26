using System;

namespace BattleShip
{
    public class UserInterface
    {
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

        public void PrintShotResult(string ShotResult)
        {
            Console.Clear();
            Console.WriteLine(ShotResult);
            
        }

        public void PrintNumberOfShipsOnBoard(int ShipsOnBoard)
        {
            Console.WriteLine(string.Format("Ilość pozostałych statków: {0}", ShipsOnBoard));
        }

        public void PrintShots(BoardField[,] board)
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

        public void PrintStatistics(Statistics statistics)
        {
            Console.WriteLine("----- STATYSTYKI GRY -----");
            Console.WriteLine(string.Format("Ilość strzałów: {0}", statistics.Shots));
            Console.WriteLine(string.Format("Ilość celnych strzałów: {0}", statistics.ShotsOnTarget));
            Console.WriteLine(string.Format("Ilość nie trafionych strzałów: {0}", statistics.ShotsMissed));
            Console.WriteLine(string.Format("Skuteczność: {0}%", statistics.Score));
            Console.ReadLine();
        }

        private int ConvertOnBoardScale(int Coord)
        {
            return --Coord;
        }

    }
}
