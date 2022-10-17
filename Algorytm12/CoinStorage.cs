using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytm12
{
    internal class CoinStorage
    {
        internal int CoinValue { get; set; }
        internal int CoinsAvailable { get; set; }

        public CoinStorage(int coin, int available)
        {
            this.CoinValue = coin;
            this.CoinsAvailable = available;
        }
    }
}
