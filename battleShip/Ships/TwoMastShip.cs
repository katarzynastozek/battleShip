namespace BattleShip
{
    public class TwoMastShip : Ship
    {
        public TwoMastShip()
        {
            _lives = 2;
            _status = Ship.State.Undamaged;
        }
    }
}
