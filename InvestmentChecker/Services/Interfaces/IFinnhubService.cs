using InvestmentChecker.Models.Finnhub;
using System.Threading.Tasks;

namespace InvestmentChecker.Services.Interfaces
{
    public interface IFinnhubService
    {
        public Task<StockQuote> GetCurrentStockPrice(string symbol);

        public Task<CryptoQuote> GetCryptoPrice(string symbol);
    }
}
