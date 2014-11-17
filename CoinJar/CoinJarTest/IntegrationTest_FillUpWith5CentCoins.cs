using CoinJar;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoinJarTest
{
    /// <summary>
    /// Integration test to fill up jar with 5-cent coins.
    /// </summary>
    [TestClass]
    public class IntegrationTest_FillUpWith5CentCoins
    {
        /// <summary>
        /// Fill up with 5-cent coins.
        /// When the jar is full, it has $68.65 as amount, and 1373 coins of 5-cent
        /// </summary>
        [TestMethod]
        public void FillUpwith5CentCoinTest()
        {
            Jar jar = new Jar();
            Coin005 coin005 = new Coin005();

            //fill up with 5-cent coins
            while (coin005.AddToJar(jar));

            jar.PrintJar();
        }
    }
}
