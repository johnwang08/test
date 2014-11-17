using CoinJar;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CoinJarTest
{
    /// <summary>
    /// Test Coin025 class
    /// </summary>
    [TestClass]
    public class Coin025Test
    {
        /// <summary>
        /// Test Coin025 constructor
        /// </summary>
        [TestMethod]
        public void Coin025ConstructorTest()
        {
            Coin025 coin025 = new Coin025();
            //assert coin of 25 cent has diameter of 24.26mm, and thickness of 1.75mm
            Assert.AreEqual(24.26m, coin025.diameter);
            Assert.AreEqual(1.75m, coin025.thickness);

        }

        
        /// <summary>
        /// Test Coin025.AddJar method
        /// </summary>
        [TestMethod]
        public void Coin025AddJarTest()
        {
            Coin025 coin025 = new Coin025();
            Jar jar = new Jar();

            //add the 25-cent coin to the jar
            coin025.AddToJar(jar);

            //assert jar.Coin025Counter is 1 and jar.CurrentAmount is $0.25
            Assert.AreEqual(1, jar.Coin025Counter);
            Assert.AreEqual(0.25m, jar.CurrentAmount);

        }

    }
}
