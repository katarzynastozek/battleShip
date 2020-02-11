namespace BattleShip
{
    public class EmptyBoardField : BoardField
    {
        public EmptyBoardField()
        {
            this._hasShip = false;
            this._status = State.Fine;
        }

        public override Ship GetShip()
        {
            Ship ship = null;
            return ship;
        }

        public override Shot.Result Shoot()
        {
            _status = State.ShotDown;
            return Shot.Result.Missed;
        }
    }
}
