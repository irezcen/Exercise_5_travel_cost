using System;
using System.Collections.Generic;
using System.Text;

namespace zadanie_5
{
    class WorldMarket
    {
        private static Random random = new Random();
        public static int GetInitialPricePerKg()
        {
            return random.Next(100, 1000);
        }
        public static int GetNewPricePerKg(int staraCena)
        {
            return staraCena + random.Next(-50, 200);
        }
    }
}
