using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinJar
{
    /// <summary>
    /// Coin class of 50-cent coin.
    /// </summary>
    public class Coin050 : Coin
    {
        /// <summary>
        /// Constructor to set coin diameter and thickness
        /// </summary>
        public Coin050()
        {
            diameter = 30.61m;
            thickness = 2.15m;
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
                jar.Coin050Counter++;
                jar.CurrentAmount += 0.50m;
                jar.CurrentVolume += GetVolume();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
