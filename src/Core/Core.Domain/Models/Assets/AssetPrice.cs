using System;
using eCorp.KeyTrade.Core.Domain.Models.Currencies;

namespace eCorp.KeyTrade.Core.Domain.Models.Assets
{
    public class AssetPrice
    {
        public Currency Currency { get; set; }

        public DateTime Timestamp { get; set; }

        public Asset Asset { get; set; }
        public Guid AssetGuid { get; set; }

        public decimal Amount { get; set; }
    }
}
