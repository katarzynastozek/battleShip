namespace BattleShip
{
    public class OneMastShip : Ship
    {
        public override char Type { get { return '1'; } }

        public OneMastShip()
        {
            lives = 1;
            status = Ship.Status.UNDAMAGED;
        }

        
    }
}
