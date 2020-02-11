namespace BattleShip
{
    public abstract class Ship
    {
        public enum State
        {
            Undamaged,
            Damaged,
            Destroyed
        }

        public int Lives { get { return _lives; } }
        public State Status { get { return _status; } }

        protected int _lives;
        protected State _status;

        public void Damage()
        {
            if (_lives > 0) DecreaseLive();
            UpdateStatus();
        }

        private void UpdateStatus()
        {
            _status = _lives > 0 ? _status = Ship.State.Damaged : _status = Ship.State.Destroyed;
        }

        private void DecreaseLive()
        {
            this._lives--;
        }
    }
}
