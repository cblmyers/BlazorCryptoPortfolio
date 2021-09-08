using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCryptoPortfolio.Web.Models
{
    public class PriceMultiFull
    {
        public class USD
        {
            public double PRICE { get; set; }
            public double MKTCAP { get; set; }
        }

        public class BTC
        {
            public double PRICE { get; set; }
            public double MKTCAP { get; set; }
        }

        public class Detail
        {
            public USD USD { get; set; }
            public BTC BTC { get; set; }
        }

        public class RootObject
        {
            public Dictionary<string, Detail> RAW { get; set; }
        }
    }
}
