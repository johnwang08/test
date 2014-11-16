using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinJar
{
    interface ICoin
    {
        /// <summary>
        /// Get volume of the coin in fluid ounces
        /// </summary>
        /// <returns></returns>
        decimal GetVolume();
    }
}
