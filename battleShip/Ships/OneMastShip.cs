using System;
using System.Collections.Generic;
using System.Text;

namespace battleShip
{
    public class OneMastShip : Ship
    {
        public OneMastShip()
        {
            lives = 1;
            status = Ship.Status.UNDAMAGED;
        }
    }
}
