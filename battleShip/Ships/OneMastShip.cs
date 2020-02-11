namespace BattleShip
{
    public class OneMastShip : Ship
    {
        public OneMastShip()
        {
            _lives = 1;
            _status = Ship.State.Undamaged;
        }
    }
}
