namespace BattleShip
{
    public class FleetConfig
    {
        public int OneMastShipCount { get { return _oneMastShipCount; } set { _oneMastShipCount = value; } }
        public int TwoMastShipCount { get { return _twoMastShipCount; } set { _twoMastShipCount = value; } }
        public int ThreeMastShipCount { get { return _threeMastShipCount; } set { _threeMastShipCount = value; } }

        private int _oneMastShipCount;
        private int _twoMastShipCount;
        private int _threeMastShipCount;
    }
}
