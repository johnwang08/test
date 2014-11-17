using CoinJar;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoinJarTest
{
    /// <summary>
    /// Integration test to fill up jar with $1 coins.
    /// </summary>
    [TestClass]
    public class IntegrationTest_FillUpWith100CentCoins
    {
        /// <summary>
        /// Fill up with $1 coins.
        /// When the jar is full, it has $857 as amount, and 857 coins of $1
        /// </summary>
        [TestMethod]
        public void FillUpwith100CentCoinTest()
        {
            Jar jar = new Jar();
            Coin100 coin100 = new Coin100();

            //fill up with $1 coins
            while (coin100.AddToJar(jar));

            jar.PrintJar();
        }
    }
}
