using System.Collections.Generic;
using eCorp.KeyTrade.Core.Domain.Models.Assets;

namespace eCorp.KeyTrade.Core.Domain.Models.Products
{
    public class Product
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
