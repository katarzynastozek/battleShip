namespace BattleShip
{
    public class ShipBoardField : BoardField
    {
        private readonly Ship ship;

        public ShipBoardField(Ship _ship)
        {
            this.ship = _ship;
        }

        public override char GetShipType()
        {
            return this.ship.Type;
        }

        public override char GetStatus()
        {
            return (this.status == Status.SHOT_DOWN) ? this.ship.State : Status.EMPTY;
        }

        public override void Shoot()
        {
            if (this.status != Status.SHOT_DOWN)
            {
                this.status = Status.SHOT_DOWN;

                this.ship.Damage();

                if(this.ship.Lives > 0)
                {
                    shotResult = Shot.Result.DAMAGED;
                }
                else
                {
                    shotResult = Shot.Result.DESTROYED;
                }
            }
            else
            {
                shotResult = Shot.Result.MISSED;
            }
        }
    }
}
