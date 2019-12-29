using System;
using System.Collections.Generic;
using System.Text;

namespace battleShip
{
    public class ThreeMastShip : Ship
    {
        public ThreeMastShip()
        {
            lives = 3;
            status = Ship.Status.UNDAMAGED;
        }

    }
}
