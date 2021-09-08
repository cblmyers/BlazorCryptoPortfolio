using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlazorCryptoPortfolio.Web.Models
{
    public class Portfolio
    {
        [JsonPropertyName("Assets")]
        public Asset[] Assets { get; set; }
        [JsonPropertyName("Prospects")]
        public Asset[] Prospects { get; set; }
        [JsonPropertyName("InvestmentTotal")]
        public double InvestmentTotal { get; set; }
        public double BTCTotal { get; set; }
        public double USDTotal { get; set; }
        public double ROI { get { return USDTotal / InvestmentTotal; } }
    }
}
