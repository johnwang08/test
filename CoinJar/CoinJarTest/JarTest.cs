using CoinJar;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoinJarTest
{
    /// <summary>
    /// Test jar
    /// </summary>
    [TestClass]
    public class JarTest
    {
        /// <summary>
        /// Test jar resetting
        /// </summary>
        [TestMethod]
        public void ResetJarTest()
        {
            Jar jar = new Jar();
            Coin001 coin001 = new Coin001();
            coin001.AddToJar(jar);

            jar.ResetJar();

            // After calling jar.ResetJar() all properties of jar should be 0.
            Assert.AreEqual(0.0m, jar.CurrentAmount);
            Assert.AreEqual(0.0m, jar.CurrentVolume);
            Assert.AreEqual(0, jar.Coin001Counter);
            Assert.AreEqual(0, jar.Coin005Counter);
            Assert.AreEqual(0, jar.Coin010Counter);
            Assert.AreEqual(0, jar.Coin025Counter);
            Assert.AreEqual(0, jar.Coin050Counter);
            Assert.AreEqual(0, jar.Coin100Counter);
        }
    }
}
