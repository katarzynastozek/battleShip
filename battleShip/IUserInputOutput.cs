namespace BattleShip
{
    interface IUserInputOutput
    {
        int GetBoardRowsSize();

        int GetBoardColumnsSize();

        int GetOneMastShipsAmount();

        int GetTwoMastShipsAmount();

        int GetThreeMastShipsAmount();

        int GetShotRow();

        int GetShotColumn();

        void PrintShotResult(Shot.Result ShotResult);

        void PrintNumberOfShipsOnBoard(int ShipsOnBoard);

        void PrintBoardStatus(Board board);

        void PrintStatistics(Statistics statistics);
    }
}
