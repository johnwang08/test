using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinJar
{
    /// <summary>
    /// Base class for coin.
    /// </summary>
    public abstract class Coin : ICoin
    {
        /// <summary>
        /// diameter of coin in mm.
        /// </summary>
        public decimal diameter;

        /// <summary>
        /// thickness of coin in mm.
        /// </summary>
        public decimal thickness;

        /// <summary>
        /// Get volume of the coin in fluid ounces
        /// </summary>
        /// <returns></returns>
        public decimal GetVolume()
        {
            //calculate volume of the coin. convert it into US fluid ounces
            // 1 millimeter cubed = 3.38140227 × 10-5 US fluid ounces
            decimal v = ConvertCubicMmToFluidOunce(GetCylinderVoulme(diameter, thickness));

            return v;
        }

        /// <summary>
        /// Abstract method to add the coin to the jar.
        /// Due to different coins have different specification and value, we need to implement it in derived sub-class
        /// </summary>
        /// <param name="jar"></param>
        /// <returns>true: succeeded adding the coin to the jar</returns>
        public abstract bool AddToJar(Jar jar);

        // Get circle area by radius
        private decimal GetCircleAreaByRadius(decimal radius)
        {
            //circle area = radius * radius * PI
            return radius * radius * Convert.ToDecimal(Math.PI);
        }


        // Get circle area by daimeter
        private decimal GetCircleAreaByDiameter(decimal diameter)
        {
            decimal r = diameter / 2.0m;
            return GetCircleAreaByRadius(r);
        }

        // Get cylinder volume by diameter and high
        private decimal GetCylinderVoulme(decimal diameter, decimal high)
        {
            return GetCircleAreaByDiameter(diameter)*high;
        }

        // Convert  cubic mm to fluid ounces
        private decimal ConvertCubicMmToFluidOunce(decimal cubicMm)
        {
            // 1 millimeter cubed = 3.38140227 × 10-5 US fluid ounces
            return cubicMm* 0.0000338140227m;
        }
    }
}
