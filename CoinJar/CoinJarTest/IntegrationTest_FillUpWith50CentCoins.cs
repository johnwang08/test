using CoinJar;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoinJarTest
{
    /// <summary>
    /// Integration test to fill up jar with 50-cent coins.
    /// </summary>
    [TestClass]
    public class IntegrationTest_FillUpWith50CentCoins
    {
        /// <summary>
        /// Fill up with 50-cent coins.
        /// When the jar is full, it has $299 as amount, and 598 coins of 50-cent
        /// </summary>
        [TestMethod]
        public void FillUpwith50CentCoinTest()
        {
            Jar jar = new Jar();
            Coin050 coin050 = new Coin050();

            //fill up with 50-cent coins
            while (coin050.AddToJar(jar));

            jar.PrintJar();
        }
    }
}
