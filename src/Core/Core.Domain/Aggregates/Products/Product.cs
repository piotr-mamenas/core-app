using System.Collections.Generic;
using eCorp.KeyTrade.Core.Domain.Aggregates.Assets;
using eCorp.KeyTrade.Core.Domain.Interfaces;

namespace eCorp.KeyTrade.Core.Domain.Aggregates.Products
{
    public class Product : Entity, IAggregateRoot
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<Asset> Assets { get; set; }

        public Product()
        {
            Assets = null;
        }
    }
}
