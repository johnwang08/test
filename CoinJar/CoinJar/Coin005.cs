using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinJar
{
    /// <summary>
    /// Coin class of 5-cent coin.
    /// </summary>
    public class Coin005 : Coin
    {
        /// <summary>
        /// Constructor to set coin diameter and thickness
        /// </summary>
        public Coin005()
        {
            diameter = 21.21m;
            thickness = 1.95m;
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
                jar.Coin005Counter++;
                jar.CurrentAmount += 0.05m;
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
