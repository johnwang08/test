using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinJar
{
    /// <summary>
    /// Coin class of $1 coin
    /// </summary>
    public class Coin100 : Coin
    {
        /// <summary>
        /// Constructor to set coin diameter and thickness
        /// </summary>
        public Coin100()
        {
            diameter = 26.50m;
            thickness = 2.00m;
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
                jar.Coin100Counter++;
                jar.CurrentAmount += 1.00m;
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
