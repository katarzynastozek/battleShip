using BattleShip;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StatisticTest
{
    [TestClass]
    public class StatisticTest
    {
        [TestMethod]
        public void CheckIfTargetShotsIncrementIsCorrect()
        {
            int targetShots = 6;
            Statistics statistics = new Statistics();
            for (int i = 0; i < targetShots; i++)
            {
                statistics.NewShot(true);
            }
            Assert.AreEqual(targetShots, statistics.ShotsOnTarget);
        }

        [TestMethod]
        public void CheckIfMissedShotsIncrementIsCorrect()
        {
            int missedShots = 5;
            Statistics statistics = new Statistics();
            for (int i = 0; i < missedShots; i++)
            {
                statistics.NewShot(false);
            }
            Assert.AreEqual(missedShots, statistics.ShotsMissed);
        }

        [TestMethod]
        public void CheckIfAllShotsAmountIsCorrect()
        {
            int targetShots = 4;
            int missedShots = 7;
            Statistics statistics = new Statistics();
            for (int i = 0; i < targetShots; i++)
            {
                statistics.NewShot(true);
            }
            for (int i = 0; i < missedShots; i++)
            {
                statistics.NewShot(false);
            }
            Assert.AreEqual(targetShots + missedShots, statistics.Shots);
        }

        [TestMethod]
        public void CheckStatisticsAmountIsCorrect()
        {
            int targetShots = 3;
            int missedShots = 7;
            Statistics statistics = new Statistics();
            for (int i = 0; i < targetShots; i++)
            {
                statistics.NewShot(true);
            }
            for (int i = 0; i < missedShots; i++)
            {
                statistics.NewShot(false);
            }
            Assert.AreEqual(targetShots * 100 / (targetShots + missedShots), statistics.Score);
        }
    }
}
