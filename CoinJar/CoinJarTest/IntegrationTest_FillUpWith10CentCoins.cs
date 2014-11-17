using CoinJar;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoinJarTest
{
    /// <summary>
    /// Integration test to fill up jar with 10-cent coins.
    /// </summary>
    [TestClass]
    public class IntegrationTest_FillUpWith10CentCoins
    {
        /// <summary>
        /// Fill up with 10-cent coins.
        /// When the jar is full, it has $278.20 as amount, and 2782 coins of 10-cent
        /// </summary>
        [TestMethod]
        public void FillUpwith10CentCoinTest()
        {
            Jar jar = new Jar();
            Coin010 coin010 = new Coin010();

            //fill up with 10-cent coins
            while (coin010.AddToJar(jar));

            jar.PrintJar();
        }
    }
}
