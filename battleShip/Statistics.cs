using System;
using System.Collections.Generic;
using System.Text;

namespace battleShip
{
    public static class Statistics
    {
        public static int Shots { get { return shots; } }
        public static int ShotsOnTarget { get { return shotsOnTarget; } }
        public static int ShotsMissed { get { return shots - shotsOnTarget; } }
        public static float Score { get { return shotsOnTarget * 100 / shots; } }

        private static int shots = 0;
        private static int shotsOnTarget = 0;

        public static void NewShot(bool _onTarget)
        {
            shots++;
            if (_onTarget) shotsOnTarget++;
        }
    }
}
