namespace BattleShip
{
    public class ThreeMastShip : Ship
    {
        public ThreeMastShip()
        {
            _lives = 3;
            _status = Ship.State.Undamaged;
        }
    }
}

