namespace BattleShip
{
    public class Statistics
    {
        public int Shots { get { return shots; } }
        public int ShotsOnTarget { get { return shotsOnTarget; } }
        public int ShotsMissed { get { return shots - shotsOnTarget; } }
        public float Score { get { return (float)shotsOnTarget * 100 / shots; } }

        private int shots = 0;
        private int shotsOnTarget = 0;

        public void NewShot(bool _onTarget)
        {
            shots++;
            if (_onTarget) shotsOnTarget++;
        }
    }
}
