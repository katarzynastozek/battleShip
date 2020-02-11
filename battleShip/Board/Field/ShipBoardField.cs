namespace BattleShip
{
    public class ShipBoardField : BoardField
    {
        public Ship.State ShipStatus { get { return this._ship.Status; } }
        private readonly Ship _ship;

        public ShipBoardField(Ship Ship)
        {
            this._hasShip = true;
            this._status = State.Fine;
            this._ship = Ship;
        }

        public override Ship GetShip()
        {
            return this._ship;
        }

        public override Shot.Result Shoot()
        {
            if (this._status != State.ShotDown)
            {
                this._status = State.ShotDown;
                this._ship.Damage();

                if (this._ship.Lives > 0)
                {
                    return Shot.Result.Damaged;
                }
                else
                {
                    return Shot.Result.Destroyed;
                }
            }
            else
            {
                return Shot.Result.Missed;
            }
        }
    }
}
