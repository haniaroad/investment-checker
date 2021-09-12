using InvestmentChecker.Models.Finnhub;
using InvestmentChecker.Services.Interfaces;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace InvestmentChecker.Services.Concretes
{
    public class FinnhubService : IFinnhubService
    {
        public string AuthKey = "c4ukm8aad3ie1t1g1jfg";
        public async Task<StockQuote> GetCurrentStockPrice(string symbol)
        {
            using (var client = new HttpClient())
            {
                var result = client.GetAsync(new Uri($"https://finnhub.io/api/v1/quote?symbol={symbol}&token={AuthKey}")).Result;

                var response = result.Content.ReadAsStringAsync().Result;

                StockQuote quote = JsonConvert.DeserializeObject<StockQuote>(response);

                return quote;

            } 
        }

        public async Task<CryptoQuote> GetCryptoPrice(string symbol)
        {
            using (var client = new HttpClient())
            {
                var result = client.GetAsync(new Uri($"https://finnhub.io/api/v1/crypto/candle?symbol=BINANCE:{symbol}&resolution=D&from=1572651390&to=1575243390&token={AuthKey}")).Result;

                var repsone = result.Content.ReadAsStringAsync().Result;

                CryptoQuote quote = JsonConvert.DeserializeObject<CryptoQuote>(repsone);

                return quote;
            }
        }
    }
}
