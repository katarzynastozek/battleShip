using System;
using System.Collections.Generic;

namespace battleShip
{
    class Game
    {
        private static int oneMastShipQty, twoMastShipQty, threeMastShipQty;
        private static int rowsQty, columnsQty;
        private static Board board;
        private static List<Ship> ships;

        static void Main(string[] args)
        {
            Configure();

            if (rowsQty > 0 && columnsQty > 0)
            {
                CreateShips();

                do
                {
                    Shoot();
                } while (!board.IsClear);

                ShowStatistics();
            }
            Console.ReadLine();
        }

        private static void Configure()
        {
            //Configure board size.
            Console.WriteLine("Podaj ilość wierszy");
            rowsQty = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj ilość kolumn");
            columnsQty = Convert.ToInt32(Console.ReadLine());

            board = new Board(rowsQty, columnsQty);
            if (rowsQty > 0 && rowsQty > 0)
            {
                //Configure ship amount.
                Console.WriteLine("Podaj ilość statków jednomasztowych");
                oneMastShipQty = Convert.ToByte(Console.ReadLine());

                Console.WriteLine("Podaj ilość statków dwumasztowych");
                twoMastShipQty = Convert.ToByte(Console.ReadLine());

                Console.WriteLine("Podaj ilość statków trójmasztowych");
                threeMastShipQty = Convert.ToByte(Console.ReadLine());
            }
        }

        private static void CreateShips()
        {
            ships = new List<Ship>();
            for (byte i = 0; i < threeMastShipQty; i++)
            {
                //new ThreeMastShip();
                ships.Add(new ThreeMastShip());
            }
            for (byte i = 0; i < twoMastShipQty; i++)
            {
                //new TwoMastShip();
                ships.Add(new TwoMastShip());
            }
            for (byte i = 0; i < oneMastShipQty; i++)
            {
                //new OneMastShip();
                ships.Add(new OneMastShip());
            }

            //Locate ships on board
            foreach (Ship ship in ships)
            {
                board.LocateShip(ship);
            }
        }

        private static void Shoot()
        {
            Console.WriteLine("Podaj wiersz");
            int row = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj kolumnę");
            int column = Convert.ToInt32(Console.ReadLine());

            BoardField targetField = board.GetField(--row, --column);
            targetField.Shoot();
            if (targetField.ShotResult == Shot.Result.DESTROYED) board.DecreaseShipsNumber();
            Statistics.NewShot(targetField.ShotResult != Shot.Result.MISSED);

            Console.Clear();
            Console.WriteLine(targetField.ShotResult);
            Console.WriteLine(string.Format("Ilość pozostałych statków: {0}", board.ShipsOnBoard));

            board.PrintShots();
        }

        private static void ShowStatistics()
        {
            Console.WriteLine("----- STATYSTYKI GRY -----");
            Console.WriteLine(string.Format("Ilość strzałów: {0}", Statistics.Shots));
            Console.WriteLine(string.Format("Ilość celnych strzałów: {0}", Statistics.ShotsOnTarget));
            Console.WriteLine(string.Format("Ilość nie trafionych strzałów: {0}", Statistics.ShotsMissed));
            Console.WriteLine(string.Format("Skuteczność: {0}%", Statistics.Score));
        }
    }

}


