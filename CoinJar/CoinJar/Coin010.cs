
namespace CoinJar
{
    /// <summary>
    /// Coin class of 10-cent coin.
    /// </summary>
    public class Coin010 : Coin
    {
        /// <summary>
        /// Constructor to set coin diameter and thickness
        /// </summary>
        public Coin010()
        {
            diameter = 17.91m;
            thickness = 1.35m;
        }

        /// <summary>
        /// Add the coin to a jar
        /// </summary>
        /// <param name="jar"></param>
        /// <returns>true: succeeded adding the coin to the jar</returns>
        public override bool AddToJar(Jar jar)
        {
            decimal v = GetVolume();

            if (jar.CurrentVolume + v < Jar.maxVolume)
            {
                jar.Coin010Counter++;
                jar.CurrentAmount += 0.10m;
                jar.CurrentVolume += v;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
