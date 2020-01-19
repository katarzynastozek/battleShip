using battleShip;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StatisticTest
{
    [TestClass]
    public class StatisticTest
    {
        [TestMethod]
        public void CheckIfShotsIncrementWorkCorrect()
        {
            int targetShots = 6;
            int missedShots = 4;
            for (int i = 0; i < targetShots; i++)
            {
                Statistics.NewShot(true);
            }
            for(int i = 0; i < missedShots; i++)
            {
                Statistics.NewShot(false);
            }
            Assert.AreEqual(targetShots, Statistics.ShotsOnTarget);
            Assert.AreEqual(missedShots, Statistics.ShotsMissed);
            Assert.AreEqual(targetShots+missedShots, Statistics.Shots);
            Assert.AreEqual(targetShots*100/(targetShots + missedShots), Statistics.Score);
        }
    }
}
