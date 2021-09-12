using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvestmentChecker.Models.Finnhub
{
    public class CryptoSymbol
    {
        public CryptoSymbol()
        {

        }
        public CryptoSymbol(string symbol)
        {
            Symbol = symbol;
        }
        public string Symbol { get; set; }

    }
}
