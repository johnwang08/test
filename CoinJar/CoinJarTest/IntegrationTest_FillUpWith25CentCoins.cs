using CoinJar;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoinJarTest
{
    /// <summary>
    /// Integration test to fill up jar with 25-cent coins.
    /// </summary>
    [TestClass]
    public class IntegrationTest_FillUpWith25CentCoins
    {
        /// <summary>
        /// Fill up with 25-cent coins.
        /// When the jar is full, it has $292.25 as amount, and 1169 coins of 25-cent
        /// </summary>
        [TestMethod]
        public void FillUpwith25CentCoinTest()
        {
            Jar jar = new Jar();
            Coin025 coin025 = new Coin025();

            //fill up with 25-cent coins
            while (coin025.AddToJar(jar));

            jar.PrintJar();
        }
    }
}
