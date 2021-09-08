using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCryptoPortfolio.Web.Models
{
    public class HistoPrices
    {
        public class HistoDatum
        {
            public int time { get; set; }
            public double close { get; set; }
            public double high { get; set; }
            public double low { get; set; }
            public double open { get; set; }
            public double volumefrom { get; set; }
            public double volumeto { get; set; }
        }

        public class ConversionType
        {
            public string type { get; set; }
            public string conversionSymbol { get; set; }
        }

        public class RootObject
        {
            public string Response { get; set; }
            public int Type { get; set; }
            public bool Aggregated { get; set; }
            public List<HistoDatum> Data { get; set; }
            public int TimeTo { get; set; }
            public int TimeFrom { get; set; }
            public bool FirstValueInArray { get; set; }
            public ConversionType ConversionType { get; set; }
        }
    }
}
