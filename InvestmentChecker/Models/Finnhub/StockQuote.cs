using Newtonsoft.Json;

namespace InvestmentChecker.Models.Finnhub
{
    public class StockQuote
    {
        public StockQuote(double currentPrice, double change, double percentChange, double highPrice, double lowPrice, double openPrice, double previousClose)
        {
            CurrentPrice = currentPrice;
            Change = change;
            PercentChange = percentChange;
            HighPrice = highPrice;
            LowPrice = lowPrice;
            OpenPrice = openPrice;
            PreviousClose = previousClose;
        }

        [JsonProperty("c")]
        public double CurrentPrice { get; set; }

        [JsonProperty("d")]
        public double Change { get; set; }

        [JsonProperty("dp")]
        public double PercentChange { get; set; }

        [JsonProperty("h")]
        public double HighPrice { get; set; }

        [JsonProperty("l")]
        public double LowPrice { get; set; }

        [JsonProperty("o")]
        public double OpenPrice { get; set; }

        [JsonProperty("pc")]
        public double PreviousClose { get; set; }
    }
}
