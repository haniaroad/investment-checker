using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvestmentChecker.Models.Finnhub
{
    public class StockSymbol
    {
        public StockSymbol()
        {

        }
        public StockSymbol(string symbol)
        {
            Symbol = symbol;
        }
        public string Symbol { get; set; }
    }
}
