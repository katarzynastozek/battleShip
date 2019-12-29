using System;
using System.Collections.Generic;
using System.Text;

namespace battleShip
{
    public class TwoMastShip : Ship
    {
        public TwoMastShip()
        {
            lives = 2;
            status = Ship.Status.UNDAMAGED;
        }
    }
}
