using CoinJar;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CoinJarTest
{
    /// <summary>
    /// Test Coin010 class
    /// </summary>
    [TestClass]
    public class Coin010Test
    {
        /// <summary>
        /// Test Coin010 constructor
        /// </summary>
        [TestMethod]
        public void Coin010ConstructorTest()
        {
            Coin010 coin010 = new Coin010();

            //assert coin of 10 cent has diameter of 17.91mm, and thickness of 1.35mm
            Assert.AreEqual(17.91m, coin010.diameter);
            Assert.AreEqual(1.35m, coin010.thickness);

        }

        
        /// <summary>
        /// Test Coin010AddJar method
        /// </summary>
        [TestMethod]
        public void Coin010AddJarTest()
        {
            Coin010 coin010 = new Coin010();
            Jar jar = new Jar();

            //add the 10-cent coin to the jar
            coin010.AddToJar(jar);

            //assert jar.Coin010Counter is 1 and jar.CurrentAmount is $0.10
            Assert.AreEqual(1, jar.Coin010Counter);
            Assert.AreEqual(0.10m, jar.CurrentAmount);

        }

    }
}
