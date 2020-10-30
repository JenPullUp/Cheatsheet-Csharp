using System;
using System.Collections.Generic;
using System.Text;

namespace E2
{
    public enum CoinThrow{
        Kop,
        Munt
    }
    class Munt
    {
        private Random random;
        public CoinThrow ThrowCoin()
        {
            random = new Random();
            return random.Next(100) <= 50 ? CoinThrow.Kop : CoinThrow.Munt;
        }

        public int SimulateThrows(int count)
        {
            int counter = 0;
            for (int i = 0; i <= count; i++)
            {
                if (ThrowCoin() == CoinThrow.Kop)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
