using System;
using System.Collections.Generic;
using System.Text;

namespace battleShip
{
    public abstract class Ship
    {
        public static class Status
        {
            public const char UNDAMAGED = ' ';
            public const char DAMAGED = '/';
            public const char DESTROYED = 'X';
        }

        public int Lives { get { return lives; } }
        public char State { get { return status; } }

        protected int lives;
        protected char status;

        public void Damage()
        {       
            if (lives > 0) DecreaseLive();
            UpdateStatus();
        }

        private void UpdateStatus()
        {
            if (lives > 0)
            {
                status = Ship.Status.DAMAGED;
            }
            else
            {
                status = Ship.Status.DESTROYED;
            }
        }

        private void DecreaseLive()
        {
            this.lives--;
        }

    }
}
