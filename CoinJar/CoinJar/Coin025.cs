using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinJar
{
    /// <summary>
    /// Coin class of 25-cent coin.
    /// </summary>
    public class Coin025 : Coin
    {
        /// <summary>
        /// Constructor to set coin diameter and thickness
        /// </summary>
        public Coin025()
        {
            diameter = 24.26m;
            thickness = 1.75m;
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
                jar.Coin025Counter++;
                jar.CurrentAmount += 0.25m;
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
