namespace BattleShip
{
    public abstract class Shot
    {
        public enum Result
        {
            Missed,
            Damaged,
            Destroyed
        }
        
        public abstract Result Shoot();
    }
}
