using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvestmentChecker.Models.Finnhub
{
    public class CryptoQuote
    {
        public CryptoQuote(IEnumerable<double> closePrice, IEnumerable<double> highPrice, IEnumerable<double> lowPrice, IEnumerable<double> openPrice, string status, IEnumerable<int> timestamp, IEnumerable<double> volume)
        {
            ClosePrice = closePrice;
            HighPrice = highPrice;
            LowPrice = lowPrice;
            OpenPrice = openPrice;
            Status = status;
            TimeStamp = timestamp;
            Volume = volume;
        }

        [JsonProperty("c")]
        public IEnumerable<double> ClosePrice { get; set; }

        [JsonProperty("h")]
        public IEnumerable<double> HighPrice { get; set; }

        [JsonProperty("l")]
        public IEnumerable<double> LowPrice { get; set; }

        [JsonProperty("o")]
        public IEnumerable<double> OpenPrice { get; set; }

        [JsonProperty("s")]
        public string Status { get; set; }

        [JsonProperty("t")]
        public IEnumerable<int> TimeStamp { get; set; }

        [JsonProperty("v")]
        public IEnumerable<double> Volume { get; set; }
    }
}
