using System.Collections.Generic;

namespace eCorp.KeyTrade.Core.Domain.Models.Assets
{
    public class Asset
    {
        public string Name { get; set; }

        public ICollection<AssetPrice> Prices { get; set; }
    }
}
