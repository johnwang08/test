using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinJar;


namespace CoinJarTest
{
    /// <summary>
    /// Test Coin001 class
    /// </summary>
    [TestClass]
    public class Coin001Test
    {
        /// <summary>
        /// Test Coin001 constructor
        /// </summary>
        [TestMethod]
        public void Coin001ConstructorTest()
        {
            Coin001 coin001 = new Coin001();
            
            //assert coin of 1 cent has diameter of 19.00mm, and thickness of 1.55mm
            Assert.AreEqual(19.00m, coin001.diameter);
            Assert.AreEqual(1.55m, coin001.thickness);

        }

        
        /// <summary>
        /// Test Coin001.AddJar method
        /// </summary>
        [TestMethod]
        public void Coin001AddJarTest()
        {
            Coin001 coin001 = new Coin001();
            Jar jar = new Jar();

            //add the 1-cent coin to the jar
            coin001.AddToJar(jar);

            //assert jar.Coin001Counter is 1
            Assert.AreEqual(1, jar.Coin001Counter);

        }

    }
}
