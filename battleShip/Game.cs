using System.Collections.Generic;

namespace BattleShip
{
    public class Game
    {
        private readonly IUserInputOutput _userInterface;
        private readonly Board _board;
        private readonly List<Ship> _fleet;
        private readonly Statistics _statistics;

        public Game()
        {
            _userInterface = new UserConsoleInputOutput();
            _statistics = new Statistics();

            _board = CreateBoard();
            _fleet = CreateFleet();

            LocateShipsOnBoard();
        }

        public void Play()
        {
            do
            {
                ShotConfig shotConfig = ConfigureShot();
                Shot.Result shotResult = Shoot(shotConfig);

                _userInterface.PrintShotResult(shotResult);
                _userInterface.PrintNumberOfShipsOnBoard(_board.ShipsOnBoard);
                _userInterface.PrintBoardStatus(_board);

            } while (!_board.IsClear);
        }

        public void ShowStatistics()
        {
            _userInterface.PrintStatistics(_statistics);
        }

        private Board CreateBoard()
        {
            BoardConfig boardConfig = new BoardConfig();
            boardConfig.RowsNumber = _userInterface.GetBoardRowsSize();
            boardConfig.ColumnsNumber = _userInterface.GetBoardColumnsSize();

            return new Board(boardConfig);
        }

        private List<Ship> CreateFleet()
        {
            FleetConfig fleetConfig = new FleetConfig();
            fleetConfig.OneMastShipCount = _userInterface.GetOneMastShipsAmount();
            fleetConfig.TwoMastShipCount = _userInterface.GetTwoMastShipsAmount();
            fleetConfig.ThreeMastShipCount = _userInterface.GetThreeMastShipsAmount();

            ShipsFactory shipFactory = new ShipsFactory();

            return shipFactory.GetFleet(fleetConfig);
        }

        private void LocateShipsOnBoard()
        {
            foreach (Ship ship in _fleet)
            {
                _board.LocateShip(ship);
            }
        }

        private Shot.Result Shoot(ShotConfig shotConfig)
        {
            BoardField targetField = _board.GetField(shotConfig.RowNumber, shotConfig.ColumnNumber);
            Shot.Result shotResult = targetField.Shoot();

            if (shotResult == Shot.Result.Destroyed) _board.DecreaseShipsNumber();

            _statistics.IncreaseShots();
            if (shotResult != Shot.Result.Missed) _statistics.IncreaseShotsOnTarget();

            return shotResult;
        }

        private ShotConfig ConfigureShot()
        {
            ShotConfig shotConfig = new ShotConfig();
            shotConfig.RowNumber = _userInterface.GetShotRow();
            shotConfig.ColumnNumber = _userInterface.GetShotColumn();

            return shotConfig;
        }
    }
}
