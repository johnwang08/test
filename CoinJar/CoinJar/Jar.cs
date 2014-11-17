using System;

namespace CoinJar
{
    /// <summary>
    /// Class Jar with capacity of 32 US fluid ounces
    /// </summary>
    public class Jar
    {
        /// <summary>
        /// capacity of the jar
        /// </summary>
        public const int maxVolume = 32;

        /// <summary>
        /// Current voulme filled by coins. The remaining volume is maxVolume-CurrentVolume
        /// </summary>
        public decimal CurrentVolume { get; set; }

        /// <summary>
        /// Current amount of the coins
        /// </summary>
        public decimal CurrentAmount { get; set; }

        /// <summary>
        /// Counter of 1-cent coins
        /// </summary>
        public int Coin001Counter { get; set; }

        /// <summary>
        /// Counter of 5-cent coins
        /// </summary>
        public int Coin005Counter { get; set; }

        /// <summary>
        /// Counter of 10-cent coins
        /// </summary>
        public int Coin010Counter { get; set; }

        /// <summary>
        /// Counter of 25-cent coins
        /// </summary>
        public int Coin025Counter { get; set; }
        
        /// <summary>
        /// Counter of 50-cent coins
        /// </summary>
        public int Coin050Counter { get; set; }

        /// <summary>
        /// Counter of $1 coins
        /// </summary>
        public int Coin100Counter { get; set; }

        /// <summary>
        /// Reset the jar
        /// </summary>
        public void ResetJar()
        {
            CurrentAmount = 0;
            CurrentVolume = 0;
            Coin001Counter = 0;
            Coin005Counter = 0;
            Coin010Counter = 0;
            Coin025Counter = 0;
            Coin050Counter = 0;
            Coin100Counter = 0;
        }

        /// <summary>
        /// print the jar
        /// </summary>
        public void PrintJar()
        {
            Console.WriteLine("\r\nPrint CoinJar as of {0}", DateTime.Now);
            Console.WriteLine("\tCurrent Amount {0:C}", CurrentAmount);
            Console.WriteLine("\tCoin of 1 Cent Counter {0}", Coin001Counter);
            Console.WriteLine("\tCoin of 5 Cents Counter {0}", Coin005Counter);
            Console.WriteLine("\tCoin of 10 Cents Counter {0}", Coin010Counter);
            Console.WriteLine("\tCoin of 25 Cents Counter {0}", Coin025Counter);
            Console.WriteLine("\tCoin of 50 Cents Counter {0}", Coin050Counter);
            Console.WriteLine("\tCoin of 1 Dollars Counter {0}", Coin100Counter);
            Console.WriteLine("\tCurrent Voulme {0}", CurrentVolume);
        }


    }
}
