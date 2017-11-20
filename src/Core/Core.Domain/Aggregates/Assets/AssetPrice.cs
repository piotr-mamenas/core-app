using System;
using eCorp.KeyTrade.Core.Domain.Aggregates.Currencies;

namespace eCorp.KeyTrade.Core.Domain.Aggregates.Assets
{
    public class AssetPrice : Entity
    {
        public Currency Currency { get; set; }

        public DateTime Timestamp { get; set; }

        public Asset Asset { get; set; }
        public Guid AssetGuid { get; set; }

        public decimal Amount { get; set; }
    }
}
