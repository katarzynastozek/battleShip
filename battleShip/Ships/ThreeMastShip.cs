namespace BattleShip
{
    public class ThreeMastShip : Ship
    {
        public override char Type { get { return '3'; } }

        public ThreeMastShip()
        {
            lives = 3;
            status = Ship.Status.UNDAMAGED;
        }

    }
}
