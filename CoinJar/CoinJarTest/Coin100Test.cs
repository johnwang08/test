using CoinJar;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CoinJarTest
{
    /// <summary>
    /// Test Coin100 class
    /// </summary>
    [TestClass]
    public class Coin100Test
    {
        /// <summary>
        /// Test Coin100 constructor
        /// </summary>
        [TestMethod]
        public void Coin100ConstructorTest()
        {
            Coin100 coin100 = new Coin100();

            //assert coin of $1 has diameter of 26.50mm, and thickness of 2.00mm
            Assert.AreEqual(26.50m, coin100.diameter);
            Assert.AreEqual(2.00m, coin100.thickness);

        }

        
        /// <summary>
        /// Test Coin100.AddJar method
        /// </summary>
        [TestMethod]
        public void Coin100AddJarTest()
        {
            Coin100 coin100 = new Coin100();
            Jar jar = new Jar();

            //add the $1 coin to the jar
            coin100.AddToJar(jar);

            //assert jar.Coin100Counter is 1 and jar.CurrentAmount is $1.00
            Assert.AreEqual(1, jar.Coin100Counter);
            Assert.AreEqual(1.00m, jar.CurrentAmount);

        }

    }
}
