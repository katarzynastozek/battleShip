namespace BattleShip
{
    public abstract class BoardField : Shot
    {
        public enum State
        {
            Fine,
            ShotDown
        }

        public bool HasShip { get { return _hasShip; } }
        public State Status { get { return _status; } }

        protected State _status;
        protected bool _hasShip;

        public abstract Ship GetShip();
    }
}
