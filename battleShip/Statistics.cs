namespace BattleShip
{
    public class Statistics
    {
        public int Shots { get { return _shots; } }
        public int ShotsOnTarget { get { return _shotsOnTarget; } }
        public int ShotsMissed { get { return _shots - _shotsOnTarget; } }
        public float Score { get { return (float)_shotsOnTarget * 100 / _shots; } }

        private int _shots = 0;
        private int _shotsOnTarget = 0;

        public void IncreaseShotsOnTarget()
        {
            _shotsOnTarget++;
        }

        public void IncreaseShots()
        {
            _shots++;
        }
    }
}
