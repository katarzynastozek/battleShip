namespace BattleShip
{
    public abstract class BoardField : Shot
    {
        public static class Status
        {
            public const char EMPTY = 'O';
            public const char SHOT_DOWN = '*';
        }

        public char status;

        abstract public char GetStatus();

        abstract public char GetShipType();
    }
}
