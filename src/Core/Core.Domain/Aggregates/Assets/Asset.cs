using System.Collections.Generic;
using eCorp.KeyTrade.Core.Domain.Interfaces;

namespace eCorp.KeyTrade.Core.Domain.Aggregates.Assets
{
    public class Asset : Entity, IAggregateRoot
    {
        public string Name { get; set; }

        public ICollection<AssetPrice> Prices { get; set; }
    }
}
