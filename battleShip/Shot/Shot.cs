namespace BattleShip
{
    public abstract class Shot
    {
        public static class Result
        {
            public const string MISSED = "Pudło";
            public const string DAMAGED = "Trafiony";
            public const string DESTROYED = "Zatopiony";
        }

        public string ShotResult { get { return shotResult; } }

        protected string shotResult;

        public abstract void Shoot();
    }
}
