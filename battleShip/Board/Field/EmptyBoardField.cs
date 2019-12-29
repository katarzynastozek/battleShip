using System;
using System.Collections.Generic;
using System.Text;

namespace battleShip
{
    public class EmptyBoardField : BoardField
    {

        public EmptyBoardField()
        {
            this.status = Status.EMPTY;
        }

        public override char GetStatus()
        {
            return this.status;
        }

        public override void Shoot()
        {
            status = Status.SHOT_DOWN;
            shotResult = Shot.Result.MISSED;
        }

        public override char GetShipType()
        {
            return Status.EMPTY;
        }
    }
}
