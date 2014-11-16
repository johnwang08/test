using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinJar;


namespace CoinJarTest
{
    /// <summary>
    /// Test Coin005 class
    /// </summary>
    [TestClass]
    public class Coin005Test
    {
        /// <summary>
        /// Test Coin005 constructor
        /// </summary>
        [TestMethod]
        public void Coin005ConstructorTest()
        {
            Coin005 coin005 = new Coin005();
            //assert coin of 5 cent has diameter of 21.21mm, and thickness of 1.95mm
            Assert.AreEqual(21.21m, coin005.diameter);
            Assert.AreEqual(1.95m, coin005.thickness);

        }

        
        /// <summary>
        /// Test Coin005.AddJar method
        /// </summary>
        [TestMethod]
        public void Coin005AddJarTest()
        {
            Coin005 coin005 = new Coin005();
            Jar jar = new Jar();

            //add the 5-cent coin to the jar
            coin005.AddToJar(jar);

            //assert jar.Coin005Counter is 1
            Assert.AreEqual(1, jar.Coin005Counter);

        }

    }
}
