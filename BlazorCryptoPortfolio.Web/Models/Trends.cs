using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCryptoPortfolio.Web.Models
{
    public class Trends
    {
        public TrendData LastHour { get; set; }
        public TrendData Last6Hours { get; set; }
        public TrendData Last12Hours { get; set; }
        public TrendData Last24Hours { get; set; }
        public TrendData Last7Days { get; set; }
        public TrendData Last30Days { get; set; }
    }

    public class TrendData
    {
        public double Value { get; set; }
        public string Css
        {
            get
            {
                return Value switch
                {
                    < 0 => "negative",
                    > 0 => "positive",
                    _   => string.Empty
                };

            }
        }
    }
}
