using CoinJar;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CoinJarTest
{
    /// <summary>
    /// Test Coin050 class
    /// </summary>
    [TestClass]
    public class Coin050Test
    {
        /// <summary>
        /// Test Coin050 constructor
        /// </summary>
        [TestMethod]
        public void Coin050ConstructorTest()
        {
            Coin050 coin050 = new Coin050();

            //assert coin of 50 cent has diameter of 30.61mm, and thickness of 2.15mm
            Assert.AreEqual(30.61m, coin050.diameter);
            Assert.AreEqual(2.15m, coin050.thickness);

        }

        
        /// <summary>
        /// Test Coin050.AddJar method
        /// </summary>
        [TestMethod]
        public void Coin050AddJarTest()
        {
            Coin050 coin050 = new Coin050();
            Jar jar = new Jar();

            //add the 50-cent coin to the jar
            coin050.AddToJar(jar);

            //assert jar.Coin050Counter is 1 and jar.CurrentAmount is $0.50
            Assert.AreEqual(1, jar.Coin050Counter);
            Assert.AreEqual(0.50m, jar.CurrentAmount);

        }

    }
}
