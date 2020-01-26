using System.Collections.Generic;

namespace BattleShip
{
    public class ShipsFactory
    {
        public List<Ship> GetFleet(FleetConfig config)
        {
            List<Ship> fleet = new List<Ship>();

            for (int i = 0; i < config.ThreeMastShipCount; i++)
            {
                fleet.Add(new ThreeMastShip());
            }

            for (byte i = 0; i < config.TwoMastShipCount; i++)
            {
                fleet.Add(new TwoMastShip());
            }

            for (byte i = 0; i < config.OneMastShipCount; i++)
            {
                fleet.Add(new OneMastShip());
            }

            return fleet;
        }
    }
}
