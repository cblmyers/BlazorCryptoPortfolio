using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlazorCryptoPortfolio.Web.Models
{
    public class Asset
    {
        [Key]
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }
        [JsonPropertyName("coinMarketCapURL")]
        public string URL { get; set; }
        [JsonPropertyName("numberOfTokens")]
        public double TokensOwned { get; set; }
        public double BTCPrice { get; set; }
        public double USDPrice { get; set; }
        public double BTCTotal { get { return TokensOwned * BTCPrice; } }
        public double USDTotal { get { return TokensOwned * USDPrice; } }
        public double TotalValuePercentage { get; set; }
        public double MarketCap { get; set; }
        public Trends Trends { get; set; }
    }
}
