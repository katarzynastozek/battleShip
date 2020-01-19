using System;
using System.Collections.Generic;
using System.Text;

namespace battleShip
{
    public class ShipBoardField : BoardField
    {
        private Ship ship;

        public ShipBoardField(Ship _ship)
        {
            this.ship = _ship;
        }

        public override char GetShipType()
        {
            try
            {
                if (this.ship.GetType() == typeof(OneMastShip))
                {
                    return '1';
                }
                else if (this.ship.GetType() == typeof(TwoMastShip))
                {
                    return '2';
                }
                else if (this.ship.GetType() == typeof(ThreeMastShip))
                {
                    return '3';
                }
                else
                {
                    return '?';
                }

            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Brak danego typu statku");
                return '?';
            }
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
