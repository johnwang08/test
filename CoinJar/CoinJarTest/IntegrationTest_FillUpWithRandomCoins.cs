using System;
using CoinJar;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoinJarTest
{
    /// <summary>
    /// Integration test to fill up jar with random coins.
    /// </summary>
    [TestClass]
    public class IntegrationTest_FillUpWithRandomCoins
    {
        /// <summary>
        /// Fill up with random coins.
        /// </summary>
        [TestMethod]
        public void FillUpwithRandomCoinTest()
        {
            Jar jar = new Jar();

            Random rnd = new Random();

            // coin.AddToJar failure indicates jar full.
            var addJarSucceeded=false;

            do
            {
                // Generate random int with range of [1,6]
                // 1-- 1 cent coin
                // 2-- 5 cent coin
                // 3-- 10 cent coin
                // 4-- 25 cent coin
                // 5-- 50 cent coin
                // 6-- $1 coin
                var coinType = rnd.Next(1, 7);
                switch (coinType)
                {
                    case 1:
                        addJarSucceeded = new Coin001().AddToJar(jar);
                        break;
                    case 2:
                        addJarSucceeded = new Coin005().AddToJar(jar);
                        break;
                    case 3:
                        addJarSucceeded = new Coin010().AddToJar(jar);
                        break;
                    case 4:
                        addJarSucceeded = new Coin025().AddToJar(jar);
                        break;
                    case 5:
                        addJarSucceeded = new Coin050().AddToJar(jar);
                        break;
                    default:
                        addJarSucceeded = new Coin100().AddToJar(jar);
                        break;
                }
            }
            //fill up random coins
            while (addJarSucceeded);

            jar.PrintJar();
        }
    }
}
