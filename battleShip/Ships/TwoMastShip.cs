namespace BattleShip
{
    public class TwoMastShip : Ship
    {
        public override char Type { get { return '2'; } }

        public TwoMastShip()
        {
            lives = 2;
            status = Ship.Status.UNDAMAGED;
        }
    }
}
