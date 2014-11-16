using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinJar
{
    class Program
    {
        /// <summary>
        /// demo
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Jar jar = new Jar();
            Console.WriteLine("Initially:\n");
            jar.PrintJar();

            var coin001 = new Coin001();
            coin001.AddToJar(jar);

            Console.WriteLine("\r\n\r\n\r\n\r\nAfter added 1 cent to the jar:\n");
            jar.PrintJar();

            
        }
    }
}
