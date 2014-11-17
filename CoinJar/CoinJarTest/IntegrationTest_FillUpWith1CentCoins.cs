using CoinJar;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoinJarTest
{
    /// <summary>
    /// Integration test to fill up jar with 1-cent coins.
    /// </summary>
    [TestClass]
    public class IntegrationTest_FillUpWith1CentCoins
    {
        /// <summary>
        /// Fill up with 1-cent coins.
        /// When the jar is full, it has $21.53 as amount, and 2153 coins of 1-cent
        /// </summary>
        [TestMethod]
        public void FillUpwith1CentCoinTest()
        {
            Jar jar = new Jar();
            Coin001 coin001 = new Coin001();

            //fill up with 1-cent coins
            while (coin001.AddToJar(jar));

            jar.PrintJar();
        }
    }
}
